using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class PayCard : Icard
    {
        private int Money;
        private string message;

        public PayCard(string message, int money)
        {
            Money = money;
            this.message = message;
        }

        public Player Action(Player p)
        {
            this.message += this.Money + "Euros";
            Console.WriteLine(message);
            p.Balance -= this.Money;
            Console.ReadKey();
            return p;
        }
    }
}
