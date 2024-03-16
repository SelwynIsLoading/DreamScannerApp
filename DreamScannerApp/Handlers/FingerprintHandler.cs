using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;

namespace DreamScannerApp.Services
{
    public class FingerprintHandler : DPFP.Capture.EventHandler
    {

        private Capture Capturer;
        public delegate void ReportCallback(string message);
        public delegate void ImageCallback(Bitmap bitmap);
        public event ReportCallback? reportCallback;
        public event ImageCallback? imageCallback;

        public FingerprintHandler()
        {
            Initialize();
        }

        protected virtual void Initialize()
        {
            try
            {
                Capturer = new Capture();
                if (Capturer != null)
                {
                    Capturer.EventHandler = this;                    
                }
                else
                {
                    MakeReport("Can't initiate capture operation!");
                }
            }
            catch (Exception ex)
            {
                MakeReport($"Can't initiate Capture: {ex.Message}");
            }
        }

        public void StartCapture()
        {
            Capturer.EventHandler = this;
            if (Capturer != null)
            {
                try
                {
                    Capturer.StartCapture();
                    MakeReport("Using the fingerprint reader, scan your fingerprint.");
                }
                catch(Exception ex)
                {
                    MakeReport($"Can't initiate Capture: {ex.Message}");
                }   
            }
        }

        public void StopCapture()
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StopCapture();
                    MakeReport("Capture Stopped");
                }
                catch
                {
                    MakeReport("Can't stop capturing");
                }
            }
        }

        protected void MakeReport(string message)
        {
            reportCallback?.Invoke(message);
        }

        public virtual void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            MakeReport("The fingerprint was captured.");
            Process(Sample);
        }

        public virtual void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the reader.");
        }

        public virtual void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        public virtual void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");   
        }

        public virtual void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public virtual void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == CaptureFeedback.Good)
            {
                MakeReport("The quality of the fingerprint is good.");
            }
            else
            {
                MakeReport("The quality of the fingerprint is poor.");
            }
        }

        protected virtual void Process(Sample sample)
        {
            DrawPicture(ConvertSampleToBitmap(sample));  
        }

        protected Bitmap ConvertSampleToBitmap(Sample sample)
        {
            SampleConversion convertor = new SampleConversion();
            Bitmap? bitmap = null;
            convertor.ConvertToPicture(sample, ref bitmap);
            return bitmap;
        }

        protected void DrawPicture(Bitmap bitmap)
        {
            imageCallback?.Invoke(bitmap);
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

    }
}
