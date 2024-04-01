using DreamScannerApp.Interfaces;
using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class ControllerControl : UserControl
    {
        private readonly IArduinoService _arduinoService;
        public ControllerControl()
        {
            InitializeComponent();
            _arduinoService = Program.ServiceProvider.GetRequiredService<IArduinoService>();
        }


        private async void ControllerControl_Load(object sender, EventArgs e)
        {
            try
            {
                var availablePorts = await _arduinoService.GetAvailablePortsAsync();
                LoadComboBox(cbPorts, availablePorts);
                var availableBaudRates = await _arduinoService.GetAvailableBaudRatesAsync();
                LoadComboBox(cbBaudRate, availableBaudRates);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading available ports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SerialPort = cbPorts.SelectedItem?.ToString();
            if (int.TryParse(cbBaudRate.SelectedItem?.ToString(), out int baudRate))
            {
                Properties.Settings.Default.BaudRate = baudRate;
            }

            Properties.Settings.Default.Save();

            MessageBox.Show("Settings saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadComboBox<T>(KryptonComboBox comboBox, IEnumerable<T> items)
        {
            comboBox.Items.Clear();
            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
