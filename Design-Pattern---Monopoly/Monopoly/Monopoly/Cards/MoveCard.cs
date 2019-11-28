using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class MoveCard : Icard
    {
        private Position newStreet;
        private string message;

        public MoveCard(Position newStreet)
        {
            this.newStreet = newStreet;
            this.message = "Go to ";
        }

        public Player Action(Player p)
        {
            this.message += this.newStreet.Name;
            Console.WriteLine(this.message);
            p.Position = this.newStreet;
            Console.ReadKey();
            return p;
        }
    }
}
