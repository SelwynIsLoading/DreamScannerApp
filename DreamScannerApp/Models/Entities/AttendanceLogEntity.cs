using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models.Entities
{
    public class AttendanceLogEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AttendanceLogId { get; set; }
        public Guid FingerprintId { get; set; }
        public DateTime LogTime { get; set; }
        public string Remarks { get; set; }
    }
}
