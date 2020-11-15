using System;
using System.IO;

namespace Class09.FileSystemIO.Exercise
{
    class Program
    {
        static string folder = @"..\..\..\Folder1";
        static string filePath = Path.Combine(folder, "Calculations.txt");

        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1-st number");
            string firstNum = Console.ReadLine();
            int number1;
            bool convertedFirstNum = int.TryParse(firstNum, out number1);

            Console.WriteLine("Enter 2-nd number");
            string secondNum = Console.ReadLine();
            int number2;
            bool convertedSecondNum = int.TryParse(secondNum, out number2);

            Calculate(number1, number2);

            Console.ReadLine();
        }
        public static string Calculate(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine($"The sum of these numbers is: {sum}");

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close(); //mora da se zatvori koga se kreira file
            }
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"The sum is: {sum} [TIME STAMP]: {DateTime.Now.ToLocalTime()}");
                sw.WriteLine("_____________________________________________________");
            }

            return sum.ToString();
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string folder = Path.Combine(Directory.GetCurrentDirectory(), "Exercise");
    //        string filePath = Path.Combine(folder, "Calculations.txt");

    //        Console.WriteLine("Enter 1-st number");
    //        string firstNum = Console.ReadLine();
    //        int number1;
    //        bool convertedFirstNum = int.TryParse(firstNum, out number1);

    //        Console.WriteLine("Enter 2-nd number");
    //        string secondNum = Console.ReadLine();
    //        int number2;
    //        bool convertedSecondNum = int.TryParse(secondNum, out number2);

    //        if (!Directory.Exists(folder))
    //        {
    //            Directory.CreateDirectory(folder);
    //        }
    //        if (!File.Exists(filePath))
    //        {
    //            File.Create(filePath).Close();
    //        }
    //        using (StreamWriter sw = new StreamWriter(filePath, true))
    //        {
    //            sw.WriteLine($"The sum is: {Calculate(number1, number2)} [TIME STAMP]: {DateTime.Now.ToLocalTime()}");
    //            sw.WriteLine("_____________________________________________________");
    //        }



    //        Console.ReadLine();
    //    }
    //    public static string Calculate(int num1, int num2)
    //    {
    //        int sum = num1 + num2;
    //        Console.WriteLine($"The sum of these numbers is: {sum}");
    //        return sum.ToString();
    //    }
    //}


}
