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
    public partial class GeneralControl : UserControl
    {
        public GeneralControl()
        {
            InitializeComponent();
        }

        private void GeneralControl_Load(object sender, EventArgs e)
        {
            cbBreakTime.DataSource = Enum.GetValues(typeof(DreamScannerApp.Models.Enums.Settings.Minutes));
            cbLunchTime.DataSource = Enum.GetValues(typeof(DreamScannerApp.Models.Enums.Settings.LunchTime));
            cbRecess.DataSource = Enum.GetValues(typeof(DreamScannerApp.Models.Enums.Settings.RecessTime));
            LoadData();
        }

        private void LoadData()
        {
            cbBreakTime.SelectedItem = (Models.Enums.Settings.Minutes)Properties.Settings.Default.breakMinutes.TotalMinutes;
            cbLunchTime.SelectedItem = (Models.Enums.Settings.LunchTime)Properties.Settings.Default.lunchMinutes.TotalMinutes;
            cbRecess.SelectedItem = (Models.Enums.Settings.RecessTime)Properties.Settings.Default.recessMinutes.TotalMinutes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbBreakTime.SelectedIndex != -1)
            {
                Properties.Settings.Default.breakMinutes = ConvertEnumToIntToTimeSpan((DreamScannerApp.Models.Enums.Settings.Minutes)cbBreakTime.SelectedItem);
            }

            if (cbLunchTime.SelectedIndex != -1)
            {
                Properties.Settings.Default.lunchMinutes = ConvertEnumToIntToTimeSpan((DreamScannerApp.Models.Enums.Settings.LunchTime)cbLunchTime.SelectedItem);
            }

            if (cbRecess.SelectedIndex != -1)
            {
                Properties.Settings.Default.recessMinutes = ConvertEnumToIntToTimeSpan((DreamScannerApp.Models.Enums.Settings.RecessTime)cbRecess.SelectedItem);
            }

            Properties.Settings.Default.Save();
            MessageBox.Show("Settings saved!");
        }

        private TimeSpan ConvertEnumToIntToTimeSpan(DreamScannerApp.Models.Enums.Settings.Minutes timeInterval)
        {
            int minutes = (int)timeInterval;
            return TimeSpan.FromMinutes(minutes);
        }

        private TimeSpan ConvertEnumToIntToTimeSpan(DreamScannerApp.Models.Enums.Settings.LunchTime timeInterval)
        {
            int minutes = (int)timeInterval;
            return TimeSpan.FromMinutes(minutes);
        }

        private TimeSpan ConvertEnumToIntToTimeSpan(DreamScannerApp.Models.Enums.Settings.RecessTime timeInterval)
        {
            int minutes = (int)timeInterval;
            return TimeSpan.FromMinutes(minutes);
        }
    }
}
