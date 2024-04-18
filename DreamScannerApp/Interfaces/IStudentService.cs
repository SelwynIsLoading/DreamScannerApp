using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScannerApp.Handlers;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Entities;
using DreamScannerApp.Services;

namespace DreamScannerApp.Interfaces
{
    public interface IStudentService
    {
        public bool AddStudent(StudentsDTO.CreateStudent student);
        public bool UpdateStudent(StudentsDTO.StudentDetails student);
        public bool DeleteStudent(string StudentNumber);
        //public void LogStudent(StudentsDTO.StudentLog student);
        List<StudentsDTO.StudentDetails> GetStudents();
        List<StudentsDTO.StudentDetails> FilterStudents(string search);
        List<StudentsDTO.StudentDetails> GetStudentsByStudentNumber(string studentNumber);
        public Task<SaveResults> AddAdminAsync(AdminEntity admin);
        //List<StudentsDTO.StudentLog> GetStudentLogs();
    }
}
