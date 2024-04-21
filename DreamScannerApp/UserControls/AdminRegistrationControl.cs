using DreamScannerApp.Models.Entities;
using DreamScannerApp.Models.Enums;
using DreamScannerApp.Services;
using DreamScannerApp.UI;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class AdminRegistrationControl : UserControl
    {
        private AdminEntity adminModel = new AdminEntity();
        private Result _result = new Result();
        private readonly StudentService studentService;
        public AdminRegistrationControl()
        {
            studentService = Program.ServiceProvider.GetRequiredService<StudentService>();
            InitializeComponent();
        }

        private async void btnEnrollFingerprint_Click(object sender, EventArgs e)
        {
            switch (btnEnrollFingerprint.Text)
            {
                case "Enroll Fingerprint":
                    btnEnrollFingerprint.Text = "Enroll";
                    if (!validate()) { return; }
                    //FingerprintAdd finger = new FingerprintAdd();
                    //finger.OnTemplate += (template) =>
                    //{
                    //    _result.fingerprintTemplate = template.Bytes;
                    //};
                    //finger.ShowDialog();
                    break;
                case "Enroll":
                    btnEnrollFingerprint.Text = "Enroll Fingerprint";
                    var admin = new AdminEntity
                    {
                        FirstName = tbFname.Text,
                        LastName = tbLastName.Text,
                        UserName = tbUserName.Text,
                        Password = tbPassword.Text,
                        FingerprintData = _result.fingerprintTemplate
                    };
                    //if (admin.FingerprintData == null)
                    //{
                    //    MessageBox.Show("Please enroll fingerprint first!", "DreamScanner Enroll", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return;
                    //}
                    var result = await studentService.AddAdminAsync(admin);
                    if (result.IsSaved)
                    {
                        if(DialogResult.Yes == MessageBox.Show("Student Successfully Enrolled!", "DreamScanner Enroll", MessageBoxButtons.OK, MessageBoxIcon.Information))
                        {
                            ((RegistrationFrm)this.ParentForm!).Close();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show(result.Message);
                    }
                    break;
            }
        }
        private bool validate()
        {
            if (string.IsNullOrEmpty(tbFname.Text) ||
                string.IsNullOrEmpty(tbLastName.Text) ||
                string.IsNullOrEmpty(tbUserName.Text) ||
                string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please fill up all fields!", "DreamScanner Enroll", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
