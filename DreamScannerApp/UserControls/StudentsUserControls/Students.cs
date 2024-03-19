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
        public event EventHandler<string> OnSearch;
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            ViewStudents();
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
                    ViewStudentLogs();
                    break;
                case "View Students":
                    btnViewLogs.Text = "View Student Logs";
                    ViewStudents();
                    break;
            }
        }

        private void ViewStudents()
        {
            SetButtons(false);
            viewStudentsControl = new ViewStudentsControl(this);
            addUserControl(viewStudentsControl);
        }

        private void ViewStudentLogs()
        {
            SetButtons(true);
            ViewStudentLogsControl viewStudentLogs = new ViewStudentLogsControl();
            addUserControl(viewStudentLogs);
        }

        private void SetButtons(bool set)
        {
            cbFilter.Visible = set;
            dPicker.Visible = set;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            OnSearch?.Invoke(this, search);
        }
    }
}
