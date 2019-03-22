﻿using System;
using System.Collections.Generic;

namespace UniversityClinicHospitals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            
            Doctor Phil = new Doctor("Phil", 111, "Brain");
            Nurse Jackie = new Nurse("Jackie", 112, 50);
            Receptionist Cheryl = new Receptionist("Cheryl/Carol/Crystal", 112, true);
            Janitor Will = new Janitor("Will", 113, false);
            Patient John = new Patient("John");

            employees.Add(Phil);
            employees.Add(Jackie);
            employees.Add(Cheryl);
            employees.Add(Will);

            bool running = true;
            int userInputAsInt = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\tUniversity Clinic Hostpitals\n\n\t" +
                    "1. Employee Information\n\t" +
                    "2. Issue Paycheck\n\t" +
                    "3. Have Nurse or Doctor Draw Blood");

                string userInput = Console.ReadLine();
                userInputAsInt = Convert.ToInt32(userInput);

                switch (userInputAsInt)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Name:" + "I.D." + "Additional Info");

                            Phil.DisplayInfo();
                            Jackie.DisplayInfo();
                            Cheryl.DisplayInfo();
                            Will.DisplayInfo();

                            Console.WriteLine("Press any key to return to the main menu!");


                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        foreach (Employee employee in employees)
                        {
                            employee.PaySalary();
                        }
                        Console.WriteLine("\nAll employees have been paid! Press any key to return to the main menu.");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\t1. Have Nurse Draw Blood\n\t" +
                            "2. Have Doctor Draw Blood");

                        string BloodChoice = Console.ReadLine();
                        int BloodChoiceAsInt = Convert.ToInt32(BloodChoice);

                        if (BloodChoiceAsInt == 1)
                        { Jackie.DrawBlood(John);

                        }
                        if (BloodChoiceAsInt == 2)
                        { Phil.DrawBlood(John); }
                        else
                        { Console.WriteLine("Please choose 1 or 2.");
                        }
                        Console.Clear();
                        if (John.BloodLevel >= 0)
                        {
                            Console.WriteLine("You killed the patient.");
                        }
                        else
                        {
                            Console.WriteLine("The patient's blood level is: " + John.BloodLevel + "\n\t");
                            Console.WriteLine("The patient's health level is: " + John.HealthLevel);
                        };
                        break;
                    default:

                        Console.WriteLine("Please choose an option from the menu.");
                        break;
                }
            } while (running);

            

            

        }
    }
}
