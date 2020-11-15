using System;

namespace Class3__left_from_class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region exercise-homework 1
            ////Create two variables and initialize them with a keyboard input
            ////Write code that can test which number is larger
            //Console.WriteLine("enter 2 numbers");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int max = 0;
            //if (number1 > number2)
            //{
            //    max = number1;
            //}
            //else if (number1 < number2)
            //{
            //    max = number2;
            //}
            //else
            //{
            //    Console.WriteLine("the two numbers are equal");
            //}
            ////Write code that can test the numbers whether they are even or odd
            //if (number1 % 2 == 0)
            //{
            //    Console.WriteLine($"{number1} is an even number");
            //}
            //else
            //{
            //    Console.WriteLine($"{number1} is an odd number");
            //}
            //if (number2 % 2 == 0)
            //{
            //    Console.WriteLine($"{number2} is an even number");
            //}
            //else
            //{
            //    Console.WriteLine($"{number2} is an odd number");
            //}
            ////Write the larger number from the two in the console
            //Console.WriteLine($"The larger number is {max}");
            ////After that write if the number is even or odd
            //if (max % 2 == 0)
            //{
            //    Console.WriteLine($"{max} is an even number");
            //}
            //else
            //{
            //    Console.WriteLine($"{max} is an odd number");
            //}
            //Console.ReadLine();
            #endregion

            #region exercise-homework 2
            ////Solve the following problem. 
            ////On one tree there are 12 branches with n apples on them. 
            ////One basket can hold m apples. 
            ////If a user enters number of trees find out how many baskets does it take to collect all the apples from the trees?
            ////n = 8
            ////m = 5
            ////Result = ?
            //int branches = 12;
            //int apples = 8;
            //int basketSize = 5;
            //Console.WriteLine("Enter number of trees!");
            //int trees = Convert.ToInt32(Console.ReadLine());
            //int result = (trees * branches * apples) / basketSize;
            //Console.WriteLine($"You will need {result+1} baskets to collect all the apples from the trees");           
            #endregion

            #region exercise 5
            ////Declare a new array of integers with 5 elements
            ////Initialize the array elements with values from input
            ////Sum all the values and print the result in the console

            //int[] array = new int[5];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"Enter the {i+1} number!");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int sum = 0;

            //foreach (var number in array)
            //{
            //    sum += number;
            //}
            //Console.WriteLine($"The sum of the numbers in the array is {sum}");
            #endregion

            Console.ReadLine();
        }
    }
}
