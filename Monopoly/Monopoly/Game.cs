using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Game
    {
        private Position[] board = new Position[40];
        private List<Player> players;
        private bool end = false;

        public Game()
        {
            this.end = false;
            this.board = new Position[40];
        }

        public Position[] Board
        {
            get { return this.board; }
            set { this.board = value; }
        }

        public bool End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        public List<Player> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }

        


        

        
    }
}
