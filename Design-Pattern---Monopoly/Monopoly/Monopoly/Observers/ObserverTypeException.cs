using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class ObserverTypeException : Exception
    {
        private string message;

        public ObserverTypeException(string message)
        {
            this.message = message;
        }
    }
}
