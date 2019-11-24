using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class BoardObserver : IObserver
    {
        char[,] matrix;

        public BoardObserver(GameBoard board)
        {
            this.matrix = ConvertToCharMatrix(board);
        }

        

        public void update(List<int[]> indexes, Player player = null, GameBoard board = null)
        {
            int size = board.TheBoard[indexes[0][0], indexes[0][1]].Lenght;
            foreach(var x in indexes)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        int k = x[0] * size + i;
                        int l = x[1] * size + j;
                        this.matrix[k, l] = board.TheBoard[x[0], x[1]].Matrix[i, j];
                    }
                }
            }
        }

        public char[,] ConvertToCharMatrix(GameBoard board)
        {
            int size = board.Lenght * 11;
            char[,] matrix = new char[size, size];
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    for (int k = 0; k < board.Lenght; k++)
                    {
                        for (int l = 0; l < board.Lenght; l++)
                        {
                            int _k = i * board.Lenght + k;
                            int _l = j * board.Lenght + l;
                            matrix[_k, _l] = board.TheBoard[i, j].Matrix[k, l];
                        }
                    }
                }
            }
            return matrix;
        }

        public void Display()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; i < this.matrix.GetLength(1); j++)
                {
                    Console.Write(this.matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
