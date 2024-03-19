using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models
{
    public class StudentLogFilterDTO
    {
        public string AttendanceStatus { get; } = "PRESENT";
        public DateTime Date { get; } = DateTime.Now;
        public string Filter { get; } = "";

        public StudentLogFilterDTO(string status, DateTime date, string filter)
        {
            AttendanceStatus = status;
            Date = date;
            Filter = filter;
        }
    }
}
