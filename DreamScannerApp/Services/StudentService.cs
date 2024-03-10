using DreamScannerApp.Handlers;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class StudentService : IStudentService
    {
        private ApplicationDbContext _context;
        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddStudent(StudentsDTO.CreateStudent student)
        {
            try
            {
                using(_context = new ApplicationDbContext())
                {
                    if(student != null)
                    {
                        _context.Students.Add(new StudentsEntity
                        {
                            FirstName = student.FirstName,
                            LastName = student.LastName,
                            MiddleInitial = student.MiddleInitial,
                            Section = student.section,
                            StudentNumber = student.StudentNumber,
                            Room = student.room,
                            Gender = student.gender,
                            DateCreated = DateTime.Now,
                            EncodedBy = "Admin",
                            FingerprintID = Guid.NewGuid(),
                            Fingerprint = student.fingerprintData
                        });
                        return _context.SaveChanges() > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!!!!!!" + ex.Message);
                return false;
            }
        }

        public bool DeleteStudent(StudentsDTO.StudentDetails student)
        {
            using(_context = new ApplicationDbContext())
            {
                var studentToDelete = _context.Students.FirstOrDefault(s => s.StudentNumber == student.StudentNumber);
                if(studentToDelete != null)
                {
                    _context.Students.Remove(studentToDelete);
                    return _context.SaveChanges() > 0;
                }
                return false;
            }
        }

        public List<StudentsDTO.StudentDetails> GetStudents()
        {
            List<StudentsDTO.StudentDetails> model = new List<StudentsDTO.StudentDetails>();
            using(_context = new ApplicationDbContext())
            {
                model.AddRange(_context.Students.Select(s => new StudentsDTO.StudentDetails
                {
                    FirstName = s.FirstName,
                    MiddleInitial = s.MiddleInitial,
                    LastName = s.LastName,
                    Section = s.Section,
                    StudentNumber = s.StudentNumber,
                    Gender = s.Gender,
                    Room = s.Room,
                }).ToList());
                return model;
            }
        }
    }
}
