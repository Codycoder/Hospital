using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Receptionist : Employee
    {
        public bool OnPhoneOrNot { get; set; }
        public Receptionist()
        {
            Name = "sue";
            OnPhoneOrNot = false;
            NumberID = 003;
            Salary = 45000;
            IfPaid = false;

        }
        public override void EmployeeInfo()
        {
            Console.WriteLine("Receptionist: " + Name + "\n" + "On the Phone or Not: " + OnPhoneOrNot + "\n" + "ID Number: " + NumberID + "\n" + "Salary: $" + Salary + "\n" + "If Paid: " + IfPaid + "\n");
        }
    }
}
