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
            
        }
        public override void EmployeeInfo()
        {
            Console.WriteLine("Doctor: " + Name + "\n" + "Specialty: " + Specialty + "\n" + "ID Number: " + NumberID + "\n" + "Salary: $" + Salary + "\n" + "If Paid: " + IfPaid + "\n");
        }
        public override void EmployeePaid()
        {

           IfPaid = true;
        }
    }
}