using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamScannerApp.UserControls
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            StudentsUserControls.Students students = new StudentsUserControls.Students();
            addUserControl(students);
        }


        private void btnStudents_Click(object sender, EventArgs e)
        {
            btnActive.Width = btnStudents.Width;
            btnActive.Left = btnStudents.Left;

            StudentsUserControls.Students students = new StudentsUserControls.Students();
            addUserControl(students);
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            btnActive.Width = btnTeachers.Width;
            btnActive.Left = btnTeachers.Left;

            TeacherUserControls.Teachers teachers = new TeacherUserControls.Teachers();
            addUserControl(teachers);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            btnActive.Width = btnReports.Width;
            btnActive.Left = btnReports.Left;

            GeneralControl general = new GeneralControl();
            addUserControl(general);
        }

        private void btnController_Click(object sender, EventArgs e)
        {
            btnActive.Width = btnController.Width;
            btnActive.Left = btnController.Left;

            ControllerControl controller = new ControllerControl();
            addUserControl(controller);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            containerPnl.Controls.Clear();
            containerPnl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void containerPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
