using LottoServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotary.Entities
{
    public class Session
    {
        static int counter = 0;
        public Session()
        {
            counter += 1;
            SessionId = counter;
            WinningCombination = new int[7];
        }
        public int SessionId { get; set; }
        //dobitnata kombinacija od 7 random izbrani broevi:
        public int[] WinningCombination { get; set; }
        //niza od objekti od tip Ticket:
        public Ticket[] Tickets { get; set; }


        //METHOD:
        public void StartSession()
        {
            WinningCombination = LottoNumbersGenerator.GenerateNumbers();
            Console.Write("The winning combination is: ");
            foreach (var num in WinningCombination)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

    }
}
