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
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        { 
            IStudentService studentService = Program.ServiceProvider.GetRequiredService<IStudentService>();
            ViewStudentsControl viewStudentsControl = new ViewStudentsControl(studentService);
            addUserControl(viewStudentsControl);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
