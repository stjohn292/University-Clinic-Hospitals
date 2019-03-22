using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Nurse : Employee
    {
        public int NumAssignedPatients { get; set; }

        public Nurse(string EmpName, int EmpNumber, int NumAssignedPatients)
        {
            EmpSalary = 50000;
            this.NumAssignedPatients = NumAssignedPatients;
        }

        public override void PaySalary()
        { Console.WriteLine(EmpName + " " + "has been paid" + "  $" + EmpSalary); }

        public override void DrawBlood(Patient John)
        {
            base.DrawBlood(John);
            John.BloodLevel -= 20;
            John.HealthLevel -= 10;

            Console.Clear();
            if (John.BloodLevel >= 0)
            {
                Console.WriteLine("You killed the patient.");
            }
            else
            {
                Console.WriteLine("The patient's blood level is: " + John.BloodLevel + "\n\t");
                Console.WriteLine("The patient's health level is: " + John.HealthLevel);
            };
        }
        public void DisplayInfo()
        {
            {
                string paid;
                if (EmpBeenPaid == true)
                { paid = "yes"; }
                else
                { paid = "no"; }

                Console.WriteLine(EmpName + " " + EmpNumber + " " + NumAssignedPatients + " " + paid);
                }
            }
    }
}
