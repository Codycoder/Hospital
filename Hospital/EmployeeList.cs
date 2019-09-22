using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class EmployeeList
    {
        Patient Levels = new Patient();
        Employee Pay = new Employee();
        List<Employee> AllEmployees = new List<Employee>();

        public void AddToList()
        {
            Console.WriteLine("If you would like to start: Yes");
            Console.WriteLine("If you want to exit enter: No");
            string enter = Console.ReadLine().ToLower();
            if (enter == "yes" || enter == "y")
            {
                Console.Clear();
                AllEmployees.Add(new Doctor());
                AllEmployees.Add(new Nurse());
                AllEmployees.Add(new Janitor());
                AllEmployees.Add(new Receptionist());
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public void EmployeePaid()
        {
            Levels.Health--;
            Console.WriteLine("Press 1 to pay employees or press 2 to not pay");
            string PayEmployees = Console.ReadLine();
            if (PayEmployees == "1")
            {
                AllEmployees[0].EmployeePaid();
                AllEmployees[1].EmployeePaid();
                AllEmployees[2].EmployeePaid();
                AllEmployees[3].EmployeePaid();

                Console.WriteLine("You have paid your employees");
                Console.ReadKey();
            }
            else if (PayEmployees == "2")
            {
                Console.WriteLine("You have not paid employees");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You already paid employees");
            }

        }
        public void PrintList()
        {
            foreach (Employee employee in AllEmployees)
            {
                employee.EmployeeInfo();
            }
        }
    }
}
