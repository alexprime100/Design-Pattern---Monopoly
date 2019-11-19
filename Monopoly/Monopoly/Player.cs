using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Player
    {
        private string name;
        private Position position;
        private bool jail;
        private int jailTurn;
        private bool play;
        private int consecutivesTurns;
        private List<Position> properties;
        private int balance;
        private char symbol;

        public Player(string name, Position initial, char symbol)
        {
            this.name = name;
            this.position = initial;
            this.jail = false;
            this.jailTurn = 0;
            this.play = false;
            this.consecutivesTurns = 1;
            this.balance = 1500;
            this.symbol = symbol;
            this.properties = new List<Position>();
        }

        public string Name
        {
            get { return this.name; }
        }

        public Position Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public bool Jail
        {
            get { return this.jail; }
            set { this.jail = value; }
        }

        public int JailTurn
        {
            get { return this.jailTurn; }
            set { this.jailTurn = value; }
        }

        public bool Play
        {
            get { return this.play; }
            set { this.play = value; }
        }

        public int ConsecutivesTurns
        {
            get { return this.consecutivesTurns; }
            set { this.consecutivesTurns = value; }
        }

        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public char Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        public List<Position> Properties
        {
            get { return this.properties; }
            set { this.properties = value; }
        }

        public void Roll (Dice d1, Dice d2)
        {
            Console.WriteLine(this.name + " plays");
            Console.WriteLine("Press any key to roll the dices");
            Console.ReadKey();
            if (this.jail)
            {
                jailRoll(d1, d2);
            }
            else
            {
                d1.roll();
                d2.roll();
                this.position.Index += d1.CurrentFace + d2.CurrentFace;
                if (this.position.Index > 40)
                    this.balance += 200;
                this.position.Index %= 40;
                if (d1.CurrentFace != d2.CurrentFace)
                {
                    this.play = false;
                }
                else
                {
                    this.consecutivesTurns++;
                }
                if (this.position.Index == 30 || this.consecutivesTurns == 3)
                {
                    this.consecutivesTurns = 1;
                    this.position.Index = 10;
                    this.play = false;
                    this.jail = true;
                }
            }
        }

        public void jailRoll(Dice d1, Dice d2)
        {
            this.jailTurn++;
            d1.roll();
            d2.roll();
            if (this.jailTurn > 3 || d1.CurrentFace == d2.CurrentFace)
            {
                this.jailTurn = 0;
                this.position.Index += d1.CurrentFace + d2.CurrentFace;
            }
            this.jail = false;
        }
    }
}
