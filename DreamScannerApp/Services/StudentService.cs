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
                            Fingerprint = student.fingerprintData,
                            DateCreated = DateTime.Now,
                            EncodedBy = "Admin",
                    
                        });
                        return _context.SaveChanges() > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
