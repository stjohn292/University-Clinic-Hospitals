using System;
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
            Patient John = new Patient();

            employees.Add(Phil);
            employees.Add(Jackie);
            employees.Add(Cheryl);
            employees.Add(Will);
            

            int userInputAsInt = 0;
            do
            {
                Console.WriteLine("/tUniversity Clinic Hostpitals/n/t" +
                    "1. Employee Information/n/t" +
                    "2. Issue Paycheck/n/t" +
                    "3. Have Nurse or Doctor Draw Blood");

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
                        {
                            Console.WriteLine("Name:" + "I.D." + "Additional Info");
                            Phil.DisplayInfo();
                            Jackie.DisplayInfo();
                            Cheryl.DisplayInfo();
                            Will.DisplayInfo();
                        }
                        break;
                    case 2:
                        foreach (Employee employee in employees)
                        {
                            employee.PaySalary();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("/t1. Have Nurse Draw Blood/n/t" +
                            "2. Have Doctor Draw Blood");
                        string BloodChoice = Console.ReadLine();
                        int BloodChoiceAsInt = Convert.ToInt32(BloodChoice);
                        if (BloodChoiceAsInt == 1)
                        { Jackie.DrawBlood(John); }
                        if (BloodChoiceAsInt == 2)
                        { Phil.DrawBlood(John); }
                        else
                        { Console.WriteLine("Please choose 1 or 2.");
                        }


                        break;
                    default:
                        Console.WriteLine("Please choose an option from the menu.");
                        break;
                }
            } while (userInputAsInt < 1 || userInputAsInt > 3); 

            

            

        }
    }
}
