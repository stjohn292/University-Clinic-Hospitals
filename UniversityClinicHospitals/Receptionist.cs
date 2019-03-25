using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospitals
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }

        public Receptionist(string EmpName, int EmpNumber, bool OnPhone)
        {
            this.EmpName = EmpName;
            this.EmpNumber = EmpNumber;
            EmpSalary = 45000;
            this.OnPhone = OnPhone;
        }

        public Receptionist()
        {
            this.EmpName = EmpName;
            this.EmpNumber = EmpNumber;
            EmpSalary = 45000;
            this.OnPhone = OnPhone;
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

                string phones;
                if (OnPhone == true)
                { phones = "On Phones"; }
                else
                {phones = "Not On Phones";}

                Console.WriteLine(EmpName + " " + EmpNumber + " " + phones + " " + paid);
                }
            }
    }
}
