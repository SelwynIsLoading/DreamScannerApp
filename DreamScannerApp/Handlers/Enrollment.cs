using DPFP.Capture;
using DPFP.Processing;
using DPFP;
using DreamScannerApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Handlers
{
    public class Enrollment : FingerprintHandler
    {
        private DPFP.Template Template;
        private DPFP.Processing.Enrollment Enroller;
        private Result result;
        public Enrollment(Result messages, UserControl form) : base(messages, form)
        {
            Enroller = new DPFP.Processing.Enrollment();
            Template = new Template();
            result = new Result();
            Initialize();
            StartCapture();
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
                            MakeReport("The fingerprint template is not sufficient for fingerprint verification. Please scan your fingerprint again.");
                            break;
                    }
                    result.fingerprintTemplate = Template;
                }
            }
        }

    }
}
