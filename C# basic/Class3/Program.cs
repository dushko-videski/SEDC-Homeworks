using System;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EXERCISE 01:
            //Get an input number from the console
            //Print all numbers from 1 to that number

            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }

            //Get another input number from the console
            //Print all numbers from that number to 1

            Console.WriteLine("Enter another number:");
            int anotherNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = anotherNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region EXERCISE 02:
            //Get an input number from the console
            //Print all even numbers starting from 2

            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Get another input number from the console
            //Print all odd numbers starting from 1

            Console.WriteLine("Enter another number");
            int anotherNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= anotherNum; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region EXERCISE 03:
            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N
            //Print all the names after user enters N
            //Hint: we need to use endless loop until user enter N, then we want to "break" the loop

            //ifot i else vnatre vo ciklusot da gi stavis vo eden while (true) 
            //istoto sto go pravis so forot se 
            //dodeka ne vnese Y ili N pa koga ke vnese eden tie 2 karakteri 
            //togas da upotrebis break za da izlezes od while-ot

            string[] namesArray = new string[] { };

            for (int i = 0; ; i++)
            {
                Array.Resize(ref namesArray, namesArray.Length + 1);
                Console.WriteLine("Enter a name");
                namesArray[i] = Console.ReadLine();
                Console.WriteLine("Do you want to enter another name? (Y/N)");
                var userEntered = Console.ReadLine();

                if (userEntered == "Y" || userEntered == "y")
                    continue;

                else if (userEntered == "N" || userEntered == "n")
                    foreach (var name in namesArray)
                    {
                        Console.WriteLine(name);
                    }
                break;
            }

            //while (true)
            //{
            //    Console.WriteLine("Enter a name");
            //    string userEntered = Console.ReadLine();
            //    Array.Resize(ref namesArray, namesArray.Length + 1);
            //    int index = namesArray.Length;
            //    namesArray[index] = userEntered;

            //    Console.WriteLine("Do you want to enter another name? (Y/N)");

            //    if (userEntered == "Y" || userEntered == "y")
            //        continue;

            //    else if (userEntered == "N" || userEntered == "n")
            //        foreach (var name in namesArray)
            //        {
            //            Console.WriteLine(name);
            //        }
            //    break;
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
