using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP;
using Microsoft.Extensions.DependencyInjection;

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
        private string _ReaderSerial = "";
        public Verification()
        {
            _studentService = Program.ServiceProvider.GetRequiredService<IStudentLogService>();
            _teacherService = Program.ServiceProvider.GetRequiredService<ITeacherLogService>();
        }
        protected override async void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            if (features != null)
            {
                var students = await _studentService.VerifyStudentFingerprint(features, _ReaderSerial);
                var teachers = await _teacherService.VerifyTeacherFingerprint(features, _ReaderSerial);
                if(students != null && students.Count() > 0)
                {
                    GenerateStudentData(students);
                    foreach(var student in students)
                    {
                        var LogResult = await _studentService.LogStudent(student, _ReaderSerial);
                        if(LogResult.IsSuccess)
                        {
                            GenerateState(LogResult.Message);
                        }
                        else
                        {
                            var OnBreakresult = await _studentService.LogOnBreakStudent(student, _ReaderSerial);
                            if(OnBreakresult != null)
                            {
                                if(OnBreakresult.IsSuccess)
                                {
                                    GenerateState(OnBreakresult.Message);
                                }
                                else
                                {
                                    GenerateState("Student already logged in");    
                                }
                            }
                        }
                    }
                }
                if(teachers != null)
                {
                    GenerateTeacherData(teachers);
                    var logResult = await _teacherService.LogTeacher(teachers, _ReaderSerial);
                    if(logResult.IsSuccess)
                    {
                        GenerateState(logResult.Message);
                    }
                    else
                    {
                        var OnBreakresult = await _teacherService.LogOnBreakTeacher(teachers, _ReaderSerial);
                        if(OnBreakresult != null)
                        {
                            if(OnBreakresult.IsSuccess)
                            {
                                GenerateState(OnBreakresult.Message);
                            }
                            else
                            {
                                GenerateState("Teacher already logged in");    
                            }
                        }
                    }
                }
                else
                {
                    // handle intruder here
                }
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

    }
}
