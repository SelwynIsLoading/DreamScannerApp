using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models.Enums
{
    public class Settings
    {
        public enum Minutes
        {
            minutes15 = 15,
            minutes20 = 20,
            minutes30 = 30,
            minutes45 = 45,
            minutes60 = 60
        }
        public enum LunchTime
        {
            minutes30 = 30,
            minutes45 = 45,
            minutes60 = 60,
            minutes75 = 75,
            minutes90 = 90
        }
        public enum RecessTime
        {
            minutes5 = 5,
            minutes10 = 10,
            minutes15 = 15,
            minutes20 = 20,
            minutes25 = 25
        }
    }
}
