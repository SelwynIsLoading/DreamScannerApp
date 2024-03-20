
using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using DreamScannerApp.UserControls.StudentsUserControls;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
using System.Net.Mail;

namespace DreamScannerApp
{
    public partial class LoginFrm
    {
        private readonly IEmailService _emailService;
        public LoginFrm()
        {
            InitializeComponent();
            _emailService = Program.ServiceProvider.GetRequiredService<IEmailService>();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SendEmail();
        }

        private async void SendEmail()
        {
            try
            {
                // Create email message
                var email = new EmailDTO
                {
                    SenderEmail = "caubalejoselwyn@gmail.com",
                    SenderPassword = "uawp mexz nwrh lnwl",
                    RecipientEmail = "caubalejoselwyn@gmail.com",
                    Subject = "Student Data",
                    FilePath = "C:\\Users\\cauba\\Desktop\\Sports Fest 2023 Attendance (CPE).xlsx"
                };

                // Send email
                await _emailService.SendEmail(email);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}