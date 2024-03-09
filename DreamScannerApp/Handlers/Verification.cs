using DreamScannerApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class Verification : FingerprintHandler
    {
        private readonly IStudentService _studentService;
        public Verification(Action<string> reportCallback, Action<Bitmap> imageCallback, IStudentService studentService) : base(reportCallback, imageCallback)
        {
            _studentService = studentService;
        }
    }
}
