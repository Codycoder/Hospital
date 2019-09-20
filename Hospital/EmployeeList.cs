using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class EmployeeList
    {
        Employee Pay = new Employee();
        List<Employee> AllEmployees = new List<Employee>();
        public void AddToList()
        {
            Console.WriteLine("If you would like to start: Yes");
            Console.WriteLine("If you want to exit enter: No");
            string enter = Console.ReadLine().ToLower();
            if (enter == "yes")
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
            foreach (Employee employee in AllEmployees)
            {
                    AllEmployees[0].EmployeePaid();
                    AllEmployees[1].EmployeePaid();
                    AllEmployees[2].EmployeePaid();
                    AllEmployees[3].EmployeePaid();
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
