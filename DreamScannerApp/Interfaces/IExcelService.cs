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
        public Task<Handlers.TeacherLogResult> ExcportToExcel(List<StudentsDTO.StudentLogReport> students, Stream stream);
    }
}
