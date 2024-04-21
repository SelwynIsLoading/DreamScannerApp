using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP;
using Microsoft.Extensions.DependencyInjection;
using DreamScannerApp.Handlers;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace DreamScannerApp.Services
{
    public class Verification : FingerprintHandler
    {
        public delegate void StudentDataCallback(List<StudentsDTO.StudentDetail> data);
        public delegate void TeacherDataCallback(List<TeachersDTO> data);
        public delegate void StateCallback(string state);
        public delegate void InvalidCallback();
        public delegate void AdminCallback(bool verified);
        public event AdminCallback adminCallback;
        public event StudentDataCallback studentDataCallback;
        public event StateCallback stateCallback;
        public event TeacherDataCallback teacherDataCallback;
        public event InvalidCallback invalidCallback;
        private readonly IStudentLogService _studentService;
        private readonly ITeacherLogService _teacherService;
        private readonly ISettingsService _settingsService;
        private readonly IExcelService _excelService;
        private readonly IEmailService _emailService;
        private readonly IArduinoService _arduinoService;
        private string _ReaderSerial = "";

        private int InvalidAttempts = 0;
        public Verification()
        {
            _studentService = Program.ServiceProvider.GetRequiredService<IStudentLogService>();
            _teacherService = Program.ServiceProvider.GetRequiredService<ITeacherLogService>();
            _excelService = Program.ServiceProvider.GetRequiredService<IExcelService>();
            _emailService = Program.ServiceProvider.GetRequiredService<IEmailService>();
            _settingsService = Program.ServiceProvider.GetRequiredService<ISettingsService>();
            _arduinoService = Program.ServiceProvider.GetRequiredService<IArduinoService>();
        }
        protected override async void Process(DPFP.Sample Sample)
        {
            try
            {
                DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

                if (features == null) return;

                var isHold = Properties.Settings.Default.IsHold;

                var tasks = new List<Task>();

                var teachersTask = _teacherService.VerifyTeacherFingerprint(features, _ReaderSerial);
                var studentsTask = _studentService.VerifyStudentFingerprint(features, _ReaderSerial);
                var adminTask = _studentService.VerifyAdmin(features);

                tasks.Add(teachersTask);
                tasks.Add(studentsTask);
                tasks.Add(adminTask);

                await Task.WhenAll(tasks);

                var teachers = await teachersTask;
                var students = await studentsTask;
                var admin = await adminTask;

                if (students != null)
                {
                    GenerateStudentData(students);
                    OpenDoor();
                    InvalidAttempts = 0;
                    if (isHold)
                    {
                        GenerateState("Logging is disabled");
                        return;
                    }
                    await ProcessStudents(students);
                }
                else if (teachers != null)
                {
                    GenerateTeacherData(teachers);
                    OpenDoor();
                    InvalidAttempts = 0;
                    if (isHold)
                    {
                        GenerateState("Logging is disabled");
                        return;
                    }
                    await ProcessTeachers(teachers);
                }

                if (admin.IsSaved)
                {
                    adminCallback?.Invoke(true);
                }

                InvalidAttemptsCount();
                GenerateInvalid();
                adminCallback?.Invoke(false);
                await _arduinoService.InvalidAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            base.Process(Sample);
        }



        private async Task ProcessStudents(List<StudentsDTO.StudentDetail> students)
        {            
            foreach (var student in students)
            {
                var logResult = await _studentService.LogStudent(student, _ReaderSerial);
                if (logResult.IsSuccess)
                    GenerateState(logResult.Message);
                else
                    await HandleStudentLogging(student);
            }
        }

        private async Task HandleStudentLogging(StudentsDTO.StudentDetail student)
        {
            var onBreakResult = await _studentService.LogOnBreakStudent(student, _ReaderSerial);
            if (onBreakResult != null && onBreakResult.IsSuccess)
                GenerateState(onBreakResult.Message);
            else
                GenerateState("Student already logged in");
        }

        private async Task ProcessTeachers(List<TeachersDTO> teachers)
        {
            foreach(var teacher in teachers)
            {
                var logResult = await _teacherService.LogTeacher(teacher, _ReaderSerial);
                if (logResult.IsSuccess)
                    GenerateState(logResult.Message);
                else
                    await HandleTeacherLogging(teacher);
            }
        }

        private async Task HandleTeacherLogging(TeachersDTO teachers)
        {
            if (!CheckSerial(_ReaderSerial) && DialogResult.Yes == MessageBox.Show("Do you want to log out?", "Teacher Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question))                
            {
                try
                {
                    MemoryStream excelStream = new MemoryStream();
                    var presentStudents = await _teacherService.GetPresentStudents();
                    var teacherLogs = await _teacherService.GetTeacherLogs();
                    await _excelService.StudentExcelReport(presentStudents, excelStream);
                    EmailDTO email = new EmailDTO
                    {
                        SenderEmail = "dreamscannerapp@gmail.com",
                        SenderPassword = "fzcn pefe jcvc smqa",
                        RecipientEmail = teachers.Email,
                        Subject = "Attendance Report",
                        AttachmentData = excelStream.ToArray(),
                        AttachmentFileName = "AttendanceReport.xlsx"
                    };
                    await _emailService.SendEmail(email);
                    MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                await LogOnBreakTeacher(teachers);
            }
        }

        private async Task LogOnBreakTeacher(TeachersDTO teachers)
        {
            try
            {
                var onBreakResult = await _teacherService.LogOnBreakTeacher(teachers, _ReaderSerial);
                if (onBreakResult != null && onBreakResult.IsSuccess)
                    GenerateState(onBreakResult.Message);
                else
                    GenerateState("Teacher already logged in");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to Log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public override void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            _ReaderSerial = ReaderSerialNumber;
            base.OnComplete(Capture, ReaderSerialNumber, Sample);
        }

        public void GenerateStudentData(List<StudentsDTO.StudentDetail> students)
        {
            studentDataCallback?.Invoke(students);
        }      
        
        public void GenerateState(string state)
        {
            stateCallback?.Invoke(state);
        }

        public void GenerateTeacherData(List<TeachersDTO> teachers)
        {
            teacherDataCallback?.Invoke(teachers);
        }

        public void GenerateInvalid()
        {
            invalidCallback?.Invoke();
        }

        private bool CheckSerial(string ReaderSerial)
        {
            return ReaderSerial switch
            {
                "18ecdae0-2be8-1e4b-a8cd-6eab443153de" => true,
                "3fa23b39-d804-6a4e-918e-73e7f59f4717" => false,
                _ => false
            };
        }

        private async void InvalidAttemptsCount()
        {
            InvalidAttempts++;
            
            if (InvalidAttempts == 3)
            {
                var bot = new TelegramBotClient("6913256102:AAFno3RqCBd2toPI5dYAdn6MC2bBUzPDDN4");
                long chatId = -1002041033089;

                // Send a dummy message to your channel
                // Send an alert message
                await bot.SendTextMessageAsync(chatId, $"🚨 Alert: Intruder Alert at room {Properties.Settings.Default.RoomPlaced}!");
                InvalidAttempts = 0;
            }
        }

        private async void OpenDoor()
        {
            await _arduinoService.DoorOpenAsync();
            await Task.Delay(1);
            await _arduinoService.DoorCloseAsync();
        }

    }
}
