using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models.Entities
{
    public class SettingsEntity : AuditableEntity
    {
        public bool IsLoggingEnabled { get; set; }
        public string ArduinoPort { get; set; }
        public string ArduinoBaudRate { get; set; }
        public TimeSpan BreakTime { get; set; }
        public TimeSpan LunchTime { get; set; }

    }
}
