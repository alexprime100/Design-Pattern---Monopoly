using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public enum ObserverType { BoardObserver, PlayerObserver};

    abstract class ObserverFactory
    {
        public abstract IObserver CreateObserver(ObserverType type, GameBoard board = null, Player player = null);
    }
}
