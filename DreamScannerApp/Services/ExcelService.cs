using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class ExcelService : IExcelService
    {
        public async Task<Handlers.TeacherLogResult> StudentExcelReport(List<StudentsDTO.StudentLogReport> students, Stream stream)
        {
            await Task.Run(() =>
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage excel = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("Attendance Log");
                    AddHeaders(worksheet);
                    for (int i = 0; i < students.Count; i++)
                    {
                        AddStudentData(worksheet, students[i], i + 2);
                    }
                    excel.SaveAs(stream);                    
                }
            });
            return new Handlers.TeacherLogResult
            {
                IsSuccess = true,
                Message = "Exported to Excel",
            };
        }

        private void AddHeaders(ExcelWorksheet worksheet)
        {
            string[] headers = { "Student Name", "Student Number", "Section", "Room", "Date", "Time In", "Time Out", "Attendance Status" };

            for (int i = 0; i < headers.Length; i++)
            {
                var cell = worksheet.Cells[1, i + 1];
                cell.Value = headers[i];
                cell.Style.Font.Bold = true;
            }
        }

        private void AddStudentData(ExcelWorksheet worksheet, StudentsDTO.StudentLogReport student, int rowIndex)
        {
            worksheet.Cells[rowIndex, 1].Value = $"{student.LastName}, {student.FirstName} {student.MiddleInitial}";
            worksheet.Cells[rowIndex, 2].Value = student.StudentNumber;
            worksheet.Cells[rowIndex, 3].Value = student.section;
            worksheet.Cells[rowIndex, 4].Value = student.room;
            worksheet.Cells[rowIndex, 5].Value = student.Date;
            worksheet.Cells[rowIndex, 6].Value = student.TimeIn;
            worksheet.Cells[rowIndex, 7].Value = student.TimeOut;
            worksheet.Cells[rowIndex, 8].Value = student.AttendanceStatus;
        }

    }
}
