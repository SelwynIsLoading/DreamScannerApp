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
using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;

namespace DreamScannerApp.UI
{
    public partial class EditTeacherFrm : KryptonForm
    {
        private Models.TeachersDTO _teacher;
        private readonly ITeacherService _teacherService;
        public EditTeacherFrm(Models.TeachersDTO teacher)
        {
            InitializeComponent();
            InitializeComboBox();
            _teacher = teacher;
            _teacherService = Program.ServiceProvider.GetRequiredService<ITeacherService>();
        }
        private void EditTeacherFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            tbFname.Text = _teacher.FirstName;
            tbLastName.Text = _teacher.LastName;
            tbMiddleInitial.Text = _teacher.MiddleInitial;
            tbSubject.Text = _teacher.Subject;
            tbEmail.Text = _teacher.Email;
            tFrom.Value = _teacher.TimeFrom;
            tTo.Value = _teacher.TimeTo;
            cbGender.SelectedIndex = (int)_teacher.Gender;
            cbRoom.SelectedIndex = (int)_teacher.Room;
            cbSection.SelectedIndex = (int)_teacher.Section;
        }
        private void InitializeComboBox()
        {
            cbGender.DataSource = Enum.GetValues(typeof(Models.Enums.TeacherProperties.Gender));
            cbRoom.DataSource = Enum.GetValues(typeof(Models.Enums.TeacherProperties.room));
            cbSection.DataSource = Enum.GetValues(typeof(Models.Enums.TeacherProperties.Section));
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _teacher = new Models.TeachersDTO
                {
                    Id = _teacher.Id,
                    FirstName = tbFname.Text,
                    LastName = tbLastName.Text,
                    MiddleInitial = tbMiddleInitial.Text,
                    Subject = tbSubject.Text,
                    Email = tbEmail.Text,
                    TimeFrom = tFrom.Value,
                    TimeTo = tTo.Value,
                    Gender = (Models.Enums.TeacherProperties.Gender)cbGender.SelectedItem,
                    Room = (Models.Enums.TeacherProperties.room)cbRoom.SelectedItem,
                    Section = (Models.Enums.TeacherProperties.Section)cbSection.SelectedItem
                };
                if(DialogResult.Yes == MessageBox.Show("Are you sure you want to update?", "Update Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    await _teacherService.UpdateTeacher(_teacher);
                    MessageBox.Show("Teacher updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Failed to update teacher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
