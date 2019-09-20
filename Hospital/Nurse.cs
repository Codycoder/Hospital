using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Nurse : Employee
    {
        public int NumberofPatients { get; set; }
        public void Nurse1()
        {
            Name = "mary";
            NumberofPatients = 20;
            NumberID = 002;
            Salary = 50000;
            IfPaid = false;
        }
    }
}
    