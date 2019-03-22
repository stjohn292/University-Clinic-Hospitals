using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Patient
    {   
        public string PatientName { get; set; }
        public int BloodLevel { get; set; }
        public int HealthLevel { get; set; }
        public bool Alive { get; set; }

        public Patient(string PatientName)
        { BloodLevel = 100;
            HealthLevel = 100;
        }


    }
}
