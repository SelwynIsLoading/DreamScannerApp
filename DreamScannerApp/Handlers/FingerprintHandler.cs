using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;

namespace DreamScannerApp.Services
{
    public class FingerprintHandler : DPFP.Capture.EventHandler
    {
        private Capture? Capturer;
        protected readonly Result messages;
        private readonly UserControl form;

        public FingerprintHandler(Result messages, UserControl form)
        {
            this.messages = messages;
            this.form = form;

            Initialize();
        }

        protected virtual void Initialize()
        {
            try
            {
                Capturer = new Capture();
                if (null != Capturer)
                {
                    Capturer.EventHandler = this;
                }
                else
                {
                    MakeReport("Can't initiate capture operation!");    
                }
            }
            catch
            {
                
            }
        }

        public void StartCapture()
        {
            Capturer = new Capture();
            Capturer.EventHandler = this;
            if (Capturer != null)
            {
                try
                {
                    Capturer.StartCapture();
                    MakeReport("Using The Fingerprint reader, scan your fingerprint");
                }
                catch
                {
                    MakeReport("Can't initiate Capture");
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
            form.Invoke(new Action(delegate ()
            {
                messages.Status = message;
            }));
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
            form.Invoke(new Action(delegate ()
            {
                messages.fingerImage = bitmap;
            }));
        }


    }
}
