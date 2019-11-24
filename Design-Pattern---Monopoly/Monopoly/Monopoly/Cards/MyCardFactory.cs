using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class MyCardFactory : CardFactory
    {
        public override Icard CreateCard(CardType card, string message, int money = 0, Position street = null)
        {
            switch(card)
            {
                case CardType.MoneyCard:
                    return new MoneyCard(message, money);
                    break;
                case CardType.MoveCard:
                    return new MoveCard(street);
                    break;
                case CardType.PayCard:
                    return new PayCard(message, money);
                    break;
                default:
                    throw new CardTypeException("");
            }
        }
    }
}
