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

        public Patient(string PatientName)

        {   BloodLevel = 100;
            HealthLevel = 100;
            this.PatientName = PatientName;
        }

        public Patient()
        {
            BloodLevel = 100;
            HealthLevel = 100;
            this.PatientName = PatientName;
        }

        public void DisplayHealth()
        {   
            if (BloodLevel >= 0)
            {   
                Console.WriteLine("\t" + PatientName + "'s blood level is:" + " " + HealthLevel + "\n\t" +
                PatientName + "'s health level is:" + " " + BloodLevel);
            }
            else
            { Console.WriteLine("\n\t" + PatientName + " " + "is dead."); }
        }


    }
}
