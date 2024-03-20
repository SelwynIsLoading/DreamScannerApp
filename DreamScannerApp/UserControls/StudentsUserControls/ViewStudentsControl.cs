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
using DreamScannerApp.Services;
using DreamScannerApp.UI;
using Microsoft.Extensions.DependencyInjection;

namespace DreamScannerApp.UserControls.StudentsUserControls
{
    public partial class ViewStudentsControl : UserControl
    {
        public readonly IStudentService _studentService;
        private List<StudentsDTO.StudentDetails> _students;
        private int pageSize = 10;
        private int currentPage = 1;
        private Students _studentControl;
        public ViewStudentsControl(Students students)
        {
            _studentService = Program.ServiceProvider.GetRequiredService<IStudentService>();
            InitializeComponent();
            _studentControl = students;
            _students = _studentService.GetStudents();
            _studentControl.OnSearch += (sender, StudentLogFilterDTO) =>
            {
                _students = _studentService.FilterStudents(StudentLogFilterDTO.Filter);
                LoadData();
            };
        }
        private void ViewStudentsControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgStudents.Rows.Clear();
            try
            {
                _students = _students.OrderBy(s => s.LastName).ToList();
                int startIndex = (currentPage - 1) * pageSize;
                int endIndex = Math.Min(startIndex + pageSize, _students.Count);
                lblPage.Text = $"Page {currentPage} of {Math.Ceiling((double)_students.Count / pageSize)}";
                foreach (var student in _students)
                {
                    dgStudents.Rows.Add(new object[]
                    {
                        student.LastName,
                        student.FirstName,
                        student.MiddleInitial,
                        student.StudentNumber,
                        student.Section,
                        student.Room,
                        student.Gender
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // for Deleting student
            if (e.ColumnIndex == 8)
            {
                DeleteStudent(e.RowIndex);
            }
            // For Editing Student infor
            if (e.ColumnIndex == 7)
            {
                EditStudent(e.RowIndex);
            }
        }

        private void DeleteStudent(int rowIndex)
        {
            var studentNumber = dgStudents.Rows[rowIndex].Cells[3].Value?.ToString();
            if (string.IsNullOrEmpty(studentNumber))
                return;

            if (MessageBox.Show("Are you sure you want to delete?", "Remove Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (_studentService.DeleteStudent(studentNumber))
                    {
                        MessageBox.Show("Student Deleted!", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete student!", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditStudent(int rowIndex)
        {
            var selectedStudent = _students.ElementAtOrDefault(rowIndex);
            if (selectedStudent == null)
                return;

            var editStudentFrm = new EditStudentFrm(selectedStudent);
            editStudentFrm.FormClosed += (sender, args) =>
            {
                if (editStudentFrm.DialogResult == DialogResult.OK)
                {
                    LoadData();
                }
            };
            editStudentFrm.ShowDialog();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)dgStudents.Rows.Count / pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }
    }
}
