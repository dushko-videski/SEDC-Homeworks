using System;
using System.Collections.Generic;
using System.Text;
using Lotary.Enums;
using Lotary.Entities;


namespace Lotary.Helpers
{
    public class PrintWinners
    {
        public static void Print(Session session)
        {
            int[] allMatches = new int[] { };
            foreach (var ticket in session.Tickets)
            {
                int match = LottaryHelpers.CheckTicket(session.WinningCombination, ticket.Combination);
                Array.Resize(ref allMatches, allMatches.Length + 1);
                allMatches[allMatches.Length - 1] = match;
                ticket.NumberOfMatchingNumbers = match;
                switch (match)
                {
                    case (int)Prize.TV:
                        if (ticket.User.Age >= 18)
                        {
                            ticket.Prize = Prize.TV;
                            Console.WriteLine($"The winner of the {Prize.TV} is {ticket.User.FullName} with {(int)Prize.TV} winning numbers :)");
                        }
                        break;
                    case (int)Prize.Vacation:
                        if (ticket.User.Age >= 18)
                        {
                            ticket.Prize = Prize.Vacation;
                            Console.WriteLine($"The winner of the {Prize.Vacation} is {ticket.User.FullName} with {(int)Prize.Vacation} winning numbers :)");
                        }
                        break;
                    case (int)Prize.MotorBike:
                        if (ticket.User.Age >= 18)
                        {
                            ticket.Prize = Prize.MotorBike;
                            Console.WriteLine($"The winner of the {Prize.MotorBike} is {ticket.User.FullName} with {(int)Prize.MotorBike} winning numbers :)");
                        }
                        break;
                    case (int)Prize.Car:
                        if (ticket.User.Age >= 18)
                        {
                            ticket.Prize = Prize.Car;
                            Console.WriteLine($"The winner of the {Prize.Car} is {ticket.User.FullName} with {(int)Prize.Car} winning numbers :)");
                        }
                        break;
                    //default:
                    //    Console.WriteLine("! ! ! THERE ARE NO WINNERS IN THIS SESSION ! ! !");
                    //    break;
                }
            }
            if (!Array.Exists(allMatches, match => match >= 4))
            {
                Console.WriteLine($"! ! ! THERE ARE NO WINNERS IN SESSION {session.SessionId} :( ! ! !");
                Console.WriteLine("*************************************************************************************");
            }

                       
            //SO THAT WE CAN SEE THE NUMBER OF MATCHES IN EACH TICKET
            foreach (var ticket in session.Tickets)
            {
                if (ticket.User.Age >= 18)
                {
                    Console.WriteLine($"{ticket.User.FullName}'s ticket has ({ticket.NumberOfMatchingNumbers}) winning numbers!");
                }
                else
                {
                    Console.WriteLine($"! ! ! {ticket.User.FullName} was not allowed to play because he is under the age of 18 ! ! !");
                }
                
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
    }
}
