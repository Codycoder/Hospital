using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class List
    {
        public void list()
        {
            List<Employee> AllEmployees = new List<Employee>();
            AllEmployees.Add(new Doctor());


            foreach (Employee employee in AllEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
