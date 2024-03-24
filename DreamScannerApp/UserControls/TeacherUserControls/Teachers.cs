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
            ViewTeacherControl viewTeacher = new ViewTeacherControl();
            addUserControl(viewTeacher);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher(new Handlers.FingerEnrollment(new Services.Result()));
            addTeacher.ShowDialog();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            ViewTeacherLogsControl viewLogs = new ViewTeacherLogsControl();
            addUserControl(viewLogs);

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            containerPnl.Controls.Clear();
            containerPnl.Controls.Add(userControl);
            userControl.BringToFront();
        }

    }
}
