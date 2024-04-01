using DPFP;
using DreamScannerApp.Handlers;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class TeacherLogService : ITeacherLogService
    {
        public readonly ApplicationDbContext _context;
        public TeacherLogService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<TeacherLogsEntity>> GetTeacherLogs()
        {
            try
            {
                List<TeacherLogsEntity> teachers = new List<TeacherLogsEntity>();
                var teacher = await _context.TeacherLogs.ToListAsync();
                return teacher;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        

        public async Task<TeacherLogResult> LogTeacher(TeachersDTO teacher, string ReaderSerial)
        {
            try
            {
                var teacherLogs = await _context.Teachers.Where(w => w.FingerprintID == teacher.FingerprintId).AsNoTracking().FirstOrDefaultAsync();
                var teacherEntered = await _context.TeacherLogs.Where(w => w.FingerprintID == teacher.FingerprintId && w.Date == DateTime.Now.Date).AsNoTracking().FirstOrDefaultAsync();
                if (teacherLogs != null && teacherEntered == null)
                {
                    _context.TeacherLogs.Add(new TeacherLogsEntity
                    {
                        FingerprintID = teacher.FingerprintId,
                        FirstName = teacher.FirstName,
                        LastName = teacher.LastName,
                        MiddleInitial = teacher.MiddleInitial,
                        Subject = teacher.Subject,
                        Email = teacher.Email,
                        Room = teacher.Room,
                        Section = teacher.Section,
                        Date = DateTime.Now.Date,
                        TimeIn = CheckSerial(ReaderSerial) ? DateTime.Now.TimeOfDay : TimeSpan.Zero,
                        TimeOut = TimeSpan.Zero,
                        AttendanceStatus = "Present",
                        AttendanceState = 1
                    });
                }
                return new TeacherLogResult { IsSuccess = await _context.SaveChangesAsync() > 0, Message = "Teacher Logged In Successfully!" };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<TeachersDTO?> VerifyTeacherFingerprint(FeatureSet featureSet, string ReaderSerial)
        {
            try
            {
                var teacher = await _context.Teachers.ToListAsync();
                foreach (var t in teacher)
                {
                    if (t.Fingerprint != null)
                    {
                        DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                        DPFP.Verification.Verification verify = new DPFP.Verification.Verification();
                        DPFP.Template template = new DPFP.Template();
                        MemoryStream ms = new MemoryStream(t.Fingerprint);
                        template.DeSerialize(ms);
                        verify.Verify(featureSet, template, ref result);
                        if (result.Verified)
                        {
                            return new TeachersDTO
                            {
                                Id = t.Id,
                                FirstName = t.FirstName,
                                LastName = t.LastName,
                                MiddleInitial = t.MiddleInitial,
                                Subject = t.Subject,
                                Section = t.Section,
                                Email = t.Email,
                                Room = t.Room,
                                Gender = t.Gender,
                                IsIn = CheckSerial(ReaderSerial),
                                FingerprintId = t.FingerprintID
                            };
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<TeacherLogResult> LogOnBreakTeacher(TeachersDTO teacher, string ReaderSerial)
        {
            try
            {
                var currentDate = DateTime.Today;
                string _message = "";
                var teacherEntered = await _context.TeacherLogs
                    .Where(w => w.FingerprintID == teacher.FingerprintId && w.Date == currentDate).ToListAsync();

                if (teacherEntered != null)
                {
                    teacherEntered.ForEach(t =>
                    {
                        if (t.AttendanceState == 1 && !CheckSerial(ReaderSerial))
                        {
                            // Teacher is logging out
                            t.TimeOut = DateTime.Now.TimeOfDay;
                            t.AttendanceStatus = "On Break";
                            t.AttendanceState = 3;
                            _message = "Teacher Logged Out Successfully!";
                        }
                        else if (t.AttendanceState == 3 && CheckSerial(ReaderSerial))
                        {
                            // Teacher is logging back in
                            _context.TeacherLogs.Add(new TeacherLogsEntity
                            {
                                FingerprintID = teacher.FingerprintId,
                                FirstName = teacher.FirstName,
                                LastName = teacher.LastName,
                                MiddleInitial = teacher.MiddleInitial,
                                Subject = teacher.Subject,
                                Room = teacher.Room,
                                Section = teacher.Section,
                                Date = currentDate,
                                TimeIn = DateTime.Now.TimeOfDay,
                                TimeOut = TimeSpan.Zero,
                                AttendanceStatus = "Present",
                                AttendanceState = 1
                            });
                            _message = "Teacher Logged In Successfully!";
                        }
                    });
                }

                return new TeacherLogResult { IsSuccess = await _context.SaveChangesAsync() > 0, Message = _message };
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to log teacher activity.", ex);
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

        public async Task<List<StudentsDTO.StudentLogReport>> GetPresentStudents()
        {
            try
            {
                var presentStudents = await _context.StudentLogs.Where(w => w.Date == DateTime.Now.Date).ToListAsync();
                List<StudentsDTO.StudentLogReport> students = new List<StudentsDTO.StudentLogReport>();
                presentStudents.ForEach(p =>
                {
                    students.Add(new StudentsDTO.StudentLogReport
                    {
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        MiddleInitial = p.MiddleInitial,
                        StudentNumber = p.StudentNumber,
                        section = p.Section,
                        room = p.Room,
                        Date = p.Date.ToShortDateString(),
                        TimeIn = p.TimeIn == TimeSpan.Zero ? "" : new DateTime(p.TimeIn.Ticks).ToShortTimeString(),
                        TimeOut = p.TimeOut == TimeSpan.Zero ? "" : new DateTime(p.TimeOut.Ticks).ToShortTimeString(),
                        AttendanceStatus = p.AttendanceStatus
                    });
                });
                return students.OrderBy(ob => ob.LastName).ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TeacherLogsModel>> GetTeacherLogsById(Guid id)
        {
            try
            {
                var logs = await _context.TeacherLogs
                    .Where(t => t.FingerprintID == id && t.Date == DateTime.Today)
                    .Select(t => new TeacherLogsModel
                    {
                        FirstName = t.FirstName,
                        LastName = t.LastName,
                        MiddleInitial = t.MiddleInitial,
                        Subject = t.Subject,
                        Room = t.Room,
                        Section = t.Section,
                        Date = t.Date,
                        TimeIn = t.TimeIn,
                        TimeOut = t.TimeOut,
                        AttendanceStatus = t.AttendanceStatus
                    })
                    .ToListAsync();

                return logs;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get teacher logs.", ex);
            }
        }

    }
}
