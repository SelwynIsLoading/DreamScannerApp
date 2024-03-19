using DreamScannerApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models
{
    public class StudentCreateDTO:BaseModel
    {
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name must not exceed 50 characters.")]
        public string FirstName { get; set; } = "";
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name must not exceed 50 characters.")]
        public string LastName { get; set; } = "";
        public string MiddleInitial { get; set; } = "";
        [Required(ErrorMessage = "Student Number is required.")]
        [StringLength(7, ErrorMessage = "Student Number must be 7 digits")]
        public string StudentNumber { get; set; } = "";
        [Required(ErrorMessage = "Gender is required.")]
        public StudentProperties.Gender gender { get; set; } = StudentProperties.Gender.None;
        [Required(ErrorMessage = "Section is required.")]
        public StudentProperties.Section section { get; set; } = StudentProperties.Section.None;
        [Required(ErrorMessage = "Room is required.")]
        public StudentProperties.Room room { get; set; } = StudentProperties.Room.Unknown;
        public byte[]? fingerprintData { get; set; }
    }
}
