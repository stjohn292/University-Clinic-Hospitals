using System;
using System.Collections.Generic;

namespace UniversityClinicHospitals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empoyees = new List<Employee>();
            {
                new Doctor("Phil", 111, "Brain");
                new Nurse("Jackie", 112, 50);
                new Receptionist("Cheryl/Carol/Crystal", 112, true);
                new Janitor("Will", 113, false);
            }
            Console.WriteLine("/tUniversity Clinic Hostpitals/n/t" +
                "1. Employee Information/n/t" +
                "2. Issue Paycheck/n/t" +
                "3. Assign Tasks");

            string userInput = Console.ReadLine();
            int userInputAsInt = Convert.ToInt32(userInput);


            

        }
    }
}
