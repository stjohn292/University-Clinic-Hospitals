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
            EmpSalary = 9000;
            this.SpecialtyArea = SpecialtyArea;
        }

        public override void DrawBlood(Patient John)
        {
            base.DrawBlood(John);
            John.BloodLevel = -10;
        }

        public override void PaySalary()
        { Console.WriteLine(EmpName + " " + "has been paid" + "  $" + EmpSalary); }

        public void DisplayInfo()
        {
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
}
