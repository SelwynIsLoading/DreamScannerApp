using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models
{
    public class Students
    {
        [Key]
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public required string Section { get; set; } 
        public required string StudentNumber { get; set; }   
        public string? Room { get; set; }
        public required string Gender { get; set; }
        public byte[]? Fingerprint { get; set; }
    }
}
