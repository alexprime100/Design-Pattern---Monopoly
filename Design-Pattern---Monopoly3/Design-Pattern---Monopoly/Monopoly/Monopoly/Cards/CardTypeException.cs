using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class CardTypeException : Exception
    {
        private string message;

        public CardTypeException(string message)
        {
            this.message = message;
        }
    }
}
