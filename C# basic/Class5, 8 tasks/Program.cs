using System;

namespace Class5__8_tasks
{
    public class Dog
    {
        public string Name;
        public string Race;
        public string Color;
        public void Eat()
        {
            Console.WriteLine("The dog is now eating");
        }
        public void Play()
        {
            Console.WriteLine("The dog is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine("The dog is now chasing its tail");
        }
    }
    public class Human
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void GetPersonStats()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName} \nAge: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            ////Print individual characters of the string in reverse order. 
            ////Example: we love c# *Expected ---> Output : #c evol ew
            ////----------------------------------------------------------
            //string example = "My name is Dushko Videski";
            //string reversedExample = "";
            //char[] charExample = example.ToCharArray();
            //for (int i = charExample.Length - 1; i >= 0; i--)
            //{
            //    reversedExample += charExample[i];
            //}
            //Console.WriteLine(reversedExample);
            #endregion

            #region Task 2
            ////Count the total number of words in a string entered by the user.
            ////Example: user enters "I love C#"
            ////Expected output: "I love c#" contains 3 words.
            ////-------------------------------------------------------------- 
            //Console.WriteLine("Please enter a phrase!");
            //string phrase = Console.ReadLine();
            //string[] spliPhrase = phrase.Split(" ");
            //Console.WriteLine($@"""{phrase}"" contains {spliPhrase.Length} words.");
            #endregion

            #region Task 3
            ////Find maximum occurring character in a string 
            ////Example: "We want this situation with covid-19 to ends!" 
            ////Expected Output : The highest frequency of character 't' appears number of times : 6
            ////------------------------------------------------------------------------------------
            string str = "We want this situation with covid-19 to ends!";

            char[] strToChar = str.ToLower().ToCharArray();
            int[] countArr = new int[strToChar.Length];

            for (int i = 0; i < strToChar.Length; i++)
            {
                int count = 0;
                for (int j = i; j < strToChar.Length; j++)
                {
                    if (strToChar[i] == strToChar[j] && char.IsLetterOrDigit(strToChar[i]))
                    {
                        count++;
                    }
                }
                countArr[i] = count;
            }

            int max = countArr[0];

            for (int i = 0; i < countArr.Length; i++)
            {
                if (countArr[i] > max)
                {
                    max = countArr[i];
                }
            }
            Console.WriteLine($@"Maximum occurring character in the string is:""{strToChar[Array.IndexOf(countArr, max)]}"". It appears {max} times.");
            #endregion

            #region Task 4
            ////"The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!"
            //// Print the whole text after "," in the console. 
            //// Bonus - Try to do that without counting the characters till "," by yourself :)
            ////--------------------------------------------------------------------------------
            //string str1 = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";
            //Console.WriteLine($"{str1.Substring(32)}");
            ////bonus:
            //Console.WriteLine($"{str1.Split(", ")[1]}");
            #endregion

            #region Task 5
            ////display the day properties(year, month, day, hour, minute, second) from the today's date. 
            ////expected output: 
            ////year = 2020
            ////month = 3
            ////day = 26
            ////hour = 23
            ////minute = 12
            ////second = 22
            ////------------------------------
            //datetime today = datetime.now;
            //console.writeline($"year = {today.year}\nmonth = {today.month}\nday = {today.day}\nhour = {today.hour}\nminute = {today.minute}\nsecond = {today.second}");
            #endregion

            #region Task 6
            ////Find the leap years between 2008 and 2020. 
            ////Expected output: *2008 is a leap year. * 2012 is a leap year. * 2016 is a leap year. 
            ////2020 is a leap year.
            ////Hint - make some researches of DateTime methods, you will find interesting ones that might help you;)
            ////---------------------------
            //findLeapyear(2008, 2020);

            #endregion

            #region Task 7
            ////Create a class Dog
            ////Add properties: Name, race, color
            ////The dog needs to have:
            ////Eat method that returns message: The dog is now eating
            ////Play method returning a message : The dog is now playing
            ////ChaseTail method that returns a message: Dog is now chasing its tail.
            ////The user needs to create the dog object by inputs and then given an option 
            ////to choose one of the actions mentioned above.
            ////-----------------------------------------------
            //var newDog = new Dog();

            //Console.WriteLine("Enter dog's name!");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter dog's race!");
            //string race = Console.ReadLine();
            //Console.WriteLine("Enter dog's color");
            //string color = Console.ReadLine();
            //Console.WriteLine("Enter what the dog is doing? \n1--->for PLAYING \n2--->for EATING \n3--->for chasing it's tal");
            //int action = Convert.ToInt32(Console.ReadLine());

            //switch (action)
            //{
            //    case 1:
            //        newDog.Play();
            //        break;
            //    case 2:
            //        newDog.Eat();
            //        break;
            //    case 3:
            //        newDog.ChaseTail();
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            #region Task 8
            ////Create a class Human
            ////Add properties: FirstName, LastName, Age
            ////Create a method called GetPersonStats that returns the full name of the human as well as their age
            ////Create an object human by asking the user to fill the required information
            ////Call the GetPersonStats method and print the result in the console after the object is create
            ////---------------------------------------------------
            //Console.WriteLine("Enter your first name");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Enter yor last name");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Please enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());

            //var newHuman = new Human();
            //newHuman.FirstName = firstName;
            //newHuman.LastName = lastName;
            //newHuman.Age = age;

            //newHuman.GetPersonStats();
            #endregion

            Console.ReadLine();
        }

        public static void findLeapyear(int year1, int year2)
        {
            for (int i = year1; i <= year2; i++)
            {
                //if (DateTime.DaysInMonth(i, 2)==29)
                //or
                if (DateTime.IsLeapYear(i))
                {
                    Console.WriteLine($"{i} is leap year");
                }
            }
        }


    }
}
