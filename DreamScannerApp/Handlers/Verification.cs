using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP;

namespace DreamScannerApp.Services
{
    public class Verification : FingerprintHandler
    {
        private DPFP.Verification.Verification Verificator;
        public delegate void StudentDataCallback(List<StudentsDTO.StudentLog> data);
        public event StudentDataCallback studentDataCallback;
        private readonly IStudentLogService _studentService;
        private string _ReaderSerial = "";
        public Verification(IStudentLogService studentLogService)
        {
            _studentService = studentLogService;
            Initialize();
        }
        protected override void Initialize()
        {
            base.Initialize();
            Verificator = new DPFP.Verification.Verification();
        }
        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            if (features != null)
            {
                List<StudentsDTO.StudentLog> students = _studentService.VerifyStudentFingerprint(features, _ReaderSerial);
                GenerateStudentData(students);
            }
        }

        public override void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            _ReaderSerial = ReaderSerialNumber;
            base.OnComplete(Capture, ReaderSerialNumber, Sample);
        }

        public void GenerateStudentData(List<StudentsDTO.StudentLog> students)
        {
            studentDataCallback.Invoke(students);
        }        

    }
}
