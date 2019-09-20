using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Patient
    {
        public int Bloodlevel { get; set; }
        public int Health { get; set; }

        public Patient()
        {
            Bloodlevel = 20;
            Health = 10;
        }
    }

}
