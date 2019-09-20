using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Janitor : Employee
    {
        public bool SweepingOrNot { get; set; }
        public Janitor()
        {
            Name = "george";
            SweepingOrNot = false;
            NumberID = 004;
            Salary = 40000;
            IfPaid = false;
            
        }
        public override void EmployeeInfo()
        {
            Console.WriteLine("Janitor: " + Name + "\n" + "Sweeping or not: " + SweepingOrNot + "\n" + "ID Number: " + NumberID + "\n" + "Salary: $" + Salary + "\n" + "If Paid: " + IfPaid + "\n");
        }
        public override void EmployeePaid()
        {
            Console.WriteLine("You have paid your employee!");
            IfPaid = true;
        }
    }
}
