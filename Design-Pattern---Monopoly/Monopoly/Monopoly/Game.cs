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
        private static Game instance;

        private Game() { }

        public static Game GetInstance()
        {
            if (this.instance == null)
                instance = new Game();
            return instance;
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
