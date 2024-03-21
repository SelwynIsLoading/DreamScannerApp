using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class TeacherService : ITeacherService
    {
        public readonly ApplicationDbContext _context;
        public TeacherService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task EnrollTeacher(List<TeachersDTO> teacher)
        {
            try
            {
                foreach (var t in teacher)
                {
                    _context.Teachers.Add(new Models.Entities.TeachersEntity
                    {
                        FirstName = t.FirstName,
                        LastName = t.LastName,
                        MiddleInitial = t.MiddleInitial,
                        Subject = t.Subject,
                        Email = t.Email,
                        Room = t.Room,
                        Gender = t.Gender,
                        Fingerprint = t.Fingerprint,
                        TimeFrom = t.TimeFrom,
                        TimeTo = t.TimeTo,
                        Section = t.Section
                    });
                }
                return _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TeachersDTO>> GetTeachers()
        {
            try
            {
                List<TeachersDTO> teachers = new List<TeachersDTO>();
                var result = await _context.Teachers.ToListAsync();
                foreach (var t in result)
                {
                    teachers.Add(new TeachersDTO
                    {
                        FirstName = t.FirstName,
                        LastName = t.LastName,
                        MiddleInitial = t.MiddleInitial,
                        Subject = t.Subject,
                        Email = t.Email,
                        Room = t.Room,
                        Gender = t.Gender,
                        TimeFrom = t.TimeFrom,
                        TimeTo = t.TimeTo,
                        Section = t.Section
                    });
                }
                return teachers;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
