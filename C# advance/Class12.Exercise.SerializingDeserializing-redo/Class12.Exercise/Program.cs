using Class12.Exercise.Entities;
using Class12.Exercise.Services;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Class12.Exercise
{
    class Program
    {
        static string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
        static string filePath = Path.Combine(directoryPath, "Log.txt");
        static void Main(string[] args)
        {
            //USER INPUT:
            Console.WriteLine("Enter dog's name.");
            string dogName = Console.ReadLine();

            Console.WriteLine("Enter dog's age.");
            string dogAgeString = Console.ReadLine();
            int dogAge;
            bool isConverted = int.TryParse(dogAgeString, out dogAge);

            Console.WriteLine("Enter dog's color.");
            string dogColor = Console.ReadLine();
            //--------------------------------------------

            Dog newDog = new Dog(dogName, dogAge, dogColor);

            string dogAsJson = JsonConvert.SerializeObject(newDog);


            LogerService.WriteJsonInFile(filePath, directoryPath, dogAsJson);

            LogerService.ReadAndWriteInConsole(filePath);


            Console.ReadLine();
        }
    }
}
