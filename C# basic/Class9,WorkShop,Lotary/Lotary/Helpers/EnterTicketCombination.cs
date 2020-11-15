using System;
using System.Collections.Generic;
using System.Text;
using Lotary.Entities;

namespace Lotary.Helpers
{
    class EnterTicketCombination
    {
        public static Ticket[] EnterNumbers(User[] users)
        {
            Ticket[] tickets = new Ticket[] { };

            foreach (var user in users)
            {
                if (user.Age < 18)
                {
                    Console.WriteLine($"! ! ! {user.FullName} is under the age of 18 and is not allowed to buy ticket and play ! ! !");
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine($"{user.FullName}, please enter your winning combination!");
                        Console.Write("First number:");
                        int firstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Second number:");
                        int secondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Third number:");
                        int thirdNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Fourth number:");
                        int fourthNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Fifth number:");
                        int fifthNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sixth number:");
                        int sixthstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Seventh number:");
                        int seventhNumber = Convert.ToInt32(Console.ReadLine());
                        int[] combination = new int[] { firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber, sixthstNumber, seventhNumber };

                        if (Array.Exists(combination, num => num > 36) || Array.Exists(combination, num => num < 1))
                        {
                            Console.WriteLine("Numbers must be between 1 and 36!!!");
                            continue;
                        }
                        else
                        {
                            var ticket = new Ticket()
                            {
                                Combination = combination,
                                User = user
                            };
                            user.BuyTicket(ticket);
                            Console.WriteLine("               ");

                            Array.Resize(ref tickets, tickets.Length + 1);
                            tickets[tickets.Length - 1] = ticket;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
            return tickets;
        }
    }
}
