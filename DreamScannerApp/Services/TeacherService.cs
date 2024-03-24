using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Entities;
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
                        Section = t.Section,
                        FingerprintID = Guid.NewGuid()
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
                        Id = t.Id,
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

        public async Task RemoveTeacher(Guid id)
        {
            try
            {
                var teacherToDelete = _context.Teachers.FirstOrDefault(w => w.Id == id);
                if(teacherToDelete != null)
                {
                    _context.Teachers.Remove(teacherToDelete);
                    await _context.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateTeacher(TeachersDTO teacher)
        {
            try
            {
                var toUpdate = await _context.Teachers.FirstOrDefaultAsync(w => w.Id == teacher.Id);

                if (toUpdate != null)
                {
                    // Update the properties of the retrieved teacher
                    toUpdate.FirstName = teacher.FirstName;
                    toUpdate.LastName = teacher.LastName;
                    toUpdate.MiddleInitial = teacher.MiddleInitial;
                    toUpdate.Subject = teacher.Subject;
                    toUpdate.Email = teacher.Email;
                    toUpdate.Room = teacher.Room;
                    toUpdate.Gender = teacher.Gender;
                    toUpdate.Section = teacher.Section;
                    toUpdate.TimeFrom = teacher.TimeFrom;
                    toUpdate.TimeTo = teacher.TimeTo;

                    // Save the changes to the database
                    await _context.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
