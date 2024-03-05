using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFP;
using DPFP.Capture;

namespace DreamScannerApp.Services
{
    public class FingerprintHandler : DPFP.Capture.EventHandler
    {
        private Capture? Capturer;
        protected readonly Messages messages;
        private readonly UserControl form;

        public FingerprintHandler(Messages messages, UserControl form)
        {
            this.messages = messages;
            this.form = form;

            Initialize();
        }

        protected void Initialize()
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
                    throw new Exception("Can't initiate capture operation!");
                }
            }
            catch
            {
                throw new Exception("Can't initiate capture operation!");
            }
        }


        protected void MakeReport(string message)
        {
            form.Invoke(new Action(delegate ()
            {
                messages.Status = message;
            }));
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
