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
        private List<Neighborhood> neighborhoods;
        private int balance;
        private char symbol;

        public Player(string name, Position initial, char symbol)
        {
            this.name = name;    //name of the player
            this.position = initial;    //current position of the player
            this.jail = false;       //the player is in jail or not
            this.jailTurn = 0;       //number of consecutive turns in jail
            this.play = false;       //it is this player's turn or not
            this.consecutivesTurns = 0;     //number of consecutive turns
            this.balance = 1500;       //money of the player
            this.symbol = symbol;      //symbol used by the player
            this.properties = new List<Position>();      //list of properties
            this.neighborhoods = new List<Neighborhood>();
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

        public List<Neighborhood> Neighborhoods
        {
            get { return this.neighborhoods; }
            set { this.neighborhoods = value; }
        }
    }
}
