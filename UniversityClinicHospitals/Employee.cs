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
        public Employee(string EmpName, int EmpNumber)
        {
            this.EmpName = EmpName;
            this.EmpNumber = EmpNumber;
            
            EmpBeenPaid = false;
        }

        public void PaySalary()
        {
            EmpBeenPaid = true;
        }

    }
}
