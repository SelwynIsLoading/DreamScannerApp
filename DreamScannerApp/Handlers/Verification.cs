﻿using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP;
using Microsoft.Extensions.DependencyInjection;
using DreamScannerApp.Handlers;

namespace DreamScannerApp.Services
{
    public class Verification : FingerprintHandler
    {
        public delegate void StudentDataCallback(List<StudentsDTO.StudentDetail> data);
        public delegate void TeacherDataCallback(TeachersDTO data);
        public delegate void StateCallback(string state); 
        public event StudentDataCallback studentDataCallback;
        public event StateCallback stateCallback;
        public event TeacherDataCallback teacherDataCallback;
        private readonly IStudentLogService _studentService;
        private readonly ITeacherLogService _teacherService;
        private readonly IExcelService _excelService;
        private readonly IEmailService _emailService;
        private string _ReaderSerial = "";
        public Verification()
        {
            _studentService = Program.ServiceProvider.GetRequiredService<IStudentLogService>();
            _teacherService = Program.ServiceProvider.GetRequiredService<ITeacherLogService>();
            _excelService = Program.ServiceProvider.GetRequiredService<IExcelService>();
            _emailService = Program.ServiceProvider.GetRequiredService<IEmailService>();
        }
        protected override async void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            if (features == null) return;

            var students = await _studentService.VerifyStudentFingerprint(features, _ReaderSerial);
            var teachers = await _teacherService.VerifyTeacherFingerprint(features, _ReaderSerial);

            if (students != null && students.Any())
            {
                await ProcessStudents(students);
            }

            if (teachers != null)
            {
                await ProcessTeachers(teachers);
            }
            else
            {
                // handle intruder here
            }
        }

        private async Task ProcessStudents(List<StudentsDTO.StudentDetail> students)
        {
            GenerateStudentData(students);

            foreach (var student in students)
            {
                var logResult = await _studentService.LogStudent(student, _ReaderSerial);
                if (logResult.IsSuccess)
                {
                    GenerateState(logResult.Message);
                }
                else
                {
                    await HandleStudentLoggingError(student);
                }
            }
        }

        private async Task HandleStudentLoggingError(StudentsDTO.StudentDetail student)
        {
            var onBreakResult = await _studentService.LogOnBreakStudent(student, _ReaderSerial);
            if (onBreakResult != null && onBreakResult.IsSuccess)
            {
                GenerateState(onBreakResult.Message);
            }
            else
            {
                GenerateState("Student already logged in");
            }
        }

        private async Task ProcessTeachers(TeachersDTO teachers)
        {
            GenerateTeacherData(teachers);

            var logResult = await _teacherService.LogTeacher(teachers, _ReaderSerial);
            if (logResult.IsSuccess)
                GenerateState(logResult.Message);
            else
                await HandleTeacherLogging(teachers);
        }

        private async Task HandleTeacherLogging(TeachersDTO teachers)
        {
            if (!CheckSerial(_ReaderSerial) && DialogResult.Yes == MessageBox.Show("Do you want to log out?", "Teacher Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question))                
            {
                try
                {
                    MemoryStream excelStream = new MemoryStream();
                    var presentStudents = await _teacherService.GetPresentStudents();
                    await _excelService.StudentExcelReport(presentStudents, excelStream);
                    EmailDTO email = new EmailDTO
                    {
                        SenderEmail = "dreamscannerapp@gmail.com",
                        SenderPassword = "fzcn pefe jcvc smqa",
                        RecipientEmail = "2000821@ub.edu.ph",
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
                {
                    GenerateState(onBreakResult.Message);
                }
                else
                {
                    GenerateState("Teacher already logged in");
                }
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

        public void GenerateTeacherData(TeachersDTO teachers)
        {
            teacherDataCallback?.Invoke(teachers);
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

    }
}
