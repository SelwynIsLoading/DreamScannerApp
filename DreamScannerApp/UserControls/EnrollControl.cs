using DreamScannerApp.Interfaces;
using DreamScannerApp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamScannerApp.Models.Enums;
using DreamScannerApp.Services;
using DreamScannerApp.Handlers;

namespace DreamScannerApp.UserControls
{
    public partial class EnrollControl : UserControl
    {
        private StudentService _studentService;
        private Result _result;
        public EnrollControl(StudentService studentService, Result result)
        {
            _studentService = studentService;
            _result = result;
            InitializeComponent();
            cbSection.DataSource = Enum.GetValues(typeof(StudentProperties.Section));
            cbRoom.DataSource = Enum.GetValues(typeof(StudentProperties.Room));
            cbGender.DataSource = Enum.GetValues(typeof(StudentProperties.Gender));
        }

        private void btnEnrollFingerprint_Click(object sender, EventArgs e)
        {
            switch(btnEnrollFingerprint.Text)
            {
                case "Enroll Fingerprint":
                    btnEnrollFingerprint.Text = "Enroll";
                    if(!validate()) return;
                    FingerprintAdd finger = new FingerprintAdd(_result);
                    finger.ShowDialog();
                    break;
                case "Enroll":
                    btnEnrollFingerprint.Text = "Enroll Fingerprint";
                    var student = new Models.StudentsDTO.CreateStudent
                    {
                        FirstName = tbFname.Text,
                        LastName = tbLastName.Text,
                        MiddleInitial = tbMiddleInitial.Text,
                        StudentNumber = tbStudentNum.Text,
                        section = Enum.TryParse<StudentProperties.Section>(cbSection.SelectedValue.ToString(), out var section) ? section : StudentProperties.Section.None,
                        room = Enum.TryParse<StudentProperties.Room>(cbRoom.SelectedValue.ToString(), out var room) ? room : StudentProperties.Room.Unknown,
                        gender = Enum.TryParse<StudentProperties.Gender>(cbGender.SelectedValue.ToString(), out var gender) ? gender : StudentProperties.Gender.None,
                        fingerprintData = _result.fingerprintTemplate
                    };
                    if (_studentService.AddStudent(student))
                    {
                        MessageBox.Show("Student Successfully Enrolled!", "DreamScanner Enroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    break;
            }
        }
        private void clear()
        {
            tbFname.Text = "";
            tbLastName.Text = "";
            tbMiddleInitial.Text = "";
            tbStudentNum.Text = "";
            cbSection.Text = "";
            cbRoom.Text = "";
            cbGender.Text = "";
        }

        private bool validate()
        {
            if (string.IsNullOrEmpty(tbFname.Text) || 
                string.IsNullOrEmpty(tbLastName.Text) || 
                string.IsNullOrEmpty(tbStudentNum.Text) || 
                string.IsNullOrEmpty(cbSection.Text) || 
                string.IsNullOrEmpty(cbRoom.Text) || 
                string.IsNullOrEmpty(cbGender.Text))
            {
                MessageBox.Show("Please fill up all fields!", "DreamScanner Enroll", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
