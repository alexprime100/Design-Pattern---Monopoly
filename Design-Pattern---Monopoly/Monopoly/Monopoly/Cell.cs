using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Cell
    {
        private Position street;
        private int lenght;
        private char[,] matrix;
        private int rentLine;

        public Cell(Position street, int lenght)
        {
            this.street = street;
            this.lenght = lenght;
        }

        public Cell(int lenght)
        {
            this.lenght = lenght;
            this.matrix = new char[lenght, lenght];
        }

        public Position Street
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
            int i = 0;
            int j = 0;

            matrix[0, 0] = '|';
            for(int k = 1; k < lenght-1; k++)
            {
                matrix[0, k] = '-';
                matrix[lenght - 2, k] = '-';
                matrix[k, 0] = '|';
                matrix[k, lenght - 1] = '|';
            }
            matrix[lenght - 1, lenght - 1] = '|';

            for (int k = 0; k < this.street.Name.Length; k++)
            {
                this.matrix[i, j] = this.street.Name[k];
                j++;
                if (i == this.lenght)
                {
                    j = 0;
                    i++;
                }
                
            }

            i = this.lenght - 2;
            j = (lenght / 2) - 2;
            string rent = Convert.ToString(this.street.Rent);
            for (int k = 0; k < rent.Length; k++)
            {
                matrix[i, j] = rent[k];
                j++;
            }

            i -= 2;
            j = (lenght / 2) - 2;
            string price = Convert.ToString(this.street.Price);
            for (int k = 0; k < price.Length; k++)
            {
                matrix[i, j] = price[k];
                j++;
            }

            /*i = this.lenght/2;
            j = 1;
            for (int k = 0; k < this.street.ListPlayers.Count; k++)
            {
                matrix[i, j] = this.street.ListPlayers[k].Symbol;
                j++;
            }*/
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
