using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScannerApp.Models.Entities;

namespace DreamScannerApp.Services
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=school.db");
        }

        public DbSet<StudentsEntity> Students { get; set; }
        public DbSet<TeachersEntity> Teachers { get; set; }
        public DbSet<StudentLogsEntity> StudentLogs { get; set; }
        public DbSet<TeacherLogsEntity> TeacherLogs { get; set; }
    }
}
