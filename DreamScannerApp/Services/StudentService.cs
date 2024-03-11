﻿using DreamScannerApp.Handlers;
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
                        Fingerprint = student.fingerprintData
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

        public bool DeleteStudent(StudentsDTO.StudentDetails student)
        {
            var studentToDelete = _context.Students.FirstOrDefault(s => s.StudentNumber == student.StudentNumber);
            if (studentToDelete != null)
            {
                _context.Students.Remove(studentToDelete);
                return _context.SaveChanges() > 0;
            }
            return false;
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
                    FirstName = s.FirstName,
                    MiddleInitial = s.MiddleInitial,
                    LastName = s.LastName,
                    Section = s.Section,
                    StudentNumber = s.StudentNumber,
                }).ToList();
        }

        public bool UpdateStudent(StudentsDTO.StudentDetails student)
        {
            var st = _context.Students.FirstOrDefault(s => s.StudentNumber == student.StudentNumber);
            if (st != null)
            {
                st.LastName = student.LastName;
                st.MiddleInitial = student.MiddleInitial;
                st.Section = student.Section;
                st.Room = student.Room;
                st.Gender = student.Gender;

                return _context.SaveChanges() > 0;
            }
            return false;
        }
    }
}
