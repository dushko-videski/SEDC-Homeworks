using System;
using System.Collections.Generic;
using System.Text;

namespace CodeOrganizer.Helpers
{
    public class SSN
    {
        public static long GenerateSSN()
        {
            Random rand = new Random();
            return rand.Next(1000000, 9999999);
        }
    }
}
