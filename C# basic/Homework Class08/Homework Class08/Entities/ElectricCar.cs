using System;
using System.Collections.Generic;
using System.Text;
using CarServicess;
using Homework_Class08.Enums;

namespace Homework_Class08.Entities
{
    public class ElectricCar : Car
    {
        public int BateryCapacity { get; set; }
        //BatteryLeft = BatteryCapacity-batteryUsed:
        public double BatteryLeft { get; set; }

        public ElectricCar()
        {
            EngineType = EngineType.electric; 
        }



        //METHODS:
        //calculates how much of the battery has been used
        public void Drive (int distance)
        {
            int batteryUsed = distance * (int) Consume / 10;

            if (batteryUsed > BatteryLeft)
            {
                Console.WriteLine($"You can't drive the car for {distance}km. With it's full capacity you can drive it for maximum of {Math.Floor(BatteryLeft / ((double)Consume / 10))}km!");
            }
            else
            {
                BatteryLeft = BatteryLeft - batteryUsed;
                Console.WriteLine($"You drove your car for {distance}km! You have {BatteryUsageCalculator.GetBatteryUsagePercentage(BatteryLeft)} left from your battery capacity!");
                
            }
        }

        public void Recharge(int minutes)
        {
            int batteryCharge = minutes / 10 * BateryCapacity / 100;
            if (BateryCapacity==BatteryLeft)
            {
                Console.WriteLine("The battery is full! You can't recharge it!");
            }
            else if (batteryCharge + BatteryLeft > BateryCapacity)
            {
                Console.WriteLine($"Can't charge longer than {(BateryCapacity-BatteryLeft)*10} minutes. Your have {BatteryUsageCalculator.GetBatteryUsagePercentage(BatteryLeft)} left of your car battery capacity ");
            }
            else
            {
                Console.WriteLine($"You recharged your battery for {BatteryUsageCalculator.GetBatteryUsagePercentage(batteryCharge)}");
                BateryCapacity = batteryCharge + Convert.ToInt32(BatteryLeft);
                Console.WriteLine($"Your battery capacity is {BatteryUsageCalculator.GetBatteryUsagePercentage(BateryCapacity)}");
            }
        }
    }
}
