using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Janitor : Employee
    {
        public bool IsSweeping { get; set; }

        public Janitor(string EmpName, int EmpNumber, bool IsSweeping)
        {
            this.EmpName = EmpName;
            this.EmpNumber = EmpNumber;
            EmpSalary = 40000;
            this.IsSweeping = IsSweeping;
        }

        public Janitor()
        {
            this.EmpName = EmpName;
            this.EmpNumber = EmpNumber;
            EmpSalary = 40000;
            this.IsSweeping = IsSweeping;
        }

        /*public override void PaySalary()
        { Console.WriteLine(EmpName + " " + "has been paid" + "  $" + EmpSalary); }*/

        public override void DisplayInfo()
        {
            {
                string paid;
                if (EmpBeenPaid == true)
                { paid = "yes"; }
                else
                { paid = "no"; }

                string sweeping;
                if (IsSweeping == true)
                { sweeping = "Sweeping"; }
                else
                { sweeping = "Not Sweeping"; }

                Console.WriteLine("\t" + EmpName + "\t" + EmpNumber + "\t" + sweeping + "\t\t" + paid);
                }
            }
    }
}
