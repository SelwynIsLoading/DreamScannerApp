using DreamScannerApp.Interfaces;
using DreamScannerApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
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
                foreach (var t in teacher)
                {
                    teachers.Add(new TeacherLogsEntity
                    {
                        FirstName = t.FirstName,
                        LastName = t.LastName,
                        MiddleInitial = t.MiddleInitial,
                        Subject = t.Subject,
                        TimeIn = t.TimeIn,
                        TimeOut = t.TimeOut,
                        Section = t.Section,
                        Room = t.Room
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
