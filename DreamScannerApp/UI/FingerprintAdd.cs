using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP.Processing;
using Krypton.Toolkit;
using DreamScannerApp.Handlers;
using DreamScannerApp.Services;
using DreamScannerApp.UserControls;

namespace DreamScannerApp.UI
{
    public partial class FingerprintAdd : KryptonForm
    {
        public delegate void SetFingerprintTemplate(DPFP.Template template);
        public event SetFingerprintTemplate OnTemplate;
        private DPFP.Template _template { get; set; } = new DPFP.Template();
        public FingerprintAdd()
        {
            InitializeComponent();
        }

        private void FingerprintAdd_Load(object sender, EventArgs e)
        {
            FingerprintAddControl fingerprintAddControl = new FingerprintAddControl();
            addUserControl(fingerprintAddControl);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            containerPnl.Controls.Clear();
            containerPnl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void GetTemplate(DPFP.Template template)
        {
            _template = template;
            OnTemplate?.Invoke(_template);
        }
    }
}
