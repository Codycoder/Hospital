using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Janitor : Employee
    {
        bool SweepingOrNot = true;
        public Janitor()
        {
            Name = "george";
            NumberID = 004;
            Salary = 40000;
            IfPaid = false;
            
        }
        public override void EmployeeInfo()
        {
            Console.WriteLine("Janitor: " + Name + "\n" +  "ID Number: " + NumberID + "\n" + "Salary: $" + Salary + "\n" + "If Paid: " + IfPaid);
            Random rnd = new Random();
            int SweepingOrNot1 = rnd.Next(1, 3);
            switch (SweepingOrNot1)
            {
                case 1:
                    SweepingOrNot = false;
                    break;
                case 2:
                    SweepingOrNot = true;
                    break;
            }
            Console.WriteLine("Sweeping or not: " + SweepingOrNot + "\n");
        }
        public override void EmployeePaid()
        {
            IfPaid = true;
        }
    }
}
