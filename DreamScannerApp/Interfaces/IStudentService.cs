using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Entities;

namespace DreamScannerApp.Interfaces
{
    public interface IStudentService
    {
        public bool AddStudent(StudentsDTO.CreateStudent student);
        //public bool UpdateStudent(StudentsDTO.CreateStudent student);
        //public bool DeleteStudent(Guid id);
        //public void LogStudent(StudentsDTO.StudentLog student);
        //List<StudentsDTO.StudentDetail> GetStudents();
        //List<StudentsDTO.StudentLog> GetStudentLogs();
    }
}
