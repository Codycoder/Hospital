using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
     public class Doctor : Employee
    {
        public string Specialty { get; set; }

        public Doctor() 
        {
            Name = "john";
            Specialty = "foot";
            NumberID = 001;
            Salary = 90000;
            IfPaid = false;
            Console.WriteLine(Name + " " + Specialty + " " + NumberID + " " + Salary + " " + IfPaid);
        }
    }
}
