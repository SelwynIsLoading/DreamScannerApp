using DreamScannerApp.Interfaces;
using DreamScannerApp.Models.Entities;
using DreamScannerApp.Services;
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
    public partial class ViewTeacherLogControl : UserControl
    {
        private readonly ITeacherLogService _teacherLogService;
        List<TeacherLogsEntity> model = new List<TeacherLogsEntity>();
        public ViewTeacherLogControl()
        {
            InitializeComponent();
            _teacherLogService = Program.ServiceProvider.GetRequiredService<ITeacherLogService>();
        }

        private async void ViewTeacherLogsControl_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                model = await _teacherLogService.GetTeacherLogs();
                dgTeachers.Rows.Clear();
                foreach (var teacher in model)
                {
                    int rowIndex = dgTeachers.Rows.Add(new object[]
                    {
                        $"{teacher.LastName}, {teacher.FirstName} {teacher.MiddleInitial}",
                        teacher.Subject,
                        teacher.Room,
                        teacher.Section,
                        new DateTime(teacher.TimeIn.Ticks).ToShortTimeString(),
                        teacher.TimeOut == TimeSpan.Zero ? "" : new DateTime(teacher.TimeOut.Ticks).ToShortTimeString(),
                        teacher.AttendanceStatus
                    });
                    dgTeachers.Rows[rowIndex].Tag = teacher.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
