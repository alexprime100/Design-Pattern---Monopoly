using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class BoardObserver : IObserver
    {
        public string name { get; set; }
        private char[,] matrix;

        public BoardObserver(GameBoard board)
        {
            ConvertToCharMatrix(board);
            this.name = "Board Observer";
            //this.size = board.Lenght * 11;
        }

        

        public void update(List<int[]> indexes, Player player = null, bool add = false, GameBoard board = null)   //updates a list of positions on the matrix
        {
            //int size = board.TheBoard[indexes[0][0], indexes[0][1]].Lenght;
            foreach(var x in indexes)
            {
                //int Size = board.TheBoard[x[0], x[1]].Lenght;
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
            //Console.WriteLine(size);
            /*for (int i = 0; i < 11; i++)
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
            }*/
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
