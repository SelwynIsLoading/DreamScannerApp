using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScannerApp.Models.Enums;
using DreamScannerApp.Services;

namespace DreamScannerApp.Models
{
    public class StudentsDTO
    {
        public class CreateStudent
        {
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public string MiddleInitial { get; set; } = "";
            public string StudentNumber { get; set; } = "";
            public StudentProperties.Gender gender { get; set; } 
            public StudentProperties.Section section { get; set; } = StudentProperties.Section.None;
            public StudentProperties.Room room { get; set; } = StudentProperties.Room.Unknown;
            public byte[]? fingerprintData { get; set; }
            public Result? result { get; set; }
        }
        public class StudentDetail
        {
            public Guid Id { get; set; } = Guid.Empty;
            public Guid FingerprintID { get; set; } = Guid.Empty;
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public string MiddleInitial { get; set; } = "";
            public string StudentNumber { get; set; } = "";
            public StudentProperties.Section section { get; set; } = StudentProperties.Section.None;
            public StudentProperties.Room room { get; set; } = StudentProperties.Room.Unknown;
        }

        public class StudentLog
        {
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public string MiddleInitial { get; set; } = "";
            public string StudentNumber { get; set; } = "";
            public Guid FingerprintID { get; set; } = Guid.Empty;
            public StudentProperties.Section section { get; set; } = StudentProperties.Section.None;
            public StudentProperties.Room room { get; set; } = StudentProperties.Room.Unknown;
            public DateTime TimeIn { get; set; }
            public DateTime TimeOut { get; set; }
        }
    }
}
