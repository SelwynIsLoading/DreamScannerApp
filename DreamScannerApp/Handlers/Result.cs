using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class Result
    {
        public string Status { get; set; } = "";
        public string ReaderSerial { get; set; } = "";
        public Bitmap? fingerImage { get; set; } = null;
        public bool IsSaved { get; set; } = false;

    }
}
