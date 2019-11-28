using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Dice
    {
        private int[] faces = new int[6] {1,2,3,4,5,6};
        private int currentFace;

        public Dice() { }

        public int CurrentFace
        {
            get { return this.currentFace; }
            set { this.currentFace = value; }
        }
        
        public void roll()
        {
            Random rand = new Random();
            this.currentFace = faces[rand.Next(0, 6)];
            
        }

        public void rollTest()
        {
            Console.WriteLine("enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            this.currentFace = number;
        }
    }
}
