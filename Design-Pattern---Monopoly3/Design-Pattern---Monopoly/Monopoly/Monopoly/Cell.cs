using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Cell
    {
        private int street;
        private char[,] matrix;
        private int rentLine;

        public Cell(int street)
        {
            this.street = street;
            this.matrix = new char[6, 6];
            this.FillCell();
        }

        public Cell()
        {
            this.matrix = new char[6, 6];
            this.FillNullCell();
        }

        public int Street
        {
            get { return this.street; }
            set { this.street = value; }
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
            for (int i = 0; i < 6; i++)
            {
                this.matrix[i, 0] = '|';
                this.matrix[i, 5] = '|';
            }
            for (int j = 1; j < 5; j++)
            {
                this.matrix[0, j] = '-';
                this.matrix[5, j] = '-';
            }
            for(int i = 1; i < 5; i++)
            {
                for (int j= 1; j < 5; j++)
                {
                    this.matrix[i, j] = ' ';
                }
            }
        }

        public void AddPlayer(Player p)
        {
            int i = 3;
            int j = 1;
            while (this.matrix[i,j] != ' ')
            {
                if (j == 5)
                {
                    j = 1;
                    i++;
                }
                else 
                    j++;
            }
            
            this.matrix[i,j] = p.Symbol;
        }

        public void RemovePlayer(Player p)
        {
            int i = 3;
            int j = 1;
            while(this.matrix[i,j] != p.Symbol)
            {
                if (j == 5)
                {
                    j = 1;
                    i++;
                }
                else
                    j++;
            }
            this.matrix[i, j] = ' ';
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
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = ' ';
                }
            }
        }
    }
}
