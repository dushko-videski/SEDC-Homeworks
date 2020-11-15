using System;
using System.Collections.Generic;
using System.Text;
using Homework_Class08.Enums;
using CarServicess;

namespace Homework_Class08.Entities
{
    public class FuelCar : Car
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }

        public FuelCar()
        {
            EngineType = EngineType.diesel;
        }



        //METHODS:
        //calculates how much of the fuel has been used
        public void Drive(int distance)
        {
            int fuelUsed = distance * (int)Consume / 10;

            if (fuelUsed > CurrentFuel)
            {
                Console.WriteLine($"You can't drive the car for {distance}km. With it's full tank capacity, you can drive your car for maximum of {CurrentFuel / ((double)Consume/10)}km!");
            }
            else
            {
                CurrentFuel = CurrentFuel - fuelUsed;
                Console.WriteLine($"You drove your car for {distance}km! It has {CurrentFuel} liters left in it's tank!");
                
            }
        }

        public void Refuel(int fuelIntake)
        {
            if (FuelCapacity==CurrentFuel)
            {
                Console.WriteLine("Your car tank is full! You can't refuel it!");
            }
            else if (fuelIntake + CurrentFuel > FuelCapacity)
            {
                Console.WriteLine($"Can't refuel more than {FuelCapacity-CurrentFuel} litres!");
            }
            else
            {
                Console.WriteLine($"You refueld your car tank with {fuelIntake} liters!");
                FuelCapacity = fuelIntake + CurrentFuel;
                Console.WriteLine($"Your car tank capacity is {FuelCapacity} liters now!");
            }
        }
    }
}
