using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Employee
    {
        public string Name { get; set; }
        public int NumberID { get; set; }
        public int Salary { get; set; }
        public bool IfPaid { get; set; }

        public string Specialty { get; set; } 
        public int NumberofPatients { get; set; }
        public bool OnPhoneOrNot { get; set; }
        public bool SleepingOrNot { get; set; }

        public void Doctor()
        {
            Name = "john";
            Specialty = "foot";
            NumberID = 001;
            Salary = 90000;
            IfPaid = false;
        }
        public void Nurse()
        {
            Name = "mary";
            NumberofPatients = 20;
            NumberID = 002;
            Salary = 50000;
            IfPaid = false;
        }
        public void Receptionist()
        {
            Name = "sue";
            OnPhoneOrNot = false;
            NumberID = 003;
            Salary = 45000;
            IfPaid = false;
        }
        public void Janitor()
        {
            Name = "george";
            SleepingOrNot = false;
            NumberID = 004;
            Salary = 40000;
            IfPaid = false;
        }
    }
}