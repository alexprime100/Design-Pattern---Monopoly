using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Game
    {
        private Position[] board;
        private GameBoard boardGame;
        private List<Neighborhood> listNeighborhood;
        private List<Player> players;
        private bool end = false;
        private static Game instance;
        private List<IObserver> observers;

        private Game() 
        {
            this.board = new Position[40];
            this.boardGame = new GameBoard();
        }

        public static Game GetInstance()
        {
            if (instance == null)
                instance = new Game();
            return instance;
        }

        public void AddObserver(IObserver o)
        {
            this.observers.Add(o);
        }

        public Position[] Board
        {
            get { return this.board; }
            set { this.board = value; }
        }

        public GameBoard BoardGame
        {
            get { return this.boardGame; }
            set { this.boardGame = value; }
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

        public List<Neighborhood> ListNeighborhood
        {
            get { return this.listNeighborhood;}
            set { this.listNeighborhood = value; }
        }

        public List<IObserver> Observers
        {
            get { return this.observers; }
            set { this.observers = value; }
        }





    }
}
