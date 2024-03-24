using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Handlers
{
    public class StudentLogResult
    {
        public bool IsSuccess { get; set; } = false;
        public TimeSpan BreakMinutes { get; set; }
        public string Message { get; set; } = "";
    }    
}
