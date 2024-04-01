using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Interfaces
{
    public interface ISettingsService
    {
        public Task<Handlers.SettingsResult> HoldLogging(bool hold);
        public Task<Handlers.SettingsResult> GetLoggingStatus();
    }
}
