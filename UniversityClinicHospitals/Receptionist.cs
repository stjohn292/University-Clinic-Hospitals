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
            EmpSalary = 45000;
            this.OnPhone = OnPhone;
        }

        public void DisplayInfo()
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
