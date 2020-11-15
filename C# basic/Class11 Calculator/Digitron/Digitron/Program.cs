using Class11_Calculator_ClassLibrary.Models;
using System;
using System.Collections.Generic;

namespace Digitron
{
    class Program
    {
        static void Main(string[] args)
        {
            //with empty list:
            //List<int> numbers = new List<int>();

            //with numbers in the list:
            var numbers = new List<int>() { 10, 21, 30, 40, 51 };

            Console.WriteLine($"The number of elements in number List is: {numbers.Count}");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine(Calc.Avg(numbers));
            Console.WriteLine("---------------------------------------");

            Console.WriteLine(Calc.Max(numbers));
            Console.WriteLine("---------------------------------------");

            Console.WriteLine(Calc.Min(numbers));
            Console.WriteLine("---------------------------------------");

            Console.WriteLine(Calc.Sum(numbers));
            Console.WriteLine("---------------------------------------");

            var oddNumbers = Calc.Odd(numbers);
            foreach (var oddNum in oddNumbers)
            {
                Console.Write($"{oddNum} ");
            }
            Console.WriteLine("-------------------------");
            var evenNumbers = Calc.Even(numbers);
            foreach (var evenNum in evenNumbers)
            {
                Console.Write($"{evenNum} ");
            }

            Console.ReadLine(); 
        }
    }
}
