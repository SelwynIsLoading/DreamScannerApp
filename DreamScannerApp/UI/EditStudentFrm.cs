using System;
using System.Linq;
using System.Windows.Forms;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Enums;
using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;

namespace DreamScannerApp.UI
{
    public partial class EditStudentFrm : KryptonForm
    {
        private readonly IStudentService _studentService;
        private StudentsDTO.StudentDetails _studentDetails;

        public EditStudentFrm(StudentsDTO.StudentDetails student)
        {
            InitializeComponent();
            _studentService = Program.ServiceProvider.GetRequiredService<IStudentService>();
            _studentDetails = _studentService.GetStudentsByStudentNumber(student.StudentNumber).FirstOrDefault();
            InitializeComboBoxes();
            DisplayStudentDetails();
        }

        private void InitializeComboBoxes()
        {
            cbGender.Items.AddRange(Enum.GetNames(typeof(StudentProperties.Gender)));
            cbRoom.Items.AddRange(Enum.GetNames(typeof(StudentProperties.Room)));
            cbSection.Items.AddRange(Enum.GetNames(typeof(StudentProperties.Section)));
        }

        private void DisplayStudentDetails()
        {
            if (_studentDetails != null)
            {
                tbFname.Text = _studentDetails.FirstName;
                tbLastName.Text = _studentDetails.LastName;
                tbMiddleInitial.Text = _studentDetails.MiddleInitial;
                tbStudentNum.Text = _studentDetails.StudentNumber;
                cbGender.SelectedIndex = (int)_studentDetails.Gender - 1;
                cbRoom.SelectedIndex = (int)_studentDetails.Room - 1;
                cbSection.SelectedIndex = (int)_studentDetails.Section - 1;
            }
            else
            {
                MessageBox.Show("Student details not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update?", "Update Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                UpdateStudent();
            }
        }

        private void UpdateStudent()
        {
            var updatedStudent = new StudentsDTO.StudentDetails
            {
                Id = _studentDetails.Id,
                FirstName = tbFname.Text,
                LastName = tbLastName.Text,
                MiddleInitial = tbMiddleInitial.Text,
                StudentNumber = tbStudentNum.Text,
                Gender = (StudentProperties.Gender)Enum.Parse(typeof(StudentProperties.Gender), cbGender.SelectedItem.ToString()),
                Room = (StudentProperties.Room)Enum.Parse(typeof(StudentProperties.Room), cbRoom.SelectedItem.ToString()),
                Section = (StudentProperties.Section)Enum.Parse(typeof(StudentProperties.Section), cbSection.SelectedItem.ToString())
            };

            try
            {
                if (_studentService.UpdateStudent(updatedStudent))
                {
                    MessageBox.Show("Student Information Updated!", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Student Update Failed!", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating student information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
