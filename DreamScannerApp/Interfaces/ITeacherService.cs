using DreamScannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Interfaces
{
    public interface ITeacherService
    {
        public Task EnrollTeacher(List<TeachersDTO> teacher);
        public Task<List<TeachersDTO>> GetTeachers();
    }
}
