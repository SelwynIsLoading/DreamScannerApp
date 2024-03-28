using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class AppSettingsService : IAppSettingsService
    {
        public readonly ApplicationDbContext _context;
        public AppSettingsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SettingsModel>> GetSettings()
        {
            try
            {
                var settings = await _context.Settings
                    .Select(s => new SettingsModel
                    {
                        IsLoggingEnabled = s.IsLoggingEnabled,
                        ArduinoPort = s.ArduinoPort,
                        ArduinoBaudRate = s.ArduinoBaudRate
                    })
                    .ToListAsync();

                return settings;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to get settings.", ex);
            }
        }

        public Task SetSettings(SettingsModel settings)
        {
            throw new NotImplementedException();
        }
    }
}
