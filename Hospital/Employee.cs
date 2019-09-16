using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Employee
    {
        public string Name { get; set; }
        public int NumberID { get; set; }
        public int Salary { get; set; }
        public bool IfPaid { get; set; }
        
        public void Doctor() 
        {
            Name = "john";
            NumberID = 001;
            Salary = 90000;
            IfPaid = false;
        }
        public void Nurse()
        {
            Name = "mary";
            NumberID = 002;
            Salary = 50000;
            IfPaid = false;
        }
    }
}
