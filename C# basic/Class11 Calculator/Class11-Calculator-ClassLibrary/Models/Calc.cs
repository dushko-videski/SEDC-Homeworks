using System;
using System.Collections.Generic;
using System.Text;
using Class11_Calculator_ClassLibrary.Helpers;

namespace Class11_Calculator_ClassLibrary.Models
{
    public static class Calc
    {
        public static string Avg (List<int> numbers)
        {
            return HelpersMethod.CalculateAverage(numbers);        
        }

        public static string Max (List<int> numbers)
        {
            return HelpersMethod.FindMaxNumber(numbers);
        }

        public static string Min(List<int> numbers)
        {
            return HelpersMethod.FindMinNumber(numbers);
        }

        public static string Sum(List<int> numbers)
        {
            return HelpersMethod.findSumOfAll(numbers);
        }

        public static List<int> Odd(List<int> numbers)
        {
            return HelpersMethod.findOddNumbers(numbers);
        }

        public static List<int> Even(List<int> numbers)
        {
            return HelpersMethod.findEvenNumbers(numbers);
        }

    }
}
