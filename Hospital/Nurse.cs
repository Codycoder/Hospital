using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Nurse : Employee
    {
        public int NumberofPatients { get; set; }
        public Nurse()
        {
            Name = "mary";
            NumberofPatients = 20;
            NumberID = 002;
            Salary = 50000;
            IfPaid = false;
        }

        public override void EmployeeInfo()
        {
            Console.WriteLine("Nurse: " + Name + "\n" + "Number of Patients: " + NumberofPatients + "\n" + "ID Number: " + NumberID + "\n" + "Salary: $" + Salary + "\n" + "If Paid: " + IfPaid + "\n");
        }
        public override void EmployeePaid()
        {
            Console.WriteLine("You have paid your employee!");
            IfPaid = true;
        }
    }
}
    