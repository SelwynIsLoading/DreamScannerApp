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
        public List<Handlers.StudentLogResult> LogStudent(Models.StudentsDTO.StudentDetail student, string ReaderSerial);
        public List<Handlers.StudentLogResult> LogOnBreakStudent(Models.StudentsDTO.StudentDetail student, string ReaderSerial);
        public List<Models.StudentsDTO.StudentDetail> VerifyStudentFingerprint(DPFP.FeatureSet featureSet, string ReaderSerial);
        public List<StudentsDTO.StudentLog> GetStudentLogInfo();
        public List<StudentsDTO.StudentLog> FilterStudentLog(Models.StudentLogFilterDTO filter);
    }
}
