using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    interface IObserver
    {
        public abstract void update(List<int[]> indexes, Player player = null, GameBoard board = null);

        public abstract void Display();

    }
}
