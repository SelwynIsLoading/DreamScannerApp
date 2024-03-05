using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP;
using DPFP.Capture;

namespace DreamScannerApp.Services
{
    public class FingerprintService : DPFP.Capture.EventHandler
    {
        public event EventHandler<string> ReportGenerated;

        private FingerMessages fingerMessages = new FingerMessages();

        protected virtual void OnReportGenerated(string message)
        {
            ReportGenerated?.Invoke(this, message);
        }

        protected void MakeReport(string message)
        {
            OnReportGenerated(message);
        }

        private void UpdateFingerMessagesStatus(object sender, string message)
        {
            fingerMessages.Status = message;
        }

        void DPFP.Capture.EventHandler.OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            MakeReport("The fingerprint was captured.");
            Process(Sample);
        }

        void DPFP.Capture.EventHandler.OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the reader.");
        }

        void DPFP.Capture.EventHandler.OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        void DPFP.Capture.EventHandler.OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");   
        }

        void DPFP.Capture.EventHandler.OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        void DPFP.Capture.EventHandler.OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
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
            ConvertSampleToBitmap(sample);   
        }

        protected void ConvertSampleToBitmap(Sample sample)
        {
            SampleConversion convertor = new SampleConversion();
            Bitmap bitmap = null;
            convertor.ConvertToPicture(sample, ref bitmap);
            fingerMessages.fingerPicture = bitmap;
        }


    }
}
