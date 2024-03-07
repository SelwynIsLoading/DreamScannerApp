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

        public string Status { get; set; } = "";
        public string ReaderSerial { get; set; } = "";
        public Bitmap? fingerImage { get; set; } = null;
        public bool IsSaved { get; set; } = false;
        public byte[]? fingerprintTemplate { get; set; }
        public void AddFingerprint(DPFP.Template template)
        {
            fingerprintTemplate = template.Bytes;
            Status = "Fingerprint was captured successfully";
            IsSaved = true;
        }

        public byte[]? GetFingerprint()
        {
            return fingerprintTemplate;
        }

    }
}
