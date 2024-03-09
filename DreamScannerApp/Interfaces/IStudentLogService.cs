﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Interfaces
{
    public interface IStudentLogService
    {
        public void LogStudent(Models.StudentsDTO.StudentLog student);
        public List<Models.StudentsDTO.StudentLog> VerifyStudentFingerprint(DPFP.FeatureSet featureSet, string ReaderSerial);
    }
}
