using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Janitor : Employee
    {
        public bool SweepingOrNot { get; set; }
        public void Janitor1()
        {
            Name = "george";
            SweepingOrNot = false;
            NumberID = 004;
            Salary = 40000;
            IfPaid = false;
        }
    }
}
