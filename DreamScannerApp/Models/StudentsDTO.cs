using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScannerApp.Models.Entities;
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
            public StudentProperties.Gender gender { get; set; } = StudentProperties.Gender.None;
            public StudentProperties.Section section { get; set; } = StudentProperties.Section.None;
            public StudentProperties.Room room { get; set; } = StudentProperties.Room.Unknown;
            public byte[]? fingerprintData { get; set; }
        }
        public class StudentDetail
        {
            public Guid FingerprintID { get; set; } = Guid.Empty;
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public string MiddleInitial { get; set; } = "";
            public string StudentNumber { get; set; } = "";
            public StudentProperties.Section section { get; set; } = StudentProperties.Section.None;
            public StudentProperties.Room room { get; set; } = StudentProperties.Room.Unknown;
            public StudentProperties.Gender Gender { get; set; } = StudentProperties.Gender.None;
            public bool IsIn { get; set; } = false;
        }

        public class StudentDetails
        {
            public Guid Id { get; set; } = Guid.Empty;
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public string MiddleInitial { get; set; } = "";
            public string StudentNumber { get; set; } = "";
            public StudentProperties.Section Section { get; set; }
            public StudentProperties.Room Room { get; set; } 
            public StudentProperties.Gender Gender { get; set; } 
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
            public StudentProperties.Gender gender { get; set; } = StudentProperties.Gender.None;
            public DateTime Date { get; set; }
            public TimeSpan TimeIn { get; set; }
            public TimeSpan TimeOut { get; set; }
            public string AttendanceStatus { get; set; } = "";
        }
    }
}
