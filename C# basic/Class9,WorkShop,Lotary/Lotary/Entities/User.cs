using System;
using System.Collections.Generic;
using System.Text;

namespace Lotary.Entities
{
    public class User
    {
        public string FullName { get; set; }
        public int Age { get; set; }


        //METHODS:
        public void BuyTicket(Ticket ticket)
        {
            Console.Write($"{ticket.User.FullName} just bought a ticket with this combination: ");
            foreach (var number in ticket.Combination)
            {
                Console.Write($"{number} ");
            }
        }
    }
}

