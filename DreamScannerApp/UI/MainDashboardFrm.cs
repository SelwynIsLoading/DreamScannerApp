﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using DreamScannerApp.UserControls;
using DreamScannerApp.Interfaces;
using DreamScannerApp.Handlers;
using DreamScannerApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DreamScannerApp.UI
{
    public partial class MainDashboardFrm : KryptonForm
    {        
        public MainDashboardFrm()
        {
            InitializeComponent();
        }

        private void MainDashboardFrm_Load(object sender, EventArgs e)
        {
            timer.Start();
            MainControl main = new MainControl();
            addUserControl(main);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            sideActive.Top = btnMain.Top;
            sideActive.Height = btnMain.Height;

            MainControl main = new MainControl();
            addUserControl(main);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            sideActive.Top = btnVerify.Top;
            sideActive.Height = btnVerify.Height;

            Services.Verification verification = new Services.Verification(Program.ServiceProvider.GetRequiredService<IStudentLogService>());
            VerifyControl verify = new VerifyControl(verification);
            addUserControl(verify);
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            sideActive.Top = btnEnroll.Top;
            sideActive.Height = btnEnroll.Height;

            Result _result = new Result();
            EnrollControl enroll = new EnrollControl(Program.ServiceProvider.GetRequiredService<StudentService>(), _result);
            addUserControl(enroll);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            sideActive.Top = btnSettings.Top;
            sideActive.Height = btnSettings.Height;

            SettingsControl settings = new SettingsControl();
            addUserControl(settings);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tbTime.Text = DateTime.Now.ToLongTimeString().ToUpper();
            tbDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

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
