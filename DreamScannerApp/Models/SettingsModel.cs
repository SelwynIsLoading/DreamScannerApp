using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models
{
    public class SettingsModel
    {
        public bool IsLoggingEnabled { get; set; } = false;
        public string ArduinoPort { get; set; } = "";
        public string ArduinoBaudRate { get; set; } = "";
    }
}
