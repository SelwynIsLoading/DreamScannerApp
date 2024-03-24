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
        public Guid Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleInitial { get; set; } = "";
        public string Subject { get; set; } = "";
        public string Email { get; set; } = "";
        public TeacherProperties.room Room { get; set; }
        public TeacherProperties.Gender Gender { get; set; }
        public TeacherProperties.Section Section { get; set; }
        public byte[]? Fingerprint { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
    }
}
