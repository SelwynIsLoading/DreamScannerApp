using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
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

namespace DreamScannerApp.UserControls.StudentsUserControls
{
    public partial class ViewStudentLogsControl : UserControl
    {
        private readonly IStudentLogService _studentLogService;
        List<StudentsDTO.StudentLog> model = new List<StudentsDTO.StudentLog>();
        private Students _studentControl;
        public ViewStudentLogsControl(Students studentControl)
        {
            _studentControl = studentControl;
            _studentLogService = Program.ServiceProvider.GetRequiredService<IStudentLogService>();
            if(_studentControl != null)
            {
                _studentControl.OnSearch += OnFilter;
            }
            InitializeComponent();
        }
        private void ViewStudentLogsControl_Load(object sender, EventArgs e)
        {
            model = _studentLogService.GetStudentLogInfo();
            LoadData();
        }
        private void LoadData()
        {
            dgStudents.Rows.Clear();
            foreach (var student in model)
            {
                string timeOut = student.TimeOut == TimeSpan.Zero ? "" : $"{Convert.ToDateTime(student.TimeOut.ToString()).ToShortTimeString()}";
                dgStudents.Rows.Add(new object[]
                {
                    $"{student.LastName}, {student.FirstName} {student.MiddleInitial}",
                    student.StudentNumber,
                    student.section,
                    student.room,
                    $"{student.Date.ToShortDateString()}",
                    $"{Convert.ToDateTime(student.TimeIn.ToString()).ToShortTimeString()}",
                    timeOut,
                    student.AttendanceStatus
                });
            }
        }

        private void OnFilter(object sender, StudentLogFilterDTO e)
        {
            model = _studentLogService.FilterStudentLog(e);
            LoadData();
        }   

    }
}
