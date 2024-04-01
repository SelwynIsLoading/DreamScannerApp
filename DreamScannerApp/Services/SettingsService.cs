using DreamScannerApp.Handlers;
using DreamScannerApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly ApplicationDbContext _context;
        public SettingsService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<Handlers.SettingsResult> GetLoggingStatus()
        {
            try
            {
                var settings = await _context.Settings.FirstOrDefaultAsync();
                if(settings != null)
                {
                    return new SettingsResult { IsSaved = settings.IsLoggingEnabled, Message = "Logging is " + (settings.IsLoggingEnabled ? "enabled" : "disabled") };
                }
                return new SettingsResult { IsSaved = false, Message = "Possibly Null" };
            }
            catch(Exception ex)
            {
                return new SettingsResult { IsSaved = false, Message = ex.Message };
            }
        }

        public async Task<Handlers.SettingsResult> HoldLogging(bool hold)
        {
            try
            {
                var settings = await _context.Settings.ToListAsync();
                settings.ForEach(s => s.IsLoggingEnabled = hold);
                return new SettingsResult { IsSaved = true, Message = "Logging is now " + (hold ? "enabled" : "disabled") };
            }
            catch(Exception ex)
            {
                return new SettingsResult { IsSaved = false, Message = ex.Message };
            }
        }
    }
}
