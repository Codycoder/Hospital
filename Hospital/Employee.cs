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

        public virtual void EmployeeInfo()
        {

        }
    }


}   