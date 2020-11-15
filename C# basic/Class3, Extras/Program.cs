using System;

namespace Class3__Extras
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-find the sum of first 10 natural numbers
            //1. Write a C# Sharp program to find the sum of first 10 natural numbers
            //*Hint: The first 10 natural number are: 1 2 3 4 5 6 7 8 9 10
            //int sum = 0;
            //for (int i = 1; i <=10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 2-read 10 numbers from keyboard and find their sum and average.
            //Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            //int sum = 0;

            //Console.WriteLine("Enter 10 numbers!");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"Enter {i} number");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    sum += number;
            //}
            //Console.WriteLine($"The sum of the entered numbers is:{sum}");
            //Console.WriteLine($"The average of the entered numbers is:{sum/10}");
            #endregion

            #region 3-Find max,min and index
            //Declare and init array of 10 integers by your choise. 
            //Find maximum and minimum element in that array and their indexes

            int[] array = new int[] { 2, 3, 1, 9, 7, 6, 1, 7, 5, 9 };

            int max = array[0];
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            int indexOfMax = Array.IndexOf(array, max);
            int indexOfMin = Array.IndexOf(array, min);
            Console.WriteLine($"The maximum element in the array is:{max} and it's index is:{indexOfMax}");
            Console.WriteLine($"The minimum element in the array is:{min} and it's index is:{indexOfMin}");
            #endregion

            #region 4-count total number of duplicate elements
            ////Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates
            ////arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            int[] arrayWithDuplicates = new int[] { 4, 4, 4, 3, 4, 5, 9, 3, 9, 9 };
            int count = 0;
            int[] arr = new int[] { };
            for (int i = 0; i < arrayWithDuplicates.Length; i++)
            {
                for (int j = i + 1; j < arrayWithDuplicates.Length; j++)
                {
                    if (arrayWithDuplicates[i] == arrayWithDuplicates[j] && Array.IndexOf(arr, arrayWithDuplicates[i]) == -1)
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = arrayWithDuplicates[i];
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine($"The total number of duplicate elements in arrayWithDuplicates is: {count}");
            #endregion

            #region 5-separate odd and even integers
            //5.oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            //Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays
            //int[] oddEvenArray = new int[] { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            //int[] evenArray = new int[] { };
            //int[] oddArray = new int[] { };

            //for (int i = 0; i < oddEvenArray.Length; i++)
            //{
            //    if (oddEvenArray[i] % 2 == 0)
            //    {
            //        Array.Resize(ref evenArray, evenArray.Length + 1);
            //        evenArray[evenArray.Length-1] = oddEvenArray[i];
            //    }
            //    if (oddEvenArray[i] % 2 != 0)
            //    {
            //        Array.Resize(ref oddArray, oddArray.Length + 1);
            //        oddArray[oddArray.Length-1] = oddEvenArray[i];
            //    }
            //}
            //foreach (var item in evenArray)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in oddArray)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6-read any Day Number in integer (from 1 to 7)
            //Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            //the day with strings.Example: user enters 1, you should print Monday.
            //1-st solution:
            //-------------
            //while (true)
            //{
            //    Console.WriteLine("Enter number between 1 and 7!");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    if (number == 1)
            //    {
            //        Console.WriteLine("Monday");
            //        continue;
            //    }
            //    else if (number == 2)
            //    {
            //        Console.WriteLine("Tuesday");
            //        continue;
            //    }
            //    else if (number == 3)
            //    {
            //        Console.WriteLine("Wednesday");
            //        continue;
            //    }
            //    else if (number == 4)
            //    {
            //        Console.WriteLine("Thursday");
            //        continue;
            //    }
            //    else if (number == 5)
            //    {
            //        Console.WriteLine("Friday");
            //        continue;
            //    }
            //    else if (number == 6)
            //    {
            //        Console.WriteLine("Saturday");
            //        continue;
            //    }
            //    else if (number == 7)
            //    {
            //        Console.WriteLine("Sunday");
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter number between 1 and 7!");
            //        continue;
            //    }
            //}
            //2-nd solution:
            //-------------
            Console.WriteLine("Enter number between 1 and 7!");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 7");
                    break;
            }
            #endregion

            #region 7-Username--Password
            //userNames = ["user1", "user2", "user3"]
            //passwords = ["first", "second", "third"]
            //Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //Create a logic when user enters specific username to provide a correct password for that user, and when that
            //happens you should print on the screen "You are logged in successfully".
            //If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //repeat the proccess from begining while he / she doesn't input correct username and password.
            //Note: Every element in userNames corresponds with the element in passwords at same index.
            //Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third".

            //while (true)
            //{
            //    string[] userNames = new string[] { "user1", "user2", "user3" };
            //    string[] passwords = new string[] { "first", "second", "third" };

            //    Console.WriteLine("Please enter username to login!");
            //    string userName = Console.ReadLine();
            //    int indexOfUsername = Array.IndexOf(userNames, userName);
            //    Console.WriteLine("Enter password!");
            //    string password = Console.ReadLine();
            //    int indexOfPassword = Array.IndexOf(passwords, password);

            //    if (indexOfUsername != -1 && indexOfPassword != -1 && indexOfPassword == indexOfUsername)
            //    {
            //        Console.WriteLine("You are logged in successfully!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect username or password!");
            //        continue;
            //    }
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
