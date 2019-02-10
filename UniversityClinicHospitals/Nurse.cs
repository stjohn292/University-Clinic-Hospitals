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
    }
}
