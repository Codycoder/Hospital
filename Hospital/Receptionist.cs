using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Receptionist : Employee
    {
        bool OnPhoneOrNot = true;
        public Receptionist()
        {
            Name = "sue";
            NumberID = 003;
            Salary = 45000;
            IfPaid = false;
        }
        public override void EmployeeInfo()
        {
            Console.WriteLine("Receptionist: " + Name + "\n" + "ID Number: " + NumberID + "\n" + "Salary: $" + Salary + "\n" + "If Paid: " + IfPaid);
            Random rnd = new Random();
            int UsePhoneOrNot = rnd.Next(1, 3);
            switch (UsePhoneOrNot)
            {
                case 1:
                    OnPhoneOrNot = false;
                    break;
                case 2:
                    OnPhoneOrNot = true;
                    break;
            }
            Console.WriteLine("On the Phone or Not: " + OnPhoneOrNot);
        }
        public override void EmployeePaid()
        {
            Console.WriteLine("You have paid your employee!");
            IfPaid = true;
        }
    }
}
