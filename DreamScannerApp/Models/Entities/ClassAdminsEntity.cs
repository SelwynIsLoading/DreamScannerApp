using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models.Entities
{
    public class ClassAdminsEntity : AuditableEntity
    {
        public ICollection<StudentClassAdmin> StudentClassAdmins { get; set;}
    }
}
