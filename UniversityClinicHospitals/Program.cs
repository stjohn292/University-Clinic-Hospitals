using System;
using System.Collections.Generic;

namespace UniversityClinicHospitals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            {
                new Doctor("Phil", 111, "Brain");
                new Nurse("Jackie", 112, 50);
                new Receptionist("Cheryl/Carol/Crystal", 112, true);
                new Janitor("Will", 113, false);
            }

            int userInputAsInt = 0;
            do
            {
                Console.WriteLine("/tUniversity Clinic Hostpitals/n/t" +
                    "1. Employee Information/n/t" +
                    "2. Issue Paycheck/n/t" +
                    "3. Assign Tasks");

                string userInput = Console.ReadLine();
                if (char.IsNumber(userInput[0]) && userInput.Length == 1)
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                }
                else
                {
                    userInputAsInt = -1;
                }
                switch (userInputAsInt)
                {
                    case 1:
                        Employee.DisplayEmployeeInformation();
                        break;
                    case 2:
                        PayAllEmployees();
                        break;
                    case 3:
                        AssignTasks();
                        break;
                    default:
                        Console.WriteLine("Please choose an option from the menuu.");
                        break;
                }
            } while (userInputAsInt < 1 || userInputAsInt > 3); 

            

            

        }
    }
}
