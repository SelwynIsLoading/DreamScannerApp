using DreamScannerApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamScannerApp.UserControls.StudentsUserControls
{
    public partial class Students : UserControl
    {
        ViewStudentsControl viewStudentsControl;
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            viewStudentsControl = new ViewStudentsControl();
            addUserControl(viewStudentsControl);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            switch (btnViewLogs.Text)
            {
                case "View Student Logs":
                    btnViewLogs.Text = "View Students";
                    ViewStudentLogsControl viewStudentLogs = new ViewStudentLogsControl();
                    addUserControl(viewStudentLogs);
                    break;
                case "View Students":
                    btnViewLogs.Text = "View Student Logs";
                    viewStudentsControl = new ViewStudentsControl();
                    addUserControl(viewStudentsControl);
                    break;
            }
        }
    }
}
