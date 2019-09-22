using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class PayEmployees
    {
        EmployeeList Lists = new EmployeeList();
        Patient Levels = new Patient();
              public void EmployeesPaid()
        { 
        

            Levels.Health--;
            Console.WriteLine("Press 1 to pay employees or press 2 to not pay");
            string PayEmployees = Console.ReadLine();
            if (PayEmployees == "1")
            {
                Lists.EmployeePaid();
                Console.Clear();
                Console.WriteLine("You paid your employees");
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
        
     
    }  
}
