using DreamScannerApp.Handlers;
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
            fingerEnrollment = new FingerEnrollment(MakeReport, DisplayImage);
            InitializeComponent();
        }

        private void FingerprintAddControl_Load(object sender, EventArgs e)
        {
            fingerEnrollment.StartCapture();
        }

        public void MakeReport(string message)
        {
            this.Invoke(new Action(delegate ()
            {
                if(message.ToUpper() == "Capture Stopped".ToUpper())
                {
                    ((FingerprintAdd)this.ParentForm).Close();
                }
                tbStatus.Text = message;
            }));
        }

        public void DisplayImage(Bitmap image)
        {
            pbFingerprint.Image = new Bitmap(image, pbFingerprint.Size);
        }
    }
}
