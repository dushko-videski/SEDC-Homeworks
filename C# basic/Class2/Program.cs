using System;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 01
            //Exercise 01
            //-----------
            //01/1
            //Declare two string variables
            //Initialize them and concatenate them in a new variable
            string firstName = "Dushko";
            string lastName = "Videski";
            string fullName = firstName + " " + lastName;
            //or
            //string fullName = $"{firstName} {lastName}";
            Console.WriteLine(fullName);
            //01/2
            //Declare two string variables
            //Initialize them with the number 9 and 3
            //Concatenate them in a new variable
            string first = "9";
            string second = "3";
            string concat = $"{first}{second}";
            Console.WriteLine(concat);
            //Print the results in the console
            Console.ReadLine();
            #endregion

            #region Exercise 02
            //Exercise 02
            //------------
            //Declare an integer and a string variable
            //Initialize them and concatenate them in a new variable
            //Print the result in the console
            int number = 10;
            string text = "Dushko";
            var concat1 = $"{number} {text}";
            Console.WriteLine(concat1);
            Console.ReadLine();
            #endregion

            #region Exercise 03
            //Exercise 03 
            //------------
            //You have n credits on your mobile bill. One SMS costs m credits.How many SMS messages you can send?
            //n = 102
            //m = 5
            //Result = ?
            int n = 102;
            int m = 5;
            int result = n / m;
            Console.WriteLine($"You can send {result} messages!");
            Console.ReadLine();
            #endregion

            #region Exercise 04 Bonus
            //Exercise 04(*BONUS)
            //------------------
            //Set variable from input
            //TRY to convert it to int
            //if its converted successfully print in the console if number is odd or even
            //else if its not converted, print in the console that user inserted invalid input
            //Hint: if number / 2 has remainder 0 its even, else its odd
            Console.WriteLine("Enter number:");
            var input = Console.ReadLine();
            int output;
            bool isConverted = int.TryParse(input, out output);
            if (isConverted)
            {
                if (output % 2 == 0)
                {
                    Console.WriteLine($"The input number: {output} is an even number!");
                }
                else
                {
                    Console.WriteLine($"The input number: {output} is an odd number!");
                }
            }
            else
            {
                Console.WriteLine("You have inserted invalid input!!!");
            }
            Console.ReadLine();

            #endregion
        }
    }
}
