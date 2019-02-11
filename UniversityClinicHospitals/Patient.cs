using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Patient : Employee
    {
        public int BloodLevel { get; set; }
        public int HealthLevel { get; set; }

        public Patient()
        { BloodLevel = 20;
            HealthLevel = 10;
        }


    }
}
