using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScannerApp.Models.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace DreamScannerApp.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<StudentsEntity> Students { get; set; }
        public DbSet<TeachersEntity> Teachers { get; set; }
        public DbSet<StudentLogsEntity> StudentLogs { get; set; }
        public DbSet<TeacherLogsEntity> TeacherLogs { get; set; }
        public DbSet<SettingsEntity> Settings { get; set; }
    }
}
