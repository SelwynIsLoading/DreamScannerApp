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
        public VerifyControl()
        {
            InitializeComponent();
            _verificator = new Services.Verification();
            _verificator.studentDataCallback += OnStudentDataReceived;
            _verificator.reportCallback += OnStatusRecieved;
            _verificator.stateCallback += OnStateRecieved;
            Disposed += VerifyControl_Disposed;
        }

        private void VerifyControl_Disposed(object sender, EventArgs e)
        {
            _verificator.StopCapture();
        }


        private void OnStudentDataReceived(List<StudentsDTO.StudentDetail> students)
        {
            UpdateVerification(() =>
            {
                if (students != null && students.Count > 0)
                {
                    tbName.Text = students.Select(s => s.FirstName + " " + s.MiddleInitial + " " + s.LastName).FirstOrDefault();
                    tbSection.Text = students.Select(s => s.section).FirstOrDefault().ToString();
                    tbInOut.Text = students.Select(s => s.IsIn ? "In" : "Out").FirstOrDefault();
                    pbGender.Image = students.Select(s => s.Gender).FirstOrDefault() == StudentProperties.Gender.Female ? Resources.Female : Resources.Male;
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

        private void OnStateRecieved(string state)
        {
            UpdateState(() =>
            {
                tbState.Text = state;
            });
        }

        public void UpdateState(Action action)
        {
            if (tbState.InvokeRequired)
            {
                tbState.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public void UpdateVerification(Action action)
        {
            if (tbName.InvokeRequired && tbSection.InvokeRequired && tbInOut.InvokeRequired)
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
            if (tbStatus.InvokeRequired)
            {
                tbStatus.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void VerifyControl_Load(object sender, EventArgs e)
        {
            _verificator = new Services.Verification();
            _verificator.studentDataCallback += OnStudentDataReceived;
            _verificator.reportCallback += OnStatusRecieved;
            _verificator.stateCallback += OnStateRecieved;
            _verificator.StartCapture();
        }

        private void VerifyControl_VisibleChanged(object sender, EventArgs e)
        {
            _verificator.StopCapture();
        }
    }
}
