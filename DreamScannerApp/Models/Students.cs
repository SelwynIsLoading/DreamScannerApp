﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models
{
    public class Students : AuditableEntity
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleInitial { get; set; } = "";
        public string Section { get; set; } = "";
        public string StudentNumber { get; set; } = "";   
        public string Room { get; set; } = "";
        public string Gender { get; set; } = "";
        public byte[]? Fingerprint { get; set; }
    }
}
