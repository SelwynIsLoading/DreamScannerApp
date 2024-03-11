using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using Krypton.Toolkit;

namespace DreamScannerApp.UI
{
    public partial class EditStudentFrm : KryptonForm
    {
        private List<StudentsDTO.StudentDetails> model;
        private readonly IStudentService _studentService;
        public EditStudentFrm(string studentNumber, IStudentService service)
        {
            InitializeComponent();
            _studentService = service;
            model = _studentService.GetStudentsByStudentNumber(studentNumber);
        }

        private void EditStudentFrm_Load(object sender, EventArgs e)
        {
            tbFname.Text = model.Select(s => s.FirstName).FirstOrDefault();
            tbLastName.Text = model.Select(s => s.LastName).FirstOrDefault();
            tbMiddleInitial.Text = model.Select(s => s.MiddleInitial).FirstOrDefault();
            tbStudentNum.Text = model.Select(s => s.StudentNumber).FirstOrDefault();
            cbGender.SelectedItem = model.Select(s => s.Gender);
            cbRoom.SelectedItem = model.Select(s => s.Room);
            cbSection.SelectedItem = model.Select(s => s.Section);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var student = new StudentsDTO.StudentDetails
            {
                FirstName = tbFname.Text,
                LastName = tbLastName.Text,
                MiddleInitial = tbMiddleInitial.Text,
                StudentNumber = tbStudentNum.Text,
                Gender = (Models.Enums.StudentProperties.Gender)cbGender.SelectedItem,
                Room = (Models.Enums.StudentProperties.Room)cbRoom.SelectedItem,
                Section = (Models.Enums.StudentProperties.Section)cbSection.SelectedItem
            };
            if(MessageBox.Show("Are you sure you want to update?", "Update Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_studentService.UpdateStudent(student))
                {
                    MessageBox.Show("Student Information Updated!", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Student Update Failed!", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
