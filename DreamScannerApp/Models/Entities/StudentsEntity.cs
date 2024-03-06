using DreamScannerApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models.Entities
{
    public class StudentsEntity : AuditableEntity
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleInitial { get; set; } = "";
        public StudentProperties.Section Section { get; set;}
        public string StudentNumber { get; set; } = "";
        public StudentProperties.Room Room { get; set; }
        public StudentProperties.Gender Gender { get; set; }
        public byte[]? Fingerprint { get; set; }
    }
}
