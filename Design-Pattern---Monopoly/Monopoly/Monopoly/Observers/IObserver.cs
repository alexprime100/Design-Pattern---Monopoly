using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    interface IObserver
    {
        public string name { get; set; }
        public  void update(List<int[]> indexes, Player player = null, bool add = false, GameBoard board = null);

        public  void Display();

    }
}
