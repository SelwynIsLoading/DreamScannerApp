using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Entities;
using DreamScannerApp.Services;

namespace DreamScannerApp.Interfaces
{
    public interface IStudentService
    {
        public bool AddStudent(StudentsDTO.CreateStudent student);
        //public bool UpdateStudent(StudentsDTO.CreateStudent student);
        public bool DeleteStudent(StudentsDTO.StudentDetails student);
        //public void LogStudent(StudentsDTO.StudentLog student);
        List<StudentsDTO.StudentDetails> GetStudents();
        //List<StudentsDTO.StudentLog> GetStudentLogs();
    }
}
