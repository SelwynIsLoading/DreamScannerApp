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

namespace DreamScannerApp.UserControls.TeacherUserControls
{
    public partial class Teachers : UserControl
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            ViewTeachers();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher(new Handlers.FingerEnrollment());
            addTeacher.ShowDialog();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            switch (btnViewLogs.Text)
            {
                case "View Teacher Logs":
                    btnViewLogs.Text = "View Teachers";
                    ViewLogs();
                    break;
                case "View Teachers":
                    btnViewLogs.Text = "View Teacher Logs";
                    ViewTeachers();
                    break;
            }

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            containerPnl.Controls.Clear();
            containerPnl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ViewLogs()
        {
            ViewTeacherLogControl viewLogs = new ViewTeacherLogControl();
            addUserControl(viewLogs);
        }

        private void ViewTeachers()
        {
            ViewTeacherControl viewTeacher = new ViewTeacherControl();
            addUserControl(viewTeacher);
        }

    }
}
