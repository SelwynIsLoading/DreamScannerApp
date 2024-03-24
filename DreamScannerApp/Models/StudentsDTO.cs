using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public class CreateStudent : BaseModel
        {
            [Required(ErrorMessage ="First Name is required.")]
            [StringLength(50, ErrorMessage = "First Name must not exceed 50 characters.")]
            public string FirstName { get; set; } = "";
            [Required(ErrorMessage = "Last Name is required.")]
            [StringLength(50, ErrorMessage = "Last Name must not exceed 50 characters.")]
            public string LastName { get; set; } = "";
            public string MiddleInitial { get; set; } = "";
            [Required(ErrorMessage = "Student Number is required.")]
            [StringLength(7, ErrorMessage = "Student Number must be 7 digits")]
            public string StudentNumber { get; set; } = "";
            [Required(ErrorMessage ="Gender is required.")]
            public StudentProperties.Gender gender { get; set; } = StudentProperties.Gender.None;
            [Required(ErrorMessage = "Section is required.")]
            public StudentProperties.Section section { get; set; } = StudentProperties.Section.None;
            [Required(ErrorMessage = "Room is required.")]
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

        public class StudentLogReport
        {
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public string MiddleInitial { get; set; } = "";
            public string StudentNumber { get; set; } = "";
            public StudentProperties.Section section { get; set; } = StudentProperties.Section.None;
            public StudentProperties.Room room { get; set; } = StudentProperties.Room.Unknown;
            public StudentProperties.Gender gender { get; set; } = StudentProperties.Gender.None;
            public string Date { get; set; } = "";
            public string TimeIn { get; set; } = "";
            public string TimeOut { get; set; } = "";
            public string AttendanceStatus { get; set; } = "";
        }
    }
}
