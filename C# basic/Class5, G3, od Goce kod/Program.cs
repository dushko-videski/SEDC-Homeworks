using System;

namespace Class5__G3__od_Goce_kod
{
    public class Driver
    {
        public string Name;
        public int Skill;
    }

    public class Car
    {
        public string Model;
        public int Speed;
        public Driver Driver = new Driver();
        public int CalculateSpeed(int skill)
        {
            return Speed * skill;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Car selectedCar, selectedCar1; //???
                Driver selectedDriver, selectedDriver1;

                Car[] cars = GetAllCars();
                Driver[] drivers = GetAllDrivers();

                Console.WriteLine("Please choose one of following drivers");
                PrintDriversOptions(drivers);
                while (true)
                {
                    Console.Write("Your choise: ");
                    var driver = Console.ReadLine();
                    selectedDriver = SelectDriver(drivers, driver);
                    if (selectedDriver.Name != null)
                    {
                        drivers = Array.FindAll(drivers, (driver) => driver.Name != selectedDriver.Name);//go trga od arrayot drivers  
                        //izbraniot prv driver za da ne moze da se izbere koga ke se bira vtoriot driver
                        Console.WriteLine($"You have successfully selected {selectedDriver.Name}");
                        break;
                    }
                    Console.WriteLine("No such driver try again!");
                }

                Console.WriteLine("Please choose one of following car models");
                PrintCarOptions(cars);
                while (true)
                {
                    Console.Write("Your choise: ");
                    var model = Console.ReadLine();
                    selectedCar = SelectCar(cars, model);
                    if (selectedCar.Model != null)
                    {
                        cars = Array.FindAll(cars, (car) => car.Model != selectedCar.Model);
                        selectedCar.Driver = selectedDriver;
                        Console.WriteLine($"You have successfully selected {selectedCar.Model}");
                        break;
                    }
                    Console.WriteLine("No such car model try again!");
                }

                Console.WriteLine("Please choose second driver");
                PrintDriversOptions(drivers);
                while (true)
                {
                    Console.Write("Your choise: ");
                    var driver = Console.ReadLine();
                    selectedDriver1 = SelectDriver(drivers, driver);
                    if (selectedDriver1.Name != null)
                    {
                        drivers = Array.FindAll(drivers, (driver) => driver.Name != selectedDriver1.Name);
                        Console.WriteLine($"You have successfully selected {selectedDriver1.Name}");
                        break;
                    }
                    Console.WriteLine("No such driver try again!");
                }

                Console.WriteLine("Please choose another car model");
                PrintCarOptions(cars);
                while (true)
                {
                    Console.Write("Your choise: ");
                    var model = Console.ReadLine();
                    selectedCar1 = SelectCar(cars, model);
                    if (selectedCar1.Model != null)
                    {
                        cars = Array.FindAll(cars, (car) => car.Model != selectedCar1.Model);
                        selectedCar1.Driver = selectedDriver1;
                        Console.WriteLine($"You have successfully selected {selectedCar1.Model}");
                        break;
                    }
                    Console.WriteLine("No such car model try again!");
                }

                int speedFirstCar = selectedCar.CalculateSpeed(selectedCar.Driver.Skill);
                int speedSecondCar = selectedCar1.CalculateSpeed(selectedCar1.Driver.Skill);

                RaceCars(speedFirstCar, speedSecondCar);

                if (speedFirstCar > speedSecondCar)
                {
                    Console.WriteLine($"It's speed was {selectedCar.CalculateSpeed(selectedCar.Driver.Skill)} and it was driven by {selectedCar.Driver.Name}"); ;
                }
                else if (speedFirstCar < speedSecondCar)
                {
                    Console.WriteLine($"It's speed was {selectedCar1.CalculateSpeed(selectedCar1.Driver.Skill)} and it was driven by {selectedCar1.Driver.Name}");
                }


                Console.WriteLine("Would you like to race again? Please enter yes or no!");
                while (true)
                {
                    Console.Write("Your choice:  ");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        break;
                    }
                    else if (answer == "no")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter yes or no!!!");
                        continue;    
                    }
                }
       
            }

            //Console.ReadLine();
        }

        public static Driver[] GetAllDrivers()
        {
            //DRIVER 1
            var Bob = new Driver() { Name = "Bob", Skill = 2 };
            //DRIVER 2
            var Greg = new Driver() { Name = "Greg", Skill = 5 };
            //DRIVER 3
            var Jill = new Driver() { Name = "Jill", Skill = 7 };
            //DRIVER 4
            var Anne = new Driver() { Name = "Anne", Skill = 9 };
            //-----------------------
            Driver[] drivers = new Driver[] { Bob, Greg, Jill, Anne };
            return drivers;
        }

        public static Car[] GetAllCars()
        {
            //CAR 1
            var Hyundai = new Car();
            Hyundai.Model = "Hyundai";
            Hyundai.Speed = 2;
            //CAR 2
            var Mazda = new Car();
            Mazda.Model = "Mazda";
            Mazda.Speed = 3;
            //CAR 3
            var Ferrari = new Car();
            Ferrari.Model = "Ferrari";
            Ferrari.Speed = 8;
            //CAR 4
            var Porsche = new Car();
            Porsche.Model = "Porsche";
            Porsche.Speed = 10;

            Car[] cars = new Car[] { Hyundai, Mazda, Ferrari, Porsche };

            return cars;
        }
        //PRINT CARS TO CHOOSE
        public static void PrintCarOptions(Car[] cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"--- {car.Model}");
            }
        }
        //PRINT DRIVERS TO CHOOSE
        public static void PrintDriversOptions(Driver[] drivers)
        {
            foreach (var driver in drivers)
            {
                Console.WriteLine($"--- {driver.Name}");
            }
        }
        //SELECT DRIVER
        public static Driver SelectDriver(Driver[] drivers, string driverName)
        {
            Driver selectedDriver = new Driver();

            foreach (var driv in drivers)
            {
                if (driv.Name.ToLower() == driverName.ToLower())
                {
                    selectedDriver = driv;
                    break;
                }
            }

            return selectedDriver;
        }
        //SELECT CAR
        public static Car SelectCar(Car[] cars, string model)
        {
            Car selectedCar = new Car();

            foreach (var car in cars)
            {
                if (car.Model.ToLower() == model.ToLower())
                {
                    selectedCar = car;
                    break;
                }
            }

            return selectedCar;
        }

        public static void RaceCars(int calcSpeed1, int calcSpeed2)
        {
            if (calcSpeed1 > calcSpeed2)
            {
                Console.WriteLine("Car no.1 was faster!");
            }
            else if (calcSpeed1 < calcSpeed2)
            {
                Console.WriteLine("Car no.2 was faster!");
            }
            else
            {
                Console.WriteLine("We have a tie!");
            }
        }
    }
}
