using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using DreamScannerApp.Services;
using DreamScannerApp.Models;

namespace DreamScannerApp.UI
{
    public partial class AdminVerificationFrm : KryptonForm
    {
        private Verification _verificator;
        public bool isVerified = false;
        public AdminVerificationFrm()
        {
            InitializeComponent();
            _verificator = new Verification();
        }

        private void AdminVerificationFrm_Load(object sender, EventArgs e)
        {
            _verificator.studentDataCallback += OnStudentDataReceived;
            _verificator.teacherDataCallback += OnTeacherDataReceived;
            _verificator.invalidCallback += OnInvalidDataReceived;            
            _verificator.StartCapture();
        }

        private void OnInvalidDataReceived()
        {
            UpdateVerification(() =>
            {
                Properties.Settings.Default.IsHold = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Invalid fingerprint");
            });
        }

        private void OnStudentDataReceived(List<StudentsDTO.StudentDetail> data)
        {
            UpdateVerification(() =>
            {
                Properties.Settings.Default.IsHold = true;
                Properties.Settings.Default.Save();
                isVerified = true;
                this.Close();
            });
        }

        private void OnTeacherDataReceived(List<TeachersDTO> data)
        {
            UpdateVerification(() =>
            {
                Properties.Settings.Default.IsHold = true;
                Properties.Settings.Default.Save();
                isVerified = true;
                this.Close();
            });
        }

        public void UpdateVerification(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminVerificationFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _verificator.StopCapture();
        }
    }
}
