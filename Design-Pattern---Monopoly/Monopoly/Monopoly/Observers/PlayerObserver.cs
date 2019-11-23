using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class PlayerObserver : IObserver
    {
        private Player player;
        private List<DisplayProperties> properties;

        public PlayerObserver(Player player)
        {
            this.player = player;
        }

        

        public void update(List<int[]> indexes, Player player = null, GameBoard b = null)
        {
            this.player = player;
            //on veut actualiser une description lorsque le nombre de maisons change
            //logiquement, grâce à list.sort(), player.properties et properties sont identiquement ordonnés, les index sont donc les mêmes
            //indexes doit contenir les index des rues à actualiser de player.properties
            foreach(var x in indexes)
            {
                this.properties[x[0]].Property = player.Properties[x[0]];
                this.properties[x[0]].UpdateDescription();
            }
            this.properties.Sort();
        }

        public void Add(Player p)
        {
            this.player = p;
            this.properties.Add(new DisplayProperties(p.Position));
            this.properties[this.properties.Count - 1].UpdateDescription();
            this.properties.Sort();
        }

        public void Display()
        {
            Console.WriteLine("You have " + this.player.Balance + "Euros\n");
            Console.Write("And you owe ");
            if (this.properties.Count == 0)
                Console.WriteLine("nothing");
            else
                Console.WriteLine("\n");
            foreach(var x in this.properties)
            {
                Console.WriteLine(x.Description);
            }
        }
    }
}
