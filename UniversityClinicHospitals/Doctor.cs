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
    }
}
