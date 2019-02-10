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
            if (EmpBeenPaid == false)

            {
                Console.WriteLine("All employees have been paid.");
                EmpBeenPaid = true;
            }
            else
            {
                Console.WriteLine("You have already paid all Employees.");
            }
        }

        public void DisplayEmployeeInformation(List<Employee> employees)
        {
            string paid;
            if (EmpBeenPaid == true)
            { paid = "yes"; }
            else
            { paid = "no"; }

            Console.WriteLine("Name" + "Number" + "Paid");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(EmpName + " " + EmpNumber + " " + paid );
            }
        }
    }
}
