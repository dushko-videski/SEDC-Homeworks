using System;
using Homework_Class08.Entities;
using Homework_Class08.Enums;
using CarServicess;

namespace Homework_Class08
{
    class Program
    {
        static void Main(string[] args)

        {
            var electricCar1 = new ElectricCar()
            {
                BateryCapacity = 100,
                Consume = Consumption.economic,
                BatteryLeft = 100,
                ID = CarIdGenerator.GenerateCarId(),
                Brand = "Toyota",
                Model = "Prius",
                Doors = 5,
                TopSpeed = 180
            };
            electricCar1.PrintInfo();
            electricCar1.Drive(900);
            electricCar1.Recharge(900);


            var fuelCar1 = new FuelCar()
            {
                FuelCapacity = 60,
                Consume = Consumption.medium,
                CurrentFuel = 60,
                Brand = "KIA",
                Model = "Ceed",
                Doors = 5,
                ID = CarIdGenerator.GenerateCarId(),
                TopSpeed = 190,
            };
            fuelCar1.PrintInfo();
            fuelCar1.Drive(310);
            fuelCar1.Refuel(10);














            Console.ReadLine();
        }
    }
}
