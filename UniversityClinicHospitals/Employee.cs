using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public abstract class Employee
    {
        public string EmpName { get; set; }
        public int EmpNumber { get; set; }
        public double EmpSalary { get; set; }
        public bool EmpBeenPaid { get; set; }

        public Employee()
        {
            EmpBeenPaid = false;
        }
        /*public Employee(string EmpName, int EmpNumber)
        {
            this.EmpName = EmpName;
            this.EmpNumber = EmpNumber;

            EmpBeenPaid = false;
        }*/

        public virtual void DrawBlood(Patient patient)
        {
            Console.Clear();
            if (patient.BloodLevel >= 0)
            { Console.WriteLine(EmpName + " " + "has drawn blood from the patient," + " " + patient.PatientName + ".\n"); }

            else
            { Console.WriteLine("\t" + patient.PatientName + " " + "is dead."); };
                                       

        }

        //public abstract void PaySalary();
        public void PaySalary()
        {
            if (EmpBeenPaid == false)
            {
                Console.WriteLine("\t" + EmpName + " " + "has been paid" + "  $" + EmpSalary);
                EmpBeenPaid = true;
            }
            else
            { Console.WriteLine("\t" + EmpName + " " + "was already paid."); }
        }

        public abstract void DisplayInfo();
    }
}
