using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScannerApp.Models.Enums
{
    public class StudentProperties
    {
        public enum Gender
        {
            Male = 1,
            Female = 2,
            None = 3
        }

        public enum Attendance
        {
            Present = 1,
            Absent = 2,
            Unknown = 3
        }

        public enum Room
        {
            M201 = 1,
            M203 = 2,
            Unknown = 3
        }

        public enum Section
        {
            Watt = 1,
            Faraday = 2,
            None = 3
        }
    }
}
