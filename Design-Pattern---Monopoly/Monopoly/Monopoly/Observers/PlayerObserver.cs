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
            this.properties = new List<DisplayProperties>();
        }

        public void update(List<int[]> indexes, Player p, bool add = false, GameBoard b = null)
        {
            //indexes = index of the street
            this.player = p;
            if (indexes != null)
            {
                foreach (var x in indexes)
                {
                    bool end1 = false;
                    int index1 = -1;
                    for (int i = 0; i < this.properties.Count && !end1; i++)
                    {
                        if (this.properties[i].Property.Index == x[0])
                        {
                            index1 = i;
                            end1 = true;
                        }
                    }

                    bool end2 = false;
                    int index2 = -1;
                    for (int j = 0; j < this.player.Properties.Count && !end2; j++)
                    {
                        if (this.player.Properties[j].Index == x[0])
                        {
                            index2 = j;
                            end2 = true;
                        }
                    }
                    this.properties[index1].Property = this.player.Properties[index2];
                    this.properties[index1].UpdateDescription();
                }
            }
            if (add)
            {
                this.properties.Add(new DisplayProperties(p.Position));
                this.properties[this.properties.Count - 1].UpdateDescription();
            }

            this.properties.Sort();
        }

       public void Display()
        {
            Console.WriteLine("You have " + this.player.Balance + "Euros\n");
            Console.WriteLine("And you owne ");
            if (this.properties.Count == 0)
                Console.WriteLine("nothing");
            foreach(var x in this.properties)
            {
                Console.WriteLine(x.Description);
            }
            Console.WriteLine();
        }
    }
}
