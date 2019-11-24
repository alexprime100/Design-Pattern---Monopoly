using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class MoneyCard : Icard
    {
        private int Money;
        private string message;

        public MoneyCard(string message, int money)
        {
            Money = money;
            this.message = message;
        }

        public Player Action(Player p)
        {
            this.message += this.Money + "Euros";
            Console.WriteLine(message);
            p.Balance += this.Money;
            return p;
        }
    }
}
