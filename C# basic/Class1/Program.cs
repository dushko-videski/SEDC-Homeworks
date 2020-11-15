using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            //trafficLight

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("STOP");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("READY");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("GO");
            Console.ReadLine();
        }
    }
}
