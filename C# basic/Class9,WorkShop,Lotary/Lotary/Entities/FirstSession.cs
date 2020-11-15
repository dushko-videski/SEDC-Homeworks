using System;
using System.Collections.Generic;
using System.Text;
using Lotary.Helpers;

namespace Lotary.Entities
{
    public class FirstSession : Session
    {
        public void Get1RandomLoosingTicket(FirstSession firstSession)
        {
            int[] allMatches = new int[] { };
            Ticket[] loosingMatches = new Ticket[] { };
            foreach (var ticket in firstSession.Tickets)
            {
                int match = LottaryHelpers.CheckTicket(firstSession.WinningCombination, ticket.Combination);
                Array.Resize(ref allMatches, allMatches.Length + 1);
                allMatches[allMatches.Length - 1] = match;
                if (match < 4 && ticket.User.Age>18)
                {
                    Array.Resize(ref loosingMatches, loosingMatches.Length + 1);
                    loosingMatches[loosingMatches.Length - 1] = ticket;
                }
            }

            if (loosingMatches.Length==0)
            {
                Console.WriteLine("There are no players with less then 4 winning numbers!");
            }
            else
            {
                int randomLoosingTicketIndex = new Random().Next(0, loosingMatches.Length - 1);
                string randomLooserName = loosingMatches[randomLoosingTicketIndex].User.FullName;
                Console.WriteLine($"The winner of the TV from session {firstSession.SessionId} is {randomLooserName} :) !");
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }    
        }
    }
}
