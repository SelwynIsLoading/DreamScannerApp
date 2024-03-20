using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models
{
    public class EmailDTO
    {
        public string SenderEmail { get; set; }
        public string SenderPassword { get; set; }
        public string RecipientEmail { get; set; }
        public string Subject { get; set; }
        public byte[] AttachmentData { get; set; }
        public string AttachmentFileName { get; set; }
        public string FilePath { get; set; }
    }
}
