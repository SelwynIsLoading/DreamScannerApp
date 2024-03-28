using DPFP;
using DreamScannerApp.Models;
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
        public Task<TeachersDTO> VerifyTeacherFingerprint(FeatureSet featureSet, string ReaderSerial);
        public Task<Handlers.TeacherLogResult> LogTeacher(TeachersDTO student, string ReaderSerial);
        public Task<Handlers.TeacherLogResult> LogOnBreakTeacher(TeachersDTO teacher, string ReaderSerial);
        public Task<List<StudentsDTO.StudentLogReport>> GetPresentStudents();
        public Task<List<TeacherLogsModel>> GetTeacherLogsById(Guid id);
    }
}
