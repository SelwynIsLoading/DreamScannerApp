using DreamScannerApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Interfaces
{
    public interface ITeacherLogService
    {
        public Task<List<TeacherLogsEntity>> GetTeacherLogs();
    }
}
