using DreamScannerApp.Models;
using DreamScannerApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class StudentLogService : IStudentLogService
    {
        private ApplicationDbContext _context;
        public StudentLogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void LogStudent(StudentsDTO.StudentLog student)
        {
            Result result = new Result();
            throw new NotImplementedException();
        }

        public List<StudentsDTO.StudentLog> VerifyStudentFingerprint(DPFP.FeatureSet featureSet, string ReaderSerial)
        {
            List < StudentsDTO.StudentLog > studentList = new List<StudentsDTO.StudentLog>();            
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
                            studentList.Add(new StudentsDTO.StudentLog
                            {
                                FirstName = student.FirstName,
                                LastName = student.LastName,
                                MiddleInitial = student.MiddleInitial,
                                StudentNumber = student.StudentNumber,
                                FingerprintID = student.FingerprintID,
                                section = student.Section,
                                room = student.Room,
                                gender = student.Gender,
                                TimeIn = ReaderSerial == "18ecdae0-2be8-1e4b-a8cd-6eab443153de" ? DateTime.Now.TimeOfDay : TimeSpan.Zero,
                                TimeOut = ReaderSerial == "3fa23b39-d804-6a4e-918e-73e7f59f4717" ? DateTime.Now.TimeOfDay : TimeSpan.Zero,
                                IsIn = ReaderSerial == "18ecdae0-2be8-1e4b-a8cd-6eab443153de" ? true : false
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

    }
}
