using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Game
    {
        private Position[] board;
        private GameBoard boardGame;
        private List<Neighbourhood> listNeighbourhood;
        private List<Player> players;
        private bool end = false;
        private static Game instance;
        private List<IObserver> observers;
        private List<Icard> cards;
        private Dice d1;
        private Dice d2;

        private Game() 
        {
            this.board = new Position[40];
            this.boardGame = new GameBoard();
            this.observers = new List<IObserver>();
            this.cards = new List<Icard>();
            this.players = new List<Player>();
            this.listNeighbourhood = new List<Neighbourhood>();
            this.d1 = new Dice();
            this.d2 = new Dice();
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

        public List<Neighbourhood> ListNeighbourhood
        {
            get { return this.listNeighbourhood;}
            set { this.listNeighbourhood = value; }
        }

        public List<IObserver> Observers
        {
            get { return this.observers; }
            set { this.observers = value; }
        }

        public List<Icard> Cards
        {
            get { return this.cards; }
            set { this.cards = value; }
        }

        public Dice D1
        {
            get { return this.d1; }
            set { this.d1 = value; }
        }

        public Dice D2
        {
            get { return this.d2; }
            set { this.d2 = value; }
        }





    }
}
