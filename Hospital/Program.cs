using System;

namespace Hospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeList Lists = new EmployeeList();
            PayEmployees Pay1 = new PayEmployees();
            MainMenu menu = new MainMenu();
            Lists.AddToList();
            Pay1.EmployeesPaid();
            bool loop = true;
            while (loop)
            {
                menu.Menu();
            }
        }
    }
}
