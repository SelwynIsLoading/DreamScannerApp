using DreamScannerApp.Models;
using DreamScannerApp.Models.Entities;
using DreamScannerApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DreamScannerApp.Services
{
    public class StudentLogService : IStudentLogService
    {
        private ApplicationDbContext _context;
        public StudentLogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Handlers.StudentLogResult> LogStudent(StudentsDTO.StudentDetail student, string ReaderSerial)
        {
            List<Handlers.StudentLogResult> results = new List<Handlers.StudentLogResult>();
            using(_context = new ApplicationDbContext())
            {
                var studentLogs = _context.Students.Where(s => s.FingerprintID == student.FingerprintID).AsSplitQuery().AsNoTracking().FirstOrDefault();
                var studentEntered = _context.StudentLogs.Where(s => s.FingerprintID == student.FingerprintID && s.Date == DateTime.Now.Date).AsSplitQuery().AsNoTracking().FirstOrDefault();
                if(studentLogs != null && studentEntered == null)
                {
                    _context.StudentLogs.Add(new StudentLogsEntity
                    {
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        MiddleInitial = student.MiddleInitial,
                        StudentNumber = student.StudentNumber,
                        FingerprintID = student.FingerprintID,
                        Section = student.section,
                        Room = student.room,
                        Date = DateTime.Now.Date,
                        TimeIn = CheckSerial(ReaderSerial) ? DateTime.Now.TimeOfDay : TimeSpan.Zero,
                        TimeOut = TimeSpan.Zero,
                        AttendanceStatus = "Present",
                        AttendanceState = 1
                    });
                }
                results.Add(new Handlers.StudentLogResult
                {
                    IsSuccess = _context.SaveChanges() > 0,
                    Message = "Student Logged In Successfully!"
                });
                return results;
            }
        }

        public List<Handlers.StudentLogResult> LogOnBreakStudent(StudentsDTO.StudentDetail student, string ReaderSerial)
        {    
            string _message = "";
            List<Handlers.StudentLogResult> results = new List<Handlers.StudentLogResult>();
            using (_context = new ApplicationDbContext())
            {
                var studentEntered = _context.StudentLogs.Where(s => s.FingerprintID == student.FingerprintID && s.Date == DateTime.Now.Date).FirstOrDefault();
                // set the student on break
                if (studentEntered != null && studentEntered.AttendanceState == 1 && !CheckSerial(ReaderSerial))
                {
                    studentEntered.TimeOut = DateTime.Now.TimeOfDay;
                    studentEntered.AttendanceStatus = "On Break";
                    studentEntered.AttendanceState = 2;
                    _message = "Student Logged Out Successfully!";
                }
                // check if student is over break
                if (studentEntered != null && studentEntered.AttendanceState==2 && CheckSerial(ReaderSerial))
                {
                    TimeSpan timeDifference = DateTime.Now.TimeOfDay - studentEntered.TimeOut;
                    double totalMinutes = timeDifference.TotalMinutes;

                    if(totalMinutes >= 1) // TODO: change to 15 minutes threshold
                    {
                        studentEntered.TimeOut = DateTime.Now.TimeOfDay;
                        studentEntered.AttendanceStatus = $"Over break: {totalMinutes.ToString("N1")}";   
                        studentEntered.AttendanceState = 1;
                        _message = $"Over break excess: {totalMinutes.ToString("N1")} minutes";
                    }
                    else
                    {
                        studentEntered.TimeOut = DateTime.Now.TimeOfDay;
                        studentEntered.AttendanceStatus = "Present";
                        studentEntered.AttendanceState = 1;
                        _message = "Student Logged In Successfully!";
                    }
                }

                results.Add(new Handlers.StudentLogResult { IsSuccess = _context.SaveChanges() > 0, BreakMinutes = TimeSpan.Zero, Message = _message });
                return results;
            }
        }

        public List<StudentsDTO.StudentDetail> VerifyStudentFingerprint(DPFP.FeatureSet featureSet, string ReaderSerial)
        {
            List < StudentsDTO.StudentDetail > studentList = new List<StudentsDTO.StudentDetail>();            
            using (_context = new ApplicationDbContext())
            {
                try
                {
                    foreach (var student in _context.Students)
                    {
                        Stream stream = new MemoryStream(student.Fingerprint);
                        DPFP.Template template = new DPFP.Template(stream);
                        DPFP.Verification.Verification verificator = new DPFP.Verification.Verification();
                        DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                        verificator.Verify(featureSet, template, ref result);
                        if (result.Verified)
                        {
                            studentList.Add(new StudentsDTO.StudentDetail
                            {
                                FingerprintID = student.FingerprintID,
                                FirstName = student.FirstName,
                                LastName = student.LastName,
                                MiddleInitial = student.MiddleInitial,
                                section = student.Section,
                                room = student.Room,
                                Gender = student.Gender,
                                StudentNumber = student.StudentNumber,
                                IsIn = CheckSerial(ReaderSerial) ? true : false
                            });
                            break;
                        }
                    }
                    return studentList;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ERROR!!!!!!" + ex.Message);
                    return studentList;
                }
            }
        }

        private bool CheckSerial(string ReaderSerial)
        {
            if(ReaderSerial == "18ecdae0-2be8-1e4b-a8cd-6eab443153de")
            {
                return true;
            }
            else if (ReaderSerial == "3fa23b39-d804-6a4e-918e-73e7f59f4717")
            {
                return false;
            }
            return false;
        }

    }
}
