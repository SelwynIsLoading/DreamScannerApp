using DreamScannerApp.Handlers;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Entities;
using DreamScannerApp.UserControls.StudentsUserControls;
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
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddStudent(StudentsDTO.CreateStudent student)
        {
            try
            {
                if (student != null)
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
                        Fingerprint = student.fingerprintData,
                        isRepresentative = student.isRepresentative
                    });
                    return _context.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!!!!!!" + ex.Message);
                return false;
            }
        }

        public bool DeleteStudent(string StudentNumber)
        {
            var studentToDelete = _context.Students.FirstOrDefault(s => s.StudentNumber == StudentNumber);
            if (studentToDelete != null)
            {
                _context.Students.Remove(studentToDelete);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public List<StudentsDTO.StudentDetails> FilterStudents(string search)
        {
            var searchString = search.ToLower(); // Convert search string to lowercase for case-insensitive comparison

            return _context.Students
                .Where(s =>
                    s.FirstName.ToLower().Contains(searchString) ||
                    s.LastName.ToLower().Contains(searchString) ||
                    s.StudentNumber.ToLower().Contains(searchString)
                )
                .Select(s => new StudentsDTO.StudentDetails
                {
                    FirstName = s.FirstName,
                    MiddleInitial = s.MiddleInitial,
                    LastName = s.LastName,
                    Section = s.Section,
                    StudentNumber = s.StudentNumber,
                    Room = s.Room,
                    Gender = s.Gender
                })
                .ToList();
        }



        public List<StudentsDTO.StudentDetails> GetStudents()
        {
            return _context.Students.Select(s => new StudentsDTO.StudentDetails
            {
                FirstName = s.FirstName,
                MiddleInitial = s.MiddleInitial,
                LastName = s.LastName,
                Section = s.Section,
                StudentNumber = s.StudentNumber,
                Gender = s.Gender,
                Room = s.Room,
            }).ToList();
        }

        public List<StudentsDTO.StudentDetails> GetStudentsByStudentNumber(string studentNumber)
        {
            return _context.Students
                .Where(s => s.StudentNumber == studentNumber)
                .Select(s => new StudentsDTO.StudentDetails
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    MiddleInitial = s.MiddleInitial,
                    LastName = s.LastName,
                    Section = s.Section,
                    StudentNumber = s.StudentNumber,
                    Room = s.Room,
                    Gender = s.Gender,
                    isRepresentative = s.isRepresentative
                }).ToList();
        }

        public bool UpdateStudent(StudentsDTO.StudentDetails student)
        {
            var st = _context.Students.FirstOrDefault(s => s.Id == student.Id);
            if (st != null)
            {
                st.FirstName = student.FirstName;
                st.LastName = student.LastName;
                st.MiddleInitial = student.MiddleInitial;
                st.StudentNumber = student.StudentNumber;
                st.Section = student.Section;
                st.Room = student.Room;
                st.Gender = student.Gender;
                st.isRepresentative = student.isRepresentative;

                return _context.SaveChanges() > 0;
            }
            return false;
        }
    }
}
