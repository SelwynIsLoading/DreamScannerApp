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

namespace DreamScannerApp.UserControls.StudentsUserControls
{
    public partial class ViewStudentsControl : UserControl
    {
        public readonly IStudentService _studentService;
        public ViewStudentsControl(IStudentService studentService)
        {
            _studentService = studentService;
            InitializeComponent();
        }
        private void ViewStudentsControl_Load(object sender, EventArgs e)
        {            
            LoadData();
        }

        private void LoadData()
        {
            dgStudents.Rows.Clear();
            var students = _studentService.GetStudents();
            foreach (var student in students)
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

        private void dgStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 8)
            {
                var student = new StudentsDTO.StudentDetails
                {
                    StudentNumber = dgStudents.Rows[e.RowIndex].Cells[3].Value.ToString()
                };
                if(MessageBox.Show("Are you sure you want to delete?", "Remove Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (_studentService.DeleteStudent(student))
                    {
                        MessageBox.Show("Student Deleted!", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadData();
                    }
                }
            }
        }
    }
}
