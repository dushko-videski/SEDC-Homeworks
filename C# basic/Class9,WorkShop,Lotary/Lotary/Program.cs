using Lotary.Entities;
using Lotary.Enums;
using Lotary.Helpers;
using System;

namespace Lotary
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATING USERS:
            var user0 = new User()
            {
                FullName = "Igor Dzambazov",
                Age = 55
            };
            var user1 = new User()
            {
                FullName = "Dushko Videski",
                Age = 36
            };
            var user2 = new User()
            {
                FullName = "Mladen Smilevski",
                Age = 17
            };
            var user3 = new User()
            {
                FullName = "Goce Kabov",
                Age = 26
            };
            var user4 = new User()
            {
                FullName = "Miodrag Cekic",
                Age = 31
            };

            User[] users = new User[] { user0, user1, user2, user3, user4 };

            //FIRST SESSION:
            var firstSession = new FirstSession()
            {
                Tickets = EnterTicketCombination.EnterNumbers(users)
            };
            Console.WriteLine("Session 1");
            firstSession.StartSession();
            PrintWinners.Print(firstSession);
            firstSession.Get1RandomLoosingTicket(firstSession);

            //SECOND SESSION:
            var secondSession = new SecondSession()
            {
                Tickets = firstSession.Tickets
            };
            Console.WriteLine("Session 2");
            secondSession.StartSession();
            PrintWinners.Print(secondSession);
            secondSession.GetRandomTicketWith2Matches(secondSession);

            Console.ReadLine();
        }
    }
}
