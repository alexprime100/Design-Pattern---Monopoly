using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class MyObserverFactory : ObserverFactory
    {
        public override IObserver CreateObserver(ObserverType type, GameBoard board = null, Player player= null)
        {
            switch(type)
            {
                case ObserverType.BoardObserver:
                    return new BoardObserver(board);
                    break;
                case ObserverType.PlayerObserver:
                    return new PlayerObserver(player);
                    break;

                default:
                    throw new ObserverTypeException("");
            }
        }
    }
}
