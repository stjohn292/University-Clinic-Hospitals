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
    }
}
