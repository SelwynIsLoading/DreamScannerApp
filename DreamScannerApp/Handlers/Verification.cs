﻿using DreamScannerApp.Interfaces;
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
        public delegate void StateCallback(string state); 
        public event StudentDataCallback studentDataCallback;
        public event StateCallback stateCallback;
        private readonly IStudentLogService _studentService;
        private string _ReaderSerial = "";
        public Verification()
        {
            _studentService = Program.ServiceProvider.GetRequiredService<IStudentLogService>();
        }
        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            if (features != null)
            {
                var students = _studentService.VerifyStudentFingerprint(features, _ReaderSerial);
                GenerateStudentData(students);
                if(students != null && students.Count() > 0)
                {
                    foreach(var student in students)
                    {
                        var LogResult = _studentService.LogStudent(student, _ReaderSerial);
                        if(LogResult.FirstOrDefault().IsSuccess)
                        {
                            GenerateState(LogResult.FirstOrDefault().Message);
                        }
                        else
                        {
                            var OnBreakresult = _studentService.LogOnBreakStudent(student, _ReaderSerial);
                            if(OnBreakresult != null && OnBreakresult.Count() > 0)
                            {
                                if(OnBreakresult.FirstOrDefault().IsSuccess)
                                {
                                    GenerateState(OnBreakresult.FirstOrDefault().Message);
                                }
                                else
                                {
                                    GenerateState("Student already logged in");    
                                }
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

    }
}
