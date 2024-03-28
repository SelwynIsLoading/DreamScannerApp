using DreamScannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Interfaces
{
    public interface IAppSettingsService
    {
        public Task<List<SettingsModel>> GetSettings();
        public Task SetSettings(SettingsModel settings);
    }
}
