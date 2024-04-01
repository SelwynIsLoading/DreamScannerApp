using DreamScannerApp.Interfaces;
using System;
using System.IO.Ports;
using System.Threading.Tasks;

namespace DreamScannerApp.Services
{
    public class ArduinoService : IArduinoService
    {
        private readonly string COM = Properties.Settings.Default.SerialPort;
        private readonly int baud = Properties.Settings.Default.BaudRate;
        private SerialPort serialPort;

        public ArduinoService()
        {
        }

        public async Task<bool> ConnectAsync()
        {
            try
            {
                serialPort = new SerialPort(COM, baud);
                serialPort.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to connect to Arduino.", ex);
            }
        }

        public async Task<bool> DisconnectAsync()
        {
            try
            {
                serialPort.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to disconnect from Arduino.", ex);
            }
        }

        public async Task SendCommandAsync(string command)
        {
            try
            {
                await ConnectAsync();
                serialPort.Write(command);
                await DisconnectAsync();
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                throw new Exception("Failed to send command to Arduino.", ex);
            }
        }

        public Task DoorCloseAsync()
        {
            return SendCommandAsync("0");
        }

        public Task DoorOpenAsync()
        {
            return SendCommandAsync("1");
        }

        public Task InvalidAsync()
        {
            return SendCommandAsync("2");
        }

        public async Task<IEnumerable<string>> GetAvailablePortsAsync()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                return ports;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve available ports.", ex);
            }
        }

        public async Task<IEnumerable<int>> GetAvailableBaudRatesAsync()
        {
            try
            {
                // Add commonly used baud rates
                List<int> baudRates = new List<int>
                {
                    9600,
                    19200,
                    38400,
                    57600,
                    115200
                    // Add more baud rates as needed
                };

                // Check if ports support additional baud rates
                string[] ports = SerialPort.GetPortNames();
                foreach (var port in ports)
                {
                    using (SerialPort serialPort = new SerialPort(port))
                    {
                        foreach (int baudRate in baudRates.ToArray())
                        {
                            serialPort.BaudRate = baudRate;
                            try
                            {
                                serialPort.Open();
                                serialPort.Close();
                            }
                            catch (Exception)
                            {
                                // Remove baud rate if not supported by port
                                baudRates.Remove(baudRate);
                            }
                        }
                    }
                }

                return baudRates;
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                throw new Exception("Failed to retrieve available baud rates.", ex);
            }
        }
    }
}
