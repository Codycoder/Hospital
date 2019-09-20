using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Receptionist : Employee
    {
        public bool OnPhoneOrNot { get; set; }
        public void Receptionist1()
        {
            Name = "sue";
            OnPhoneOrNot = false;
            NumberID = 003;
            Salary = 45000;
            IfPaid = false;
        }
    }
}
