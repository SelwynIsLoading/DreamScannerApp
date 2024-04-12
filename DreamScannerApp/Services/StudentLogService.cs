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
using static DPFP.Verification.Verification;
using Microsoft.EntityFrameworkCore.Update;

namespace DreamScannerApp.Services
{
    public class StudentLogService : IStudentLogService
    {
        private readonly ApplicationDbContext _context;

        public StudentLogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Handlers.StudentLogResult> LogStudent(StudentsDTO.StudentDetail student, string ReaderSerial)
        {
            #region Old Code
            //try
            //{
            //    var studentLogs = await _context.Students.Where(s => s.FingerprintID == student.FingerprintID).AsSplitQuery().AsNoTracking().FirstOrDefaultAsync();
            //    var studentEntered = await _context.StudentLogs.Where(s => s.FingerprintID == student.FingerprintID && s.Date == DateTime.Now.Date).AsSplitQuery().AsNoTracking().FirstOrDefaultAsync();
            //    if (studentLogs != null && studentEntered == null)
            //    {
            //        _context.StudentLogs.Add(new StudentLogsEntity
            //        {
            //            FirstName = student.FirstName,
            //            LastName = student.LastName,
            //            MiddleInitial = student.MiddleInitial,
            //            StudentNumber = student.StudentNumber,
            //            FingerprintID = student.FingerprintID,
            //            Section = student.section,
            //            Room = student.room,
            //            Date = DateTime.Now.Date,
            //            TimeIn = CheckSerial(ReaderSerial) ? DateTime.Now.TimeOfDay : TimeSpan.Zero,
            //            TimeOut = TimeSpan.Zero,
            //            AttendanceStatus = "Present",
            //            AttendanceState = 1
            //        });
            //    }
            //    return new Handlers.StudentLogResult { IsSuccess = await _context.SaveChangesAsync() > 0, Message = "Student Logged In Successfully!" };
            //}
            //catch (Exception ex)
            //{
            //    return new Handlers.StudentLogResult { IsSuccess = false, Message = ex.Message };
            //}
            #endregion
            try
            {
                var studentLogs = await _context.Students
                    .Where(s => s.FingerprintID == student.FingerprintID)
                    .AsSplitQuery()
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                if (studentLogs == null)
                    return new Handlers.StudentLogResult { IsSuccess = false, Message = "Student not found." };

                var studentEntered = await _context.StudentLogs
                    .Where(s => s.FingerprintID == student.FingerprintID && s.Date == DateTime.Now.Date)
                    .AsSplitQuery()
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                if (studentEntered != null)
                    return new Handlers.StudentLogResult { IsSuccess = false, Message = "Student already logged in for today." };

                var newStudentLog = new StudentLogsEntity
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    MiddleInitial = student.MiddleInitial,
                    StudentNumber = student.StudentNumber,
                    FingerprintID = student.FingerprintID,
                    Section = student.section,
                    Room = student.room,
                    Date = DateTime.Now.Date,
                    AttendanceStatus = "Present",
                    AttendanceState = 1,
                    AttendanceLogs = new AttendanceLogEntity { FingerprintId = student.FingerprintID, LogTime = DateTime.Now, Remarks = "Present" }
                };

                if (CheckSerial(ReaderSerial))
                    newStudentLog.TimeIn = DateTime.Now.TimeOfDay;
                else
                    newStudentLog.TimeOut = DateTime.Now.TimeOfDay;

                _context.StudentLogs.Add(newStudentLog);

                return new Handlers.StudentLogResult { IsSuccess = await _context.SaveChangesAsync() > 0, Message = "Student Logged In Successfully!" };
            }
            catch (Exception ex)
            {
                return new Handlers.StudentLogResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<Handlers.StudentLogResult> LogOnBreakStudent(StudentsDTO.StudentDetail student, string ReaderSerial)
        {
            #region Old Code
            //try
            //{
            //    string _message = "";
            //    var studentEntered = await _context.StudentLogs.Where(s => s.FingerprintID == student.FingerprintID && s.Date == DateTime.Now.Date).FirstOrDefaultAsync();
            //    if (studentEntered != null && studentEntered.AttendanceState == 1 && !CheckSerial(ReaderSerial))
            //    {
            //        studentEntered.TimeOut = DateTime.Now.TimeOfDay;
            //        studentEntered.AttendanceStatus = "On Break";
            //        studentEntered.AttendanceState = 2;
            //        _message = "Student Logged Out Successfully!";
            //    }
            //    if (studentEntered != null && studentEntered.AttendanceState == 2 && CheckSerial(ReaderSerial))
            //    {
            //        TimeSpan timeDifference = DateTime.Now.TimeOfDay - studentEntered.TimeOut;
            //        double totalMinutes = timeDifference.TotalMinutes;

            //        if (totalMinutes >= Properties.Settings.Default.breakMinutes.TotalMinutes) // TODO: change to 15 minutes threshold
            //        {
            //            double excessMinutes = totalMinutes - Properties.Settings.Default.breakMinutes.TotalMinutes;
            //            studentEntered.TimeOut = DateTime.Now.TimeOfDay;
            //            studentEntered.AttendanceStatus = $"Over break: {excessMinutes.ToString("N1")}";
            //            studentEntered.AttendanceState = 1;
            //            _message = $"Over break excess: {excessMinutes.ToString("N1")} minutes";
            //        }
            //        else
            //        {
            //            studentEntered.TimeOut = DateTime.Now.TimeOfDay;
            //            studentEntered.AttendanceStatus = "Present";
            //            studentEntered.AttendanceState = 1;
            //            _message = "Student Logged In Successfully!";
            //        }
            //    }
            //    return new Handlers.StudentLogResult { IsSuccess = await _context.SaveChangesAsync() > 0, BreakMinutes = TimeSpan.Zero, Message = _message };
            //}
            //catch (Exception ex)
            //{
            //    return new Handlers.StudentLogResult { IsSuccess = false, Message = ex.Message };
            //}
            #endregion
            try
            {
                var studentEntered = await _context.StudentLogs
                    .Include(i => i.AttendanceLogs)
                    .Where(s => s.FingerprintID == student.FingerprintID && s.Date == DateTime.Now.Date)
                    .FirstOrDefaultAsync();

                if (studentEntered == null)
                    return new Handlers.StudentLogResult { IsSuccess = false, Message = "Student not found." };

                if (studentEntered.AttendanceState != 1)
                    return new Handlers.StudentLogResult { IsSuccess = false, Message = "Student is not logged in." };

                TimeSpan timeDifference = DateTime.Now.TimeOfDay - studentEntered.TimeOut;
                double totalMinutes = timeDifference.TotalMinutes;

                if (totalMinutes < Properties.Settings.Default.breakMinutes.TotalMinutes) // Check if student is back before the break threshold
                {
                    studentEntered.TimeOut = DateTime.Now.TimeOfDay;
                    studentEntered.AttendanceStatus = "Present";
                    studentEntered.AttendanceLogs.FingerprintId = student.FingerprintID; 
                    studentEntered.AttendanceLogs.LogTime = DateTime.Now;
                    studentEntered.AttendanceLogs.Remarks = "Present";
                    return new Handlers.StudentLogResult { IsSuccess = await _context.SaveChangesAsync() > 0, Message = "Student Logged In Successfully!" };
                }

                // Student is back after break threshold
                double excessMinutes = totalMinutes - Properties.Settings.Default.breakMinutes.TotalMinutes;
                string status = $"Over break: {excessMinutes.ToString("N1")}";

                studentEntered.TimeOut = DateTime.Now.TimeOfDay;
                studentEntered.AttendanceStatus = status; // Set status with excess break time
                studentEntered.AttendanceState = 1;
                studentEntered.AttendanceLogs.FingerprintId = student.FingerprintID;
                studentEntered.AttendanceLogs.LogTime = DateTime.Now;
                studentEntered.AttendanceLogs.Remarks = status;

                return new Handlers.StudentLogResult { IsSuccess = await _context.SaveChangesAsync() > 0, Message = $"Over break excess: {excessMinutes.ToString("N1")} minutes" };
            }
            catch (Exception ex)
            {
                return new Handlers.StudentLogResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<List<StudentsDTO.StudentDetail>> VerifyStudentFingerprint(DPFP.FeatureSet featureSet, string ReaderSerial)
        {
            try
            {
                List<StudentsDTO.StudentDetail> studentList = new List<StudentsDTO.StudentDetail>();
                var students = await _context.Students.ToListAsync();
                foreach (var student in students)
                {
                    if (student.Fingerprint != null)
                    {
                        Stream stream = new MemoryStream(student.Fingerprint);
                        DPFP.Template template = new DPFP.Template(stream);
                        DPFP.Verification.Verification verificator = new DPFP.Verification.Verification();
                        DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                        verificator.Verify(featureSet, template, ref result);

                        var inAdminVerification = Properties.Settings.Default.IsHold ? result.Verified : result.Verified && student.isRepresentative;
                        if (inAdminVerification)
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
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<StudentsDTO.StudentLog>> GetStudentLogInfo()
        {
            try
            {
                List<StudentsDTO.StudentLog> studentLogs = new List<StudentsDTO.StudentLog>();
                var logs = await _context.StudentLogs.Include(i => i.AttendanceLogs).ToListAsync();
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

        public async Task<List<StudentsDTO.StudentLog>> FilterStudentLog(StudentLogFilterDTO filter)
        {
            try
            {
                List<StudentsDTO.StudentLog> studentLogs = new List<StudentsDTO.StudentLog>();
                string attendanceStatus = filter.AttendanceStatus.ToLower();
                string searchString = filter.Filter.ToLower();

                DateTime dateFilter = filter.Date != DateTime.MinValue ? filter.Date.Date : DateTime.Now.Date;

                studentLogs = await _context.StudentLogs
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
                    .AsSplitQuery()
                    .AsNoTracking()
                    .ToListAsync();

                return studentLogs;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
