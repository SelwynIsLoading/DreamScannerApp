using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models.Entities
{
    public class StudentClassAdmin
    {
        public Guid StudentClassAdminId { get; set; }
        public StudentsEntity Student { get; set; }
        public Guid ClassAdminId { get; set; }
        public ClassAdminsEntity ClassAdmin { get; set; }
    }
}
