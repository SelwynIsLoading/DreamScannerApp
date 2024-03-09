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
    }
}
