using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Services;
using DreamScannerApp.UserControls;
using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;

namespace DreamScannerApp.UI
{
    public partial class RegistrationFrm : KryptonForm
    {
        public RegistrationFrm()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            containerPnl.Controls.Clear();
            containerPnl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void RegistrationFrm_Load(object sender, EventArgs e)
        {
            AdminRegistrationControl enroll = new AdminRegistrationControl();
            addUserControl(enroll);
        }
    }
}
