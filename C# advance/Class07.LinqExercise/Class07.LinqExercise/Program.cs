using System;
using System.Collections.Generic;
using System.Linq;
using Class07.LinqExercise.Enums;
using Class07.LinqExercise.Entities;
using Class07.LinqExercise.DB;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace Class07.LinqExercise
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            Func<string, bool> StartsWithR = x => x.StartsWith("R");
            List<string> FirstNamesOnR = DataBase.people
                                .OrderByDescending(person => person.Age)
                                .Select(human => human.FirstName)
                                .Where(StartsWithR)
                                .ToList();
            FirstNamesOnR.Print();

            // Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            Func<Dog, string> nameAge = dog => $"Dog name: {dog.Name}, Age: {dog.Age}";
            var dogNameAndAge = DataBase.dogs
                                        .OrderBy(dog => dog.Age)
                                        .Where(dog => dog.Age > 3 && dog.Color == "Brown")
                                        .Select(nameAge)
                                        .ToList();
            dogNameAndAge.Print();

            // Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            Func<Person, string> firstName = x => x.FirstName;
            var personWithMoreThan2Dogs = DataBase.people
                                        .OrderByDescending(human => human.FirstName)
                                        .Where(human => human.Dogs.Count > 2)
                                        .Select(firstName)
                                        .ToList();
            personWithMoreThan2Dogs.Print();

            // Find and print all Freddy`s dogs names older than 1 year

            var frediesDogsOlderThan1 = DataBase.people
                                    .Single(human => human.FirstName == "Freddy").Dogs
                                    .Where(dog => dog.Age > 1)
                                    .Select(dog => dog.Name)
                                    .ToList();
            frediesDogsOlderThan1.Print();

            // Find and print Nathen`s first dog
            var nathansFirstDog = DataBase.people
                                .Single(human => human.FirstName == "Nathen").Dogs                                
                                .First();
            Console.WriteLine(nathansFirstDog.Name);
            Console.WriteLine("---------------------------");

            // Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER

            var whiteDogs = DataBase.people
                        .FindAll(person => person.FirstName == "Cristofer" ||
                        person.FirstName == "Freddy" ||
                        person.FirstName == "Erin" ||
                        person.FirstName == "Amelia")
                        .SelectMany(person => person.Dogs)
                        .OrderBy(dog => dog.Name)
                        .Where(dog => dog.Color == "White")
                        .Select(dog => dog.Name)
                        .ToList();

            whiteDogs.Print();




            Console.ReadLine();
        }
    }
}
