using System;
using System.Collections.Generic;
using System.Text;

namespace CarServicess
{
    public class BatteryUsageCalculator
    {


        public static string GetBatteryUsagePercentage(double batteryUsage)
        {
            string percentBatteryUsage = string.Format($"{batteryUsage/100:P}");
            return percentBatteryUsage;
        }
    }
}
