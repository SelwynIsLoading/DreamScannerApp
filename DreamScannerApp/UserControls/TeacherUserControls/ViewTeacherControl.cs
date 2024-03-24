using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using DreamScannerApp.UI;
using DreamScannerApp.UserControls.StudentsUserControls;
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

namespace DreamScannerApp.UserControls.TeacherUserControls
{
    public partial class ViewTeacherControl : UserControl
    {
        public readonly ITeacherService _teacherService;
        List<TeachersDTO> model = new List<TeachersDTO>();
        public ViewTeacherControl()
        {
            _teacherService = Program.ServiceProvider.GetRequiredService<ITeacherService>();
            InitializeComponent();
        }

        private async void ViewTeacherControl_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                model = await _teacherService.GetTeachers();
                dgTeachers.Rows.Clear();
                foreach (var teacher in model)
                {
                    int rowIndex = dgTeachers.Rows.Add(new object[]
                    {
                        $"{teacher.LastName}, {teacher.FirstName} {teacher.MiddleInitial}",
                        teacher.Subject,
                        teacher.Room,
                        teacher.TimeFrom.ToShortTimeString(),
                        teacher.TimeTo.ToShortTimeString(),
                        teacher.Gender
                    });
                    dgTeachers.Rows[rowIndex].Tag = teacher.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                await UpdateTeacher(e.RowIndex);
            }
            if(e.ColumnIndex == 7)
            {
                await DeleteTeacher(e.RowIndex);
            }
        }

        private async Task UpdateTeacher(int row)
        {
            var toUpdate = model.ElementAtOrDefault(row);
            if (toUpdate != null)
            {
                var editTeacher = new EditTeacherFrm(toUpdate);
                editTeacher.FormClosed += async (sender, args) =>
                {
                    if (editTeacher.DialogResult == DialogResult.OK)
                        await LoadData();
                };
                editTeacher.ShowDialog();
            }
        }

        private async Task DeleteTeacher(int row)
        {
            try
            {
                var toDelete = model.ElementAtOrDefault(row);
                if (toDelete != null)
                {
                    if (DialogResult.OK == MessageBox.Show("Are you sure you want to Delete?", "Delete Teacher", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                    {
                        await _teacherService.RemoveTeacher(toDelete.Id);
                        await LoadData();
                        MessageBox.Show("Teacher Successfully Deleted!", "Delete Teacher", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error in Deleting Teacher: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
