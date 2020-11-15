using System;
using CodeOrganizer.Entities;
using CodeOrganizer.Enums;
using CodeOrganizer.Helpers;

namespace CodeOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John", 22);
            john.Address = new Address();
            john.Address.Name = "Wall street";
            john.Address.Number = 24;
            john.SSN = SSN.GenerateSSN();
            john.PrintPerson();

            Console.WriteLine("------------------------------------");

            Address bobsAdress = new Address()
            {
                Name = "Next To Wallstreet",
                Number = 1000
            };
            Address bobWorkingAdress = new Address()
            {
                Name = "Two streets after Wallstreet",
                Number = 101
            };
            Person bob = new Person()
            {
                Name = "Bob",
                Age = 55,
                Address = bobsAdress,
                SSN = SSN.GenerateSSN(),
                Job = new Job()
                {
                    Address = bobWorkingAdress,
                    CompanyName = "G1",
                    Role = Role.Designer
                }
            };

            bob.DevelopersSeacret();

            Console.ReadLine();
        }
    }
}
