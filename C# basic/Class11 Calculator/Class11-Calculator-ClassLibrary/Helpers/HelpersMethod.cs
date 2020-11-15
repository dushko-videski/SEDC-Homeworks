using System;
using System.Collections.Generic;
using System.Text;

namespace Class11_Calculator_ClassLibrary.Helpers
{
    internal static class HelpersMethod
    {
        internal static string CalculateAverage(List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                int sum = 0;
                numbers.ForEach(number => sum += number);
                double average = Convert.ToDouble(sum) / Convert.ToDouble(numbers.Count);
                return average.ToString("0.00");
            }
            else
            {
                return "The list of numbers is empty!";
            }
        }

        internal static string FindMaxNumber (List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                int max = 0;
                foreach (var number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }
                return Convert.ToString(max);
            }
            else
            {
                return "The list of numbers is empty!";   
            }
        }

        internal static string FindMinNumber(List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                int min = numbers[0];
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                return Convert.ToString(min);
            }
            else
            {
                return "The list of numbers is empty";
            } 
        }

        internal static string findSumOfAll(List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                int sum = 0;
                numbers.ForEach(num => sum += num);
                return Convert.ToString(sum);
            }
            else
            {
                return "The list of numbers is empty";
            }
        }

        internal static List<int> findOddNumbers(List<int> numbers)
        {               
            var oddNumbers = new List<int>();
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    oddNumbers.Add(num);
                }
            }
            
            return oddNumbers;
        }
        internal static List<int> findEvenNumbers(List<int> numbers)
        {               
            var evenNumbers = new List<int>();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }

            return evenNumbers;
        }
    }
}
