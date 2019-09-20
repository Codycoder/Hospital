using System;

namespace Hospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            bool loop = true;
            menu.Start();
            while (loop)
            {
                menu.Menu();
            }
        }
    }
}
