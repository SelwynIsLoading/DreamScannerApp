using DreamScannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Interfaces
{
    public interface IExcelService
    {
        public Task<Handlers.TeacherLogResult> StudentExcelReport(List<StudentsDTO.StudentLogReport> students, Stream stream);
        public Task<Handlers.TeacherLogResult> TeacherExcelReport(List<TeacherLogsModel> teachers, Stream stream);
    }
}
