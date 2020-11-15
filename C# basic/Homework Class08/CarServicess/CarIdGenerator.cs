using System;
using System.Collections.Generic;
using System.Text;

namespace CarServicess
{
    public class CarIdGenerator
    {


        public static int GenerateCarId()
        {
            int randomId = new Random().Next(1, 1000000000);
            return randomId;
        }
    }
}
