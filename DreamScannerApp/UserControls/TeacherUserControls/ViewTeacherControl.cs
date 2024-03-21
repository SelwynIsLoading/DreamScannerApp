using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
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
            model = await _teacherService.GetTeachers();
            dgTeachers.Rows.Clear();
            foreach (var teacher in model)
            {
                dgTeachers.Rows.Add(new object[]
                {
                    $"{teacher.LastName}, {teacher.FirstName} {teacher.MiddleInitial}",
                    teacher.Subject,
                    teacher.Room,
                    teacher.TimeFrom.ToShortTimeString(),
                    teacher.TimeTo.ToShortTimeString(),
                    teacher.Gender
                });
            }
        }
    }
}
