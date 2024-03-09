using DPFP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class Result
    {
        public string? ReaderSerial { get; set; } = "";
        public bool IsSaved { get; set; } = false;
        public byte[]? fingerprintTemplate { get; set; } = null;
        public Result()
        {
            IsSaved = false;
            ReaderSerial = "";
            fingerprintTemplate = null;
        }
    }
}
