using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DreamScannerApp.Handlers;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Models;
using DreamScannerApp.Models.Enums;
using DreamScannerApp.Properties;
using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using static System.Windows.Forms.AxHost;

namespace DreamScannerApp.UI
{
    public partial class AddTeacher : KryptonForm
    {
        private readonly ITeacherService _teacherService;
        private FingerEnrollment Enroller = new FingerEnrollment();
        private byte[]? fingerprintData;
        List<TeachersDTO> teachers { get; set; } = new List<TeachersDTO>();
        public AddTeacher()
        {
            _teacherService = Program.ServiceProvider.GetRequiredService<ITeacherService>();
            InitializeComponent();            
        }
        private void AddTeacher_Load(object sender, EventArgs e)
        {
            Enroller.OnTemplate += (template) =>
            {
                fingerprintData = template.Bytes;
            };
            Enroller.reportCallback += OnReportCallback;
            InitializeComboBox();
        }

        private void OnReportCallback(string message)
        {
            UpdateState(() =>
            {
                tbStatus.Text = message;
            });
        }

        public void UpdateState(Action action)
        {
            if (tbStatus.InvokeRequired)
            {
                tbStatus.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            switch (btnEnroll.Text)
            {
                case "Enroll Fingerprint >":
                    pbImage.Image = Resources.fingerprintGif;
                    Enroller.StartCapture();
                    btnEnroll.Text = "Done";
                    break;
                case "Done":
                    pbImage.Image = Resources.Humaaans___Study_Online;
                    Enroller.StopCapture();
                    btnEnroll.Text = "Enroll Fingerprint >";
                    EnrollTeacher();
                    break;
            }
        }

        private void InitializeComboBox()
        {
            pbImage.Image = Resources.Humaaans___Study_Online;
            cbGender.DataSource = Enum.GetValues(typeof(TeacherProperties.Gender));
            cbRoom.DataSource = Enum.GetValues(typeof(TeacherProperties.room));
            cbSection.DataSource = Enum.GetValues(typeof(TeacherProperties.Section));
        }

        private async void EnrollTeacher()
        {
            try
            {
                teachers.Add(new TeachersDTO
                {
                    FirstName = tbFname.Text,
                    LastName = tbLastName.Text,
                    MiddleInitial = tbMiddleInitial.Text,
                    Subject = tbSubject.Text,
                    Email = tbEmail.Text,
                    Room = (TeacherProperties.room)cbRoom.SelectedItem,
                    Gender = (TeacherProperties.Gender)cbGender.SelectedItem,
                    Section = (TeacherProperties.Section)cbSection.SelectedItem,
                    Fingerprint = fingerprintData,
                    TimeFrom = tFrom.Value.TimeOfDay,
                    TimeTo = tTo.Value.TimeOfDay
                });
                if (fingerprintData == null)
                {
                    MessageBox.Show("Please enroll fingerprint", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                await _teacherService.EnrollTeacher(teachers);
                MessageBox.Show("Teacher enrolled successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearFields()
        {
            tbFname.Text = "";
            tbLastName.Text = "";
            tbMiddleInitial.Text = "";
            tbEmail.Text = "";
            tbSubject.Text = "";
            tbStatus.Text = "";
            cbGender.SelectedIndex = -1;
            cbRoom.SelectedIndex = -1;
            cbRoom.SelectedIndex = -1;
            tFrom.Value = DateTime.Now;
            tTo.Value = DateTime.Now;
        }

    }
}
