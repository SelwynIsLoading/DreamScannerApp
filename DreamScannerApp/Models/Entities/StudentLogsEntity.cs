using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models.Entities
{
    public class StudentLogsEntity 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } 
        public Guid FingerprintID { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string MiddleInitial { get; set; } 
        public string Section { get; set; } 
        public string StudentNumber { get; set; } 
        public string Room { get; set; } 
        public DateTime Date { get; set; }
        public TimeSpan TimeIn { get; set; }
        public TimeSpan TimeOut { get; set; }
        public string AttendanceStatus { get; set; } 
    }
}
