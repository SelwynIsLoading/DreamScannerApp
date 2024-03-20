using DreamScannerApp.Models;
using DreamScannerApp.Models.Entities;
using DreamScannerApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace DreamScannerApp.Services
{
    public class StudentLogService : IStudentLogService
    {
        private readonly ApplicationDbContext _context;

        public StudentLogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Handlers.StudentLogResult> LogStudent(StudentsDTO.StudentDetail student, string ReaderSerial)
        {
            List<Handlers.StudentLogResult> results = new List<Handlers.StudentLogResult>();
            var studentLogs = _context.Students.Where(s => s.FingerprintID == student.FingerprintID).AsSplitQuery().AsNoTracking().FirstOrDefault();
            var studentEntered = _context.StudentLogs.Where(s => s.FingerprintID == student.FingerprintID && s.Date == DateTime.Now.Date).AsSplitQuery().AsNoTracking().FirstOrDefault();
            if (studentLogs != null && studentEntered == null)
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

        public List<Handlers.StudentLogResult> LogOnBreakStudent(StudentsDTO.StudentDetail student, string ReaderSerial)
        {
            string _message = "";
            List<Handlers.StudentLogResult> results = new List<Handlers.StudentLogResult>();
            var studentEntered = _context.StudentLogs.Where(s => s.FingerprintID == student.FingerprintID && s.Date == DateTime.Now.Date).FirstOrDefault();
            if (studentEntered != null && studentEntered.AttendanceState == 1 && !CheckSerial(ReaderSerial))
            {
                studentEntered.TimeOut = DateTime.Now.TimeOfDay;
                studentEntered.AttendanceStatus = "On Break";
                studentEntered.AttendanceState = 2;
                _message = "Student Logged Out Successfully!";
            }
            if (studentEntered != null && studentEntered.AttendanceState == 2 && CheckSerial(ReaderSerial))
            {
                TimeSpan timeDifference = DateTime.Now.TimeOfDay - studentEntered.TimeOut;
                double totalMinutes = timeDifference.TotalMinutes;

                if (totalMinutes >= 1) // TODO: change to 15 minutes threshold
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

        public List<StudentsDTO.StudentDetail> VerifyStudentFingerprint(DPFP.FeatureSet featureSet, string ReaderSerial)
        {
            List<StudentsDTO.StudentDetail> studentList = new List<StudentsDTO.StudentDetail>();
            try
            {
                foreach (var student in _context.Students)
                {
                    if (student.Fingerprint != null)
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
                                IsIn = CheckSerial(ReaderSerial)
                            });
                            break;
                        }
                    }

                }
                return studentList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!!!!!!" + ex.Message);
                return studentList;
            }
        }

        public List<StudentsDTO.StudentLog> GetStudentLogInfo()
        {
            List<StudentsDTO.StudentLog> studentLogs = new List<StudentsDTO.StudentLog>();
            var logs = _context.StudentLogs;
            foreach (var log in logs)
            {
                studentLogs.Add(new StudentsDTO.StudentLog
                {
                    FirstName = log.FirstName,
                    LastName = log.LastName,
                    MiddleInitial = log.MiddleInitial,
                    StudentNumber = log.StudentNumber,
                    section = log.Section,
                    room = log.Room,
                    Date = log.Date,
                    TimeIn = log.TimeIn,
                    TimeOut = log.TimeOut,
                    AttendanceStatus = log.AttendanceStatus
                });
            }
            return studentLogs;
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

        public List<StudentsDTO.StudentLog> FilterStudentLog(StudentLogFilterDTO filter)
        {
            string attendanceStatus = filter.AttendanceStatus.ToLower();
            string searchString = filter.Filter.ToLower();

            DateTime dateFilter = filter.Date != DateTime.MinValue ? filter.Date.Date : DateTime.Now.Date;

            List<StudentsDTO.StudentLog> studentLogs = _context.StudentLogs
                .Where(s => s.Date == dateFilter &&
                            (string.IsNullOrEmpty(attendanceStatus) || s.AttendanceStatus.ToLower().Contains(attendanceStatus)) &&
                            (string.IsNullOrEmpty(searchString) ||
                             s.FirstName.ToLower().Contains(searchString) ||
                             s.LastName.ToLower().Contains(searchString) ||
                             s.StudentNumber.ToLower().Contains(searchString)))
                .Select(s => new StudentsDTO.StudentLog
                {
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    MiddleInitial = s.MiddleInitial,
                    StudentNumber = s.StudentNumber,
                    section = s.Section,
                    room = s.Room,
                    Date = s.Date,
                    TimeIn = s.TimeIn,
                    TimeOut = s.TimeOut,
                    AttendanceStatus = s.AttendanceStatus
                })
                .ToList();

            return studentLogs;
        }

    }
}
