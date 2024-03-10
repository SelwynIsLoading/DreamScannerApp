using DPFP.Verification;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Enums;
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
    public partial class VerifyControl : UserControl
    {
        private Services.Verification _verificator;
        public VerifyControl(Services.Verification verification)
        {
            InitializeComponent();
            _verificator = verification;
            _verificator.studentDataCallback += OnStudentDataReceived;
        }

        private void OnStudentDataReceived(List<StudentsDTO.StudentLog> students)
        {
            if (students != null)
            {
                tbName.Text = students[0].FirstName + " " + students[0].LastName;
                //tbSection.Text = students[5].Section.ToString();
                tbSection.Text = Enum.Parse<StudentProperties.Gender>(students[0].section.ToString()).ToString();
                tbInOut.Text = students[10].IsIn ? "In" : "Out";
            }
        }

    }
}
