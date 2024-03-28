using DreamScannerApp.Handlers;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using DreamScannerApp.UserControls.StudentsUserControls;
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

        public async Task<TeacherLogResult> TeacherExcelReport(List<TeacherLogsModel> teachers, Stream stream)
        {
            await Task.Run(() =>
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage excel = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("Attendance Log");
                    AddTeacherHeaders(worksheet);
                    for (int i = 0; i < teachers.Count; i++)
                    {
                        AddTeacherData(worksheet, teachers[i], i + 2);
                    }
                    excel.SaveAs(stream);
                }
            });
            throw new NotImplementedException();
        }

        private void AddHeaders(ExcelWorksheet worksheet)
        {
            string[] headers = { "Name", "Student Number", "Section", "Room", "Date", "Time In", "Time Out", "Attendance Status" };

            for (int i = 0; i < headers.Length; i++)
            {
                var cell = worksheet.Cells[1, i + 1];
                cell.Value = headers[i];
                cell.Style.Font.Bold = true;
            }
        }

        private void AddTeacherHeaders(ExcelWorksheet worksheet)
        {
            string[] headers = { "Name", "Section", "Room", "Date", "Time In", "Time Out", "Attendance Status" };

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

        private void AddTeacherData(ExcelWorksheet worksheet, TeacherLogsModel teacher, int rowIndex)
        {
            worksheet.Cells[rowIndex, 1].Value = $"{teacher.LastName}, {teacher.FirstName} {teacher.MiddleInitial}";
            worksheet.Cells[rowIndex, 2].Value = teacher.Section;
            worksheet.Cells[rowIndex, 3].Value = teacher.Room;
            worksheet.Cells[rowIndex, 4].Value = teacher.Date;
            worksheet.Cells[rowIndex, 5].Value = teacher.TimeIn;
            worksheet.Cells[rowIndex, 6].Value = teacher.TimeOut;
            worksheet.Cells[rowIndex, 7].Value = teacher.AttendanceStatus;
        }

    }
}
