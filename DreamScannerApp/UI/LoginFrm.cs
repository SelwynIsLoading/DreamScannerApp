
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
        private readonly IStudentService studentService;
        public LoginFrm()
        {
            studentService = Program.ServiceProvider.GetRequiredService<Services.StudentService>();
            _verification = new Services.Verification();
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            _verification.adminCallback += (verified) =>
            {
                AdminVerification(verified);
            };
            _verification.StartCapture();
        }

        private void AdminVerification(bool isVerified)
        {
            if (isVerified)
            {
                _verification.StopCapture();
                MainDashboardFrm main = new MainDashboardFrm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No student found");
                return;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            _verification.StopCapture();
            RegistrationFrm reg = new RegistrationFrm();
            reg.ShowDialog();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = tbUserName.Text;
            var password = tbPassword.Text;
            var verified = await studentService.AdminLogIn(username, password);
            if (verified)
            {
                AdminVerification(true);
            }
            else
            {
                MessageBox.Show("Invalid Credentials!"); return;
            }
        }
    }
}