using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Interfaces
{
    public interface IArduinoService
    {
        public Task<bool> ConnectAsync();
        public Task<bool> DisconnectAsync();
        public Task SendCommandAsync(string command);
        public Task DoorCloseAsync();
        public Task DoorOpenAsync();
        public Task InvalidAsync();
        public Task<IEnumerable<string>> GetAvailablePortsAsync();
        public Task<IEnumerable<int>> GetAvailableBaudRatesAsync();
    }
}
