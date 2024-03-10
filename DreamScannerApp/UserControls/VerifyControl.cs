using DPFP.Verification;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Enums;
using DreamScannerApp.Properties;
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
    public partial class VerifyControl : UserControl
    {
        private Services.Verification _verificator;
        public VerifyControl(Services.Verification verification)
        {
            InitializeComponent();
            _verificator = verification;
            _verificator.studentDataCallback += OnStudentDataReceived;
            _verificator.reportCallback += OnStatusRecieved;
            _verificator.StartCapture();
        }

        private void OnStudentDataReceived(List<StudentsDTO.StudentLog> students)
        {
            UpdateVerification(() =>
            {
                if (students != null && students.Count > 0)
                {
                    tbName.Text = students.Select(s => s.FirstName + " " + s.MiddleInitial + " " + s.LastName).FirstOrDefault();
                    tbSection.Text = students.Select(s => s.section).FirstOrDefault().ToString();
                    tbInOut.Text = students.Select(s => s.IsIn ? "In" : "Out").FirstOrDefault();
                    pbGender.Image = students.Select(s => s.gender).FirstOrDefault() == StudentProperties.Gender.Female ? Resources.Female : Resources.Male;
                }
                else
                {
                    tbName.Text = "Invalid!";
                    tbSection.Text = "";
                    tbInOut.Text = "";
                    pbGender.Image = Resources.Invalid;
                }
            });
        }

        private void OnStatusRecieved(string message)
        {
            UpdateStatus(() =>
            {
                tbStatus.Text = message;
            });
        }

        public void UpdateVerification(Action action)
        {
            if(tbName.InvokeRequired && tbSection.InvokeRequired && tbInOut.InvokeRequired)
            {
                tbName.Invoke(action);
                tbSection.Invoke(action);
                tbInOut.Invoke(action);
            }
            else
            {
                action();
            }
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

    }
}
