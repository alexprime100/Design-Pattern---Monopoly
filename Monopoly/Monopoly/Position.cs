using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Position : IComparable<Position>
    {
        private int index;
        private bool goToJail;
        private bool visitJail;
        private string name;
        private string text;
        private Player owner;
        private int price;
        private int rent;
        private bool buy;
        private int housesNumber;   //hotel is considered sa a 5th house

        public Position(int index, string name)
        {
            this.index = index;
            this.name = name;
            this.goToJail = false;
            this.visitJail = false;
            this.housesNumber = 0;
        }

        public int Index
        {
            get { return this.index; }
            set { this.index = value; }
        }

        public bool GoToJail
        {
            get { return this.goToJail; }
            set { this.goToJail = value; }
        }

        public bool VisitJail
        {
            get { return this.visitJail; }
            set { this.visitJail = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Player Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public bool Buy
        {
            get { return this.buy; }
            set { this.buy = value; }
        }

        public int Rent
        {
            get { return this.rent; }
            set { this.rent = value; }
        }

        public int CompareTo(Position p)
        {
            return this.index.CompareTo(p.index);
        }

    }
}
