using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models.Enums
{
    public class TeacherProperties
    {
        public enum room
        {
            None = 0,
            M201 = 1,
            M203 = 2
        }
        public enum Gender
        {
            Male = 0,
            Female = 1,
            None = 3
        }
        public enum Section
        {
            Watt = 0,
            Faraday = 1,
            None = 3
        }
    }
}
