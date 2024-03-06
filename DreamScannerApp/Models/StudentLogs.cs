using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models
{
    public class StudentLogs : AuditableEntity
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleInitial { get; set; } = "";
        public string Section { get; set; } = "";
        public string StudentNumber { get; set; } = "";
        public string Room { get; set; } = "";  
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public string AttendanceStatus { get; set; } = "";
    }
}
