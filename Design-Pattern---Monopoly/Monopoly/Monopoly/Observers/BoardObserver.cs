using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class BoardObserver : IObserver
    {
        private char[,] matrix;

        public BoardObserver(GameBoard board)
        {
            ConvertToCharMatrix(board);
        }

        

        public void update(List<int[]> indexes, Player player = null, bool add = false, GameBoard board = null)   //updates a list of positions on the matrix
        {
            foreach(var x in indexes)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        int k = x[0] * 6 + i;
                        int l = x[1] * 6 + j;
                        this.matrix[k, l] = board.TheBoard[x[0], x[1]].Matrix[i, j];
                    }
                }
            }
        }

        public void ConvertToCharMatrix(GameBoard board)
        {
            int size = board.Lenght * 11;
            this.matrix = new char[size, size];
            
            for (int i = 0; i < size; i ++)
            {
                for (int j = 0; j < size; j++)
                {
                    this.matrix[i, j] = board.TheBoard[i / 6, j / 6].Matrix[i % 6, j % 6];
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    Console.Write(this.matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
