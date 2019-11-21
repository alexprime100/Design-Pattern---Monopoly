using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Observer : IObserver
    {
        private string name;

        public void update()
        {

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
