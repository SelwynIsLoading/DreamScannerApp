
using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using DreamScannerApp.UI;
using DreamScannerApp.UserControls.StudentsUserControls;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
using System.Net.Mail;

namespace DreamScannerApp
{
    public partial class LoginFrm
    {
        private Services.Verification _verification;
        public LoginFrm()
        {
            _verification = new Services.Verification();
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            _verification.StartCapture();
            _verification.adminCallback += (verified) => {
                AdminVerification(verified);
            };
        }

        private void AdminVerification(bool isVerified)
        {
            if (isVerified)
            {
                _verification.StopCapture();
                MainDashboardFrm main = new MainDashboardFrm();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No student found");
                return;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegistrationFrm reg = new RegistrationFrm();
            reg.ShowDialog();
        }
    }
}