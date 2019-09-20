using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class EmployeeList
    {
        public void list()
        {

            List<Employee> AllEmployees = new List<Employee>();
            AllEmployees.Add(new Doctor());
            AllEmployees.Add(new Nurse());
            AllEmployees.Add(new Janitor());
            AllEmployees.Add(new Receptionist());



            foreach (Employee employee in AllEmployees)
            {
                employee.EmployeeInfo();
            }
        }
    }
}
