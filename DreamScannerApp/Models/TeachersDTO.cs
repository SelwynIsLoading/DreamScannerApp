using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScannerApp.Models.Enums;

namespace DreamScannerApp.Models
{
    public class TeachersDTO
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleInitial { get; set; } = "";
        public string Subject { get; set; } = "";
        public TeacherProperties.room room { get; set; }
        public byte[]? Fingerprint { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
    }
}
