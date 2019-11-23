using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Cell
    {
        private int street;
        private int lenght;
        private char[,] matrix;
        private int rentLine;

        public Cell(int street, int lenght)
        {
            this.street = street;
            this.lenght = lenght;
        }

        public Cell(int lenght)
        {
            this.lenght = lenght;
            this.matrix = new char[lenght, lenght];
        }

        public int Street
        {
            get { return this.street; }
            set { this.street = value; }
        }

        public int Lenght
        {
            get { return this.lenght; }
            set { this.lenght = value; }
        }

        public char[,] Matrix
        {
            get { return this.matrix; }
            set { this.matrix = value; }
        }

        public int RentLine
        {
            get { return this.rentLine; }
            set { this.rentLine = value;  }
        }

        public void FillCell()
        {
            matrix[0, 0] = '|';
            for(int k = 1; k < lenght-1; k++)
            {
                matrix[0, k] = '-';
                matrix[lenght - 2, k] = '-';
                matrix[k, 0] = '|';
                matrix[k, lenght - 1] = '|';
            }
            matrix[lenght - 1, lenght - 1] = '|';
            for (int i = 1; i < this.lenght-1; i++)
            {
                for (int j = 1; j < this.lenght-1; j++)
                {
                    matrix[i, j] = ' ';
                }
            }
            
        }
        public void AddPlayer(Player p)
        {
            int index = 0;
            while (this.matrix[this.lenght/2, index] != ' ')
            {
                index++;
            }
            this.matrix[this.lenght / 2, index] = p.Symbol;
        }

        public void RemovePlayer(Player p)
        {
            int index = 0;
            while (this.matrix[this.lenght / 2, index] != p.Symbol)
            {
                index++;
            }
            this.matrix[this.lenght / 2, index] = ' ';
        }

        public void AddHouse()
        {
            int i = 2;
            int j = 2;
            while (this.matrix[i,j]== '#')
            {
                j++;
            }
            this.matrix[i, j] = '#';
        }

        public void FillNullCell()
        {
            for (int i = 0; i < this.lenght; i++)
            {
                for (int j = 0; j < this.lenght; j++)
                {
                    matrix[i, j] = ' ';
                }
            }
        }
    }
}
