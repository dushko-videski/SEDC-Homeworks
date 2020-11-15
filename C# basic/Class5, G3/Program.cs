using System;

namespace Class5__G3
{
    public class Driver
    {
        public string name;
        public int skill;

    }

    public class Car
    {
        public string model;
        public int speed;
        public Driver driver = new Driver();
        public int CalculateSpeed(int skill)
        {
            return speed * skill;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //DRIVER 1
            var Bob = new Driver();
            Bob.name = "Bob";
            Bob.skill = 2;
            //DRIVER 2
            var Greg = new Driver();
            Greg.name = "Greg";
            Greg.skill = 5;
            //DRIVER 3
            var Jill = new Driver();
            Jill.name = "Jill";
            Jill.skill = 7;
            //DRIVER 4
            var Anne = new Driver();
            Anne.name = "Anne";
            Anne.skill = 9;
            //-----------------------
            //CAR 1
            var Hyundai = new Car();
            Hyundai.model = "Hyundai";
            Hyundai.speed = 2;
            Hyundai.driver = new Driver(); 
            //CAR 2
            var Mazda = new Car();
            Mazda.model = "Mazda";
            Mazda.speed = 3;
            Mazda.driver = new Driver();       
            //CAR 3
            var Ferrari = new Car();
            Ferrari.model = "Ferrari";
            Ferrari.speed = 8;
            Ferrari.driver = new Driver();
            //CAR 4
            var Porsche = new Car();
            Porsche.model = "Porsche";
            Porsche.speed = 10;
            Porsche.driver = new Driver();

            Driver[] drivers = new Driver[] { Bob, Greg, Jill, Anne };
            Car[] cars = new Car[] { Hyundai, Mazda, Ferrari, Porsche };

            Console.WriteLine($"Choose Car no.1:\n-Hyundai\n-Mazda\n-Ferrari\n-Porsche");
            var answCar1 = Console.ReadLine();
            Console.WriteLine($"Choose Driver no.1:\n-Bob\n-Geg\n-Jill\n-Anne");
            string answDriver1 = Console.ReadLine();
            //answCar1.driver = answDriver1;// ova ako propertito driver kaj Car object e string
            
            Console.WriteLine($"Choose Car no.1:\n-Hyundai\n-Mazda\n-Ferrari\n-Porsche");
            string answCar2 = Console.ReadLine();
            Console.WriteLine($"Choose Driver no.2:\n-Bob\n-Geg\n-Jill\n-Anne");
            string answDriver2 = Console.ReadLine();
            //answCar1.driver = answDriver1;// ova ako propertito driver kaj Car object e string

            //int speedXSkill1 = answCar1.CalculateSpeed(answDriver1.skill);
            //int speedXSkill2 = answCar2.CalculateSpeed(answDriver2.skill);
            
            //RaceCars(speedXSkill1, speedXSkill2);

            Console.ReadLine();
        }
        
        public static void RaceCars(int calcSpeed1, int calcSpeed2 )
        {
            if (calcSpeed1 > calcSpeed2)
            {
                Console.WriteLine("Car no.1 was faster");
            }
            else if (calcSpeed1 < calcSpeed2)
            {
                Console.WriteLine("Car no.2 was faster");
            }
            else
            {
                Console.WriteLine("We have a tie!");
            }
        }
    }
}
