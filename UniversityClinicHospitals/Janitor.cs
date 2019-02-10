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
            EmpSalary = 40000;
            this.IsSweeping = IsSweeping;
        }
    }
}
