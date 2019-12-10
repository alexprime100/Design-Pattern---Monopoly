using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public enum CardType { PayCard, MoneyCard, MoveCard};

    abstract class CardFactory
    {
        public abstract Icard CreateCard(CardType card, string message, int money = 0, Position street = null);
    }
}
