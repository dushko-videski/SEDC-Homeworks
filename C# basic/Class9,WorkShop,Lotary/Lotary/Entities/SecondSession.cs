using System;
using System.Collections.Generic;
using System.Text;
using Lotary.Helpers;


namespace Lotary.Entities
{
    public class SecondSession : Session
    {
        public void GetRandomTicketWith2Matches(SecondSession secondSession)
        {
            int[] allMatches = new int[] { };
            Ticket[] winnersWith2Matches = new Ticket[] { };
            foreach (var ticket in secondSession.Tickets)
            {
                int match = LottaryHelpers.CheckTicket(secondSession.WinningCombination, ticket.Combination);
                Array.Resize(ref allMatches, allMatches.Length + 1);
                allMatches[allMatches.Length - 1] = match;
                if (match == 2 && ticket.User.Age > 18)
                {
                    Array.Resize(ref winnersWith2Matches, winnersWith2Matches.Length + 1);
                    winnersWith2Matches[winnersWith2Matches.Length - 1] = ticket;
                }
            }

            if (winnersWith2Matches.Length==0)
            {
                Console.WriteLine("There are no winners with 2 winning numbers!");
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }
            else
            {
                int randomWinnerWith2MatchesIndex = new Random().Next(0, winnersWith2Matches.Length - 1);
                string randomWinnerWith2MatchesName = winnersWith2Matches[randomWinnerWith2MatchesIndex].User.FullName;
                Console.WriteLine($"The winner of the Vacation from session {secondSession.SessionId} is {randomWinnerWith2MatchesName} :) !");
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }    
        }
    }
}
