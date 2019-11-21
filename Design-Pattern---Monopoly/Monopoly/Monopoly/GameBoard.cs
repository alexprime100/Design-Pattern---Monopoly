using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class GameBoard
    {
        private Cell[,] theBoard;
        private int lenght;

        public GameBoard()
        {
            this.theBoard = new Cell[11, 11];
        }

        public Cell[,] TheBoard
        {
            get { return this.theBoard; }
            set { this.theBoard = value; }
        }

        public int Lenght
        {
            get { return this.lenght; }
            set { this.lenght = value; }
        }

        public void setLenght(Game game)
        {
            int max = 0;

            foreach(Position p in game.Board)
            {
                if (p.Name.Length > max)
                {
                    max = p.Name.Length;
                }
            }
            this.lenght = (max / 2) + 1;
        }

        
    }
}
