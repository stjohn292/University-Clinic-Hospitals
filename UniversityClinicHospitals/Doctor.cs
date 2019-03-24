using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Doctor : Employee
    {
        public string SpecialtyArea { get; set; }
        
        public Doctor(string EmpName, int EmpNumber, string SpecialtyArea)
        {
            this.EmpName = EmpName;
            this.EmpNumber = EmpNumber;
            EmpSalary = 9000;
            this.SpecialtyArea = SpecialtyArea;
        }

        public override void DrawBlood(Patient patient)
        {
            base.DrawBlood(patient);
            patient.BloodLevel -= 100;
            patient.HealthLevel -= 100;
        }

        /*public override void PaySalary()
        {
            if (EmpBeenPaid == false)
            { Console.WriteLine(EmpName + " " + "has been paid" + "  $" + EmpSalary);
                EmpBeenPaid = true;
            }
            else
            { Console.WriteLine(EmpName + "was already paid."); }
        }*/

        public override void DisplayInfo()
        {
           string paid;
           if (EmpBeenPaid == true)
           { paid = "yes"; }
           else
           { paid = "no"; }
            
           Console.WriteLine(EmpName + " " + EmpNumber + " " + SpecialtyArea + " " + paid);
        }
            
    }
}
