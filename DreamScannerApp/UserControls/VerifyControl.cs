using DreamScannerApp.Models;
using DreamScannerApp.Models.Enums;
using DreamScannerApp.Properties;
using DreamScannerApp.UI;
using System.ComponentModel;
using System.Data;
using System.Runtime.Versioning;

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
            _verificator.teacherDataCallback += OnTeacherDataReceived;
            _verificator.reportCallback += OnStatusRecieved;
            _verificator.stateCallback += OnStateRecieved;
            _verificator.invalidCallback += OnInvalidRecieved;
            Disposed += VerifyControl_Disposed;
        }

        private void OnTeacherDataReceived(TeachersDTO t)
        {
            UpdateVerification(() =>
            {
                if (t != null)
                {
                    tbName.Text = t.FirstName + " " + t.MiddleInitial + " " + t.LastName;
                    tbSection.Text = t.Section.ToString();
                    tbInOut.Text = t.IsIn ? "In" : "Out";
                    pbGender.Image = t.Gender == TeacherProperties.Gender.Female ? Resources.Female : Resources.Male;
                }
            });
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

        private void OnInvalidRecieved()
        {
            UpdateVerification(() =>
            {
                tbName.Text = "Invalid!";
                tbSection.Text = "";
                tbInOut.Text = "";
                pbGender.Image = Resources.Invalid;
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
            if (tbName.InvokeRequired && tbSection.InvokeRequired && tbInOut.InvokeRequired || pbGender.InvokeRequired)
            {
                tbName.Invoke(action);
                tbSection.Invoke(action);
                tbInOut.Invoke(action);
                pbGender.Invoke(action);
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
            _verificator.teacherDataCallback += OnTeacherDataReceived;
            _verificator.reportCallback += OnStatusRecieved;
            _verificator.stateCallback += OnStateRecieved;
            _verificator.invalidCallback += OnInvalidRecieved;
            _verificator.StartCapture();
            chkHold.Checked = Properties.Settings.Default.IsHold;
        }

        private void VerifyControl_VisibleChanged(object sender, EventArgs e)
        {
            _verificator.StopCapture();
        }

        private void chkHold_CheckedChanged(object sender, EventArgs e)
        {
            _verificator.StopCapture();
            AdminVerificationFrm adminVerificationFrm = new AdminVerificationFrm();
            adminVerificationFrm.ShowDialog();
            if(adminVerificationFrm.isVerified)
            {
                Properties.Settings.Default.IsHold = chkHold.Checked;
                Properties.Settings.Default.Save();
            }
            else
            {
                chkHold.Checked = !chkHold.Checked;
            }
            _verificator.StartCapture();
        }
    }
}
