using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Neighborhood
    {
        private string name;
        private int id;
        private List<int> avenues;
        private int housePrice;
        private int currentIndex;

        public Neighborhood(string name, int id, int housePrice)
        {
            this.name = name;
            this.id = id;
            this.housePrice = housePrice;
            this.avenues = new List<int>();
            this.currentIndex = -1;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public List<int> Avenues
        {
            get { return this.avenues; }
            set { this.avenues = value; }
        }

        public int HousePrice
        {
            get { return this.housePrice; }
            set { this.housePrice = value; }
        }

        public int CurrentIndex
        {
            get { return this.currentIndex; }
            set { this.currentIndex = value; }
        }
    }
}
