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
        private Result result;


        public FingerEnrollment(Action<string> reportCallback, Action<Bitmap> imageCallback) : base(reportCallback, imageCallback)
        {
            Enroller = new DPFP.Processing.Enrollment();
            Template = new Template();
            result = new Result();
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
        private FeatureSet? ExtractFeatures(Sample Sample, DataPurpose Purpose)
        {
            // Extract the features from the sample
            FeatureExtraction Extractor = new FeatureExtraction();
            CaptureFeedback feedback = CaptureFeedback.None;
            FeatureSet features = new FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == CaptureFeedback.Good)
                return features;
            else
                return null;
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
                        result.AddFingerprint(Template);
                    }
                }
            }
        }

        public bool IsDoneEnrolling()
        {
            MakeReport("Fingerprint enrollment is complete.");
            return result.IsSaved;
        }

    }
}
