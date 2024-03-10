using DPFP.Capture;
using DPFP.Processing;
using DPFP;
using DreamScannerApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamScannerApp.UI;

namespace DreamScannerApp.Handlers
{
    public class FingerEnrollment : FingerprintHandler
    {
        private DPFP.Template Template;
        private DPFP.Processing.Enrollment Enroller;
        private StudentService _studentService;

        private string ReaderSerial = "";

        private Result _result;

        public FingerEnrollment(Result result)
        {
            Enroller = new DPFP.Processing.Enrollment();
            _result = result;
            Template = new Template();
            Initialize();
        }

        public override void StartCapture()
        {
            base.StartCapture();
        }
        public override void StopCapture()
        {
            base.StopCapture();
        }

        public override void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            base.OnComplete(Capture, ReaderSerialNumber, Sample);            
            FeatureSet? featureSet = ExtractFeatures(Sample, DataPurpose.Enrollment);
            if (featureSet != null)
            {
                try
                {
                    MakeReport("The fingerprint feature set was created.");
                    Enroller.AddFeatures(featureSet);
                }
                finally
                {
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:
                            MakeReport("The fingerprint template is ready for fingerprint verification.");
                            Template = Enroller.Template;
                            StopCapture();
                            break;
                        case DPFP.Processing.Enrollment.Status.Failed:
                            Enroller.Clear();
                            StopCapture();
                            StartCapture();
                            break;
                        case DPFP.Processing.Enrollment.Status.Insufficient:
                            MakeReport("Need more samples: " + Enroller.FeaturesNeeded);
                            break;                        
                    }
                    if (Enroller.FeaturesNeeded <= 0)
                    {
                        _result.fingerprintTemplate = Template.Bytes; 
                    }
                }
            }
        }

        

    }
}
