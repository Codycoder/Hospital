﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class MainMenu
    {
        EmployeeList Lists = new EmployeeList();
        Patient Levels = new Patient();
        public void pay()
        {
            Lists.EmployeePaid();

        }
        public void Start()
        {
            Lists.AddToList();
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("MainMenu");
            Console.WriteLine("_______");
            Console.WriteLine("To pay enter: 1");
            Console.WriteLine("View blood level: 2");
            Console.WriteLine("To take blood enter: 3");
            Console.WriteLine("View health level: 4");
            Console.WriteLine("To care for Patient enter: 5");
            Console.WriteLine("Show List enter: 6");
            Console.WriteLine("To exit enter: 7");
            string HospitalAdmin = Console.ReadLine();
            switch (HospitalAdmin)
            {
                case "1":
                    {
                        Console.WriteLine("You already paid employees");
                        Console.ReadKey();

                    }
                    break;
                case "2":
                    Console.WriteLine("Patient blood level is: " + Levels.Bloodlevel);
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Do you want doctor or nurse to draw blood? Enter 1 for Doctor or 2 for Nurse");
                    string DoctorOrNurse = Console.ReadLine().ToLower();
                    if (DoctorOrNurse == "1")
                    {
                        Levels.Bloodlevel -= 1;
                        Levels.Health -= 1;
                        Console.WriteLine("You have drawn blood!");
                        Console.ReadKey();
                    }
                    else if (DoctorOrNurse == "2")
                    {
                        Levels.Bloodlevel -= 2;
                        Levels.Health -= 2;
                        Console.WriteLine("You have drawn blood!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Levels.Health--;
                        Console.WriteLine("You are not authorized for this action.");
                        Console.ReadKey();
                    }
                    break;
                case "4":
                    Levels.Health--;
                    Console.WriteLine("Patient health is: " + Levels.Health);
                    Console.ReadKey();
                    break;
                case "5":
                    Console.WriteLine("Do you want doctor or nurse to care for your patient? Enter 1 for Doctor or 2 for Nurse");
                    string DoctorOrNurse2 = Console.ReadLine().ToLower();
                    if (DoctorOrNurse2 == "1")
                    {
                        Levels.Bloodlevel += 2;
                        Levels.Health += 2;
                        Console.WriteLine("You have cared for your Patient!");
                        Console.ReadKey();
                    }
                    else if (DoctorOrNurse2 == "2")
                    {
                        Levels.Bloodlevel += 1;
                        Levels.Health += 1;
                        Console.WriteLine("You have cared for your Patient!");
                        Console.ReadKey();

                    }
                    else
                    {
                        Levels.Health--;
                        Console.WriteLine("You are not authorized for this action.");
                        Console.ReadKey();
                    }
                    break;
                case "6":
                    Levels.Health--;
                    Lists.PrintList();
                    Console.ReadKey();
                    break;
                case "7":
                    {
                        Console.WriteLine("Have a great day!");
                        Environment.Exit(0);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
