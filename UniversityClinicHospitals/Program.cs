using System;
using System.Collections.Generic;

namespace UniversityClinicHospitals
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            bool running = true;

            List<Employee> employees = new List<Employee>();

            Doctor Phil = new Doctor("Phil", 111, "Brain");
            Nurse Jackie = new Nurse("Jackie", 112, 50);
            Receptionist Cheryl = new Receptionist("Cheryl", 112, true);
            Janitor Will = new Janitor("Will", 113, false);
            Patient patient = new Patient("John");


            employees.Add(Phil);
            employees.Add(Jackie);
            employees.Add(Cheryl);
            employees.Add(Will);


            do
            {
                Console.WriteLine("University Clinic Hospitals\n\n\t" +

                    "1. Employee Information\n\t" +
                    "2. Issue Paycheck\n\t" +
                    "3. Have Nurse or Doctor Draw Blood");

                string userInput = Console.ReadLine();
                
                switch (userInput)

                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tName:" + "\tI.D.:" + "\tAdditional Info:" + "\tPayment Received?\n\t");

                            Phil.DisplayInfo();
                            Jackie.DisplayInfo();
                            Cheryl.DisplayInfo();
                            Will.DisplayInfo();

                            Console.WriteLine("\n\tPress any key to return to the main menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "2":

                        {
                            Console.Clear();
                            Console.WriteLine("Payment Information:\n");
                            foreach (Employee employee in employees)
                            {
                                employee.PaySalary();
                            }
                            Console.WriteLine("\n\tPress any key to return to the main menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Console.WriteLine("\nAll employees have been paid! Press any key to return to the main menu.");
                        Console.ReadKey();
                        break;

                    case "3":
                        {
                            Console.Clear();
                            patient.DisplayHealth();
                            Console.WriteLine("\n\t" +
                                                "1. Have Nurse Draw Blood\n\t" +
                                                "2. Have Doctor Draw Blood");
                            string BloodInput = Console.ReadLine();
                            switch (BloodInput)
                            {
                                case "1":
                                    Jackie.DrawBlood(patient);
                                    patient.DisplayHealth();
                                    Console.WriteLine("\n\tPress any key to return to the main menu.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case "2":
                                    Phil.DrawBlood(patient);
                                    patient.DisplayHealth();
                                    Console.WriteLine("\n\tPress any key to return to the main menu.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Please choose an option from the menu.");
                            break;
                            }

                        break;
                        }
                        

                    default:

                        Console.WriteLine("Please choose an option from the menu.");
                        break;
                }
            } while (running); 


            

            

        }
    }
}
