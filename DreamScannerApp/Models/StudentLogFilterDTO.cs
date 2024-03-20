using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models
{
    public class StudentLogFilterDTO : EventArgs
    {
        public string AttendanceStatus { get; set; } = "PRESENT";
        public DateTime Date { get; set; } = DateTime.Now;
        public string Filter { get; set; } = "";

    }
}
