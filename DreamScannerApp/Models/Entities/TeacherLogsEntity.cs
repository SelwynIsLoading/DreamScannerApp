using DreamScannerApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models.Entities
{
    public class TeacherLogsEntity : AuditableEntity
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleInitial { get; set; } = "";
        public string Subject { get; set; } = "";
        public TeacherProperties.room Room { get; set; }
        public TeacherProperties.Section Section { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public string AttendanceStatus { get; set; } = "";
    }
}
