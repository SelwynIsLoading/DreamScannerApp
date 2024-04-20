using DreamScannerApp.Handlers;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Services;
using DreamScannerApp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamScannerApp.UserControls
{
    public partial class FingerprintAddControl : UserControl
    {
        private FingerEnrollment fingerEnrollment;
        public FingerprintAddControl()
        {
            fingerEnrollment = new FingerEnrollment();
            fingerEnrollment.reportCallback += MakeReport;
            fingerEnrollment.imageCallback += DisplayImage;
            InitializeComponent();
        }


        private void FingerprintAddControl_Load(object sender, EventArgs e)
        {
            fingerEnrollment.OnTemplate += (template) =>
            {
                if(template != null)
                {
                    ((FingerprintAdd)this.ParentForm!).GetTemplate(template);
                }
                ((FingerprintAdd)this.ParentForm!).GetTemplate(template);
            };
            fingerEnrollment.StartCapture();
        }

        public void MakeReport(string message)
        {
            UpdateStatus(() => {
                tbStatus.Text = message;            
                if (message.ToUpper() == "Capture Stopped".ToUpper())
                {
                    //fingerEnrollment.StopCapture();
                    fingerEnrollment = new FingerEnrollment();
                    ((FingerprintAdd)this.ParentForm!).Close();
                }
            });
        }

        public void DisplayImage(Bitmap image)
        {
            UpdateImage(() =>
            {
                pbFingerprint.Image = new Bitmap(image, pbFingerprint.Size);
            });
        }

        public void UpdateStatus(Action action)
        {
            if(tbStatus.InvokeRequired)
            {
                tbStatus.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public void UpdateImage(Action action)
        {
            if(pbFingerprint.InvokeRequired)
            {
                pbFingerprint.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
