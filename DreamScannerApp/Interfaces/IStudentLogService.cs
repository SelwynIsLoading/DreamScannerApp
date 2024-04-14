using DreamScannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Interfaces
{
    public interface IStudentLogService
    {
        public Task<Handlers.StudentLogResult> LogStudent(StudentsDTO.StudentDetail student, string ReaderSerial);
        public Task<Handlers.StudentLogResult> LogOnBreakStudent(StudentsDTO.StudentDetail student, string ReaderSerial);
        public Task<List<StudentsDTO.StudentDetail>> VerifyStudentFingerprint(DPFP.FeatureSet featureSet, string ReaderSerial);
        public Task<List<StudentsDTO.StudentLog>> GetStudentLogInfo();
        public Task<List<StudentsDTO.StudentLog>> FilterStudentLog(StudentLogFilterDTO filter);
        public Task AddLog(Guid FingerprintId, DateTime LogDate, string Remarks);
    }
}
