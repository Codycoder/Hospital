using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeList Lists = new EmployeeList();
            Lists.AddToList();
            Lists.PrintList();
            string p = Console.ReadLine();
            if (p == "p")
            {
                Lists.EmployeePaid();
            }
            Lists.PrintList();

            Console.ReadKey();
        }
    }
}
