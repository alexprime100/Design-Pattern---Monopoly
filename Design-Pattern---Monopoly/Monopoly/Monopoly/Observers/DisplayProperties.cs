using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class DisplayProperties
    {
        private Position property;
        private string decription;

        public DisplayProperties(Position property)
        {
            this.property = property;
        }

        public Position Property
        {
            get { return this.property; }
            set { this.property = value; }
        }

        public string Description
        {
            get { return this.decription; }
            set { this.decription = value; }
        }

        public void UpdateDescription()
        {
            string desc= "";
            desc += this.property.Name;
            desc += " with ";
            desc += this.property.HousesNumber;
            desc += " houses, for a rent of ";
            desc += this.property.Rent;
            desc+= "Euros";
            this.decription = desc;
        }

        public int CompareTo(DisplayProperties p)
        {
            return this.property.Index.CompareTo(p.property.Index);
        }
    }
}
