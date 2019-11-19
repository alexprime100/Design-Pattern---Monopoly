using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class GameController
    {
        private Game model;
        private GameView view;
        private int index;

        public GameController(Game model, GameView view)
        {
            this.model = model;
            this.view = view;
            this.index = 0;
            this.initialization();
        }

        public void initialization()
        {
            for (int i = 0; i < 40; i++)
            {
                this.model.Board[i].Index = i;
                this.model.Board[i].Text = "You're on ";
                this.model.Board[i].Price = 0;
                this.model.Board[i].Buy = true;
                this.model.Board[i].VisitJail = false;
                this.model.Board[i].GoToJail = false;

            }
            NamesInitialization();
            TextInitialization();
            PricesInitialization();
            RentsInitialization();
            OtherInitializations();
        }

        public void NamesInitialization()
        {
            this.model.Board[0].Name = "Starting Point";

            this.model.Board[1].Name = "Belleville's Boulevard";
            this.model.Board[2].Name = "Community Chest";
            this.model.Board[3].Name = "Lecourbe Street";
            this.model.Board[4].Name = "Income Tax";

            this.model.Board[5].Name = "Montparnasse's station";

            this.model.Board[6].Name = "Vaugirard Street";
            this.model.Board[7].Name = "Luck";
            this.model.Board[8].Name = "Courcelles Street";
            this.model.Board[9].Name = "Republic Avenue";

            this.model.Board[10].Name = "Jail";

            this.model.Board[11].Name = "La Villette Boulevard";
            this.model.Board[12].Name = "Electricity Distribution Company";
            this.model.Board[13].Name = "Neuilly Avenue";
            this.model.Board[14].Name = "Paradise Street";

            this.model.Board[15].Name = " Lyon's Station";

            this.model.Board[16].Name = "Mozart Avenue";
            this.model.Board[17].Name = "Community Chest";
            this.model.Board[18].Name = "Saint-Michel Boulevard";
            this.model.Board[19].Name = "Pigalle Square";

            this.model.Board[20].Name = "MONEY";

            this.model.Board[21].Name = "Matignon Avenue";
            this.model.Board[22].Name = "Luck";
            this.model.Board[23].Name = "Malesherbes Boulevard";
            this.model.Board[24].Name = "Henry-Martin Avenue";

            this.model.Board[25].Name = " North's Station";

            this.model.Board[26].Name = "Faubourg Saint-Honoré";
            this.model.Board[27].Name = "Stock Market square";
            this.model.Board[28].Name = "Water Distribution Company";
            this.model.Board[29].Name = "Lafayette Street";

            this.model.Board[30].Name = "Go to Jail";

            this.model.Board[31].Name = "Breteuil Avenue";
            this.model.Board[32].Name = "Foch Avenue";
            this.model.Board[33].Name = "Community Chest";
            this.model.Board[34].Name = "Capucines Boulevard";

            this.model.Board[35].Name = "Saint-Lazare Station";

            this.model.Board[36].Name = "Luck";
            this.model.Board[37].Name = "Champs Elizees Avenue";
            this.model.Board[38].Name = "Luxury Tax";
            this.model.Board[39].Name = "Peace Street";
        }

        public void TextInitialization()
        {
            this.model.Board[0].Text = "You're at the ";
            this.model.Board[1].Text = "You're at ";
            this.model.Board[2].Text = "You're  ";
            this.model.Board[4].Text = "You have to pay the ";

            this.model.Board[5].Text = "You're at ";
            this.model.Board[7].Text = "You're  ";
            this.model.Board[12].Text = "Your're at the ";
            this.model.Board[10].Text = "You're visiting ";

        }

        public void PricesInitialization()
        {
            this.model.Board[5].Price = 200;
            this.model.Board[15].Price = 200;
            this.model.Board[25].Price = 200;
            this.model.Board[35].Price = 200;

            this.model.Board[12].Price = 150;
            this.model.Board[28].Price = 150;

            this.model.Board[1].Price = 60;
            this.model.Board[3].Price = 80;

            this.model.Board[6].Price = 100;
            this.model.Board[8].Price = 100;
            this.model.Board[9].Price = 120;

            this.model.Board[11].Price = 140;
            this.model.Board[13].Price = 140;
            this.model.Board[14].Price = 160;

            this.model.Board[16].Price = 180;
            this.model.Board[18].Price = 180;
            this.model.Board[19].Price = 200;

            this.model.Board[21].Price = 220;
            this.model.Board[23].Price = 220;
            this.model.Board[24].Price = 240;

            this.model.Board[26].Price = 260;
            this.model.Board[28].Price = 260;
            this.model.Board[29].Price = 280;

            this.model.Board[31].Price = 300;
            this.model.Board[32].Price = 300;
            this.model.Board[34].Price = 320;

            this.model.Board[37].Price = 350;
            this.model.Board[39].Price = 400;

        }

        public void RentsInitialization()
        {
            this.model.Board[0].Rent = -200;

            this.model.Board[5].Rent = 25;
            this.model.Board[15].Rent = 25;
            this.model.Board[25].Rent = 25;
            this.model.Board[35].Rent = 25;

            this.model.Board[1].Rent = 2;
            this.model.Board[4].Rent = 200;
            this.model.Board[3].Rent = 4;

            this.model.Board[6].Rent = 6;
            this.model.Board[8].Rent = 6;
            this.model.Board[9].Rent = 8;

            this.model.Board[11].Rent = 10;
            this.model.Board[13].Rent = 10;
            this.model.Board[14].Rent = 12;

            this.model.Board[16].Rent = 14;
            this.model.Board[18].Rent = 14;
            this.model.Board[19].Rent = 16;

            this.model.Board[21].Rent = 18;
            this.model.Board[23].Rent = 18;
            this.model.Board[24].Rent = 20;

            this.model.Board[26].Rent = 22;
            this.model.Board[27].Rent = 22;
            this.model.Board[29].Rent = 24;

            this.model.Board[31].Rent = 26;
            this.model.Board[32].Rent = 26;
            this.model.Board[34].Rent = 28;

            this.model.Board[37].Rent = 35;
            this.model.Board[38].Rent = 100;
            this.model.Board[39].Rent = 50;

        }

        public void OtherInitializations()
        {
            this.model.Board[10].VisitJail = true;
            this.model.Board[30].GoToJail = true;

            this.model.Board[0].Buy = false;
            this.model.Board[2].Buy = false;
            this.model.Board[4].Buy = false;
            this.model.Board[7].Buy = false;
            this.model.Board[10].Buy = false;
            this.model.Board[12].Buy = false;
            this.model.Board[17].Buy = false;
            this.model.Board[20].Buy = false;
            this.model.Board[22].Buy = false;
            this.model.Board[30].Buy = false;
            this.model.Board[33].Buy = false;
            this.model.Board[36].Buy = false;
            this.model.Board[38].Buy = false;


        }

        public void Start()
        {
            //create dices
            Dice d1 = new Dice();
            Dice d2 = new Dice();

            PlayersCreation();

            while (!this.model.End)  //while the game continues
            {
                this.model.Players[index].Play = true;    //Player index plays
                while (this.model.Players[index].Play)     //roll dices and consecutive turns management
                {
                    PlayATurn(d1, d2);
                }

                if (this.model.Players[index].Balance == 0)    //if this player is ruined, he is removed
                {
                    this.model.Players.RemoveAt(index);
                    if (index == this.model.Players.Count)
                        index = 0;
                }
                else
                {
                    this.model.Players[index].ConsecutivesTurns = 1;
                    index++;
                    index %= this.model.Players.Count;
                }

                EndGame();

            }
            Console.WriteLine("The winner is...\n.\n.\n.");
            Console.ReadKey();
            int winner = Winner();
            Console.WriteLine(this.model.Players[winner] + "!!!");
        }

        public void PlayATurn(Dice d1, Dice d2)
        {
            Console.WriteLine("do you want to see your money and your properties ? press 1 to see");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("you have " + this.model.Players[index].Balance);
                Console.WriteLine("here is your list of properties");
                if (this.model.Players[index].Properties.count == 0)
                    Console.WriteLine("you don't have properties");
                else
                {
                    foreach(Position p in this.model.Players[index].Properties)
                    {
                        Console.Write(p.Name);
                        if (p.HousesNumber > 0)
                            Console.Write("with " + p.HousesNumber + " houses");
                        Console.WriteLine();
                    }
                }
            }

            this.model.Players[index].Roll(d1, d2);
            Console.WriteLine(this.model.Players[index].Position.Text + this.model.Players[index].Position.Name);
            if (this.model.Players[index].Position.Buy)   //if it is possible to buy this place
            {
                if (this.model.Players[index].Position.Owner == null) //if no one ownes this place
                {
                    BuyAPlace();  
                }
                else     //if someone ownes this place
                {
                    if (this.model.Players[index].Position.Owner.Name != this.model.Players[index].Name)  //if the player has to pay a rent to another player
                    {
                        PayRent();
                    }
                }
            }
            else
            {
                if (this.model.Players[index].Position.Rent != 0)   //if the player has to pay a tax or to earn money
                {
                    this.model.Players[index].Balance -= this.model.Players[index].Position.Rent;    //the player's money is updated
                    if (this.model.Players[index].Position.Rent > 0)     //if the player earned money
                    {
                        Console.WriteLine("Congratulations, you earned " + this.model.Players[index].Position.Rent + " Euros !");
                        if (this.model.Players[index].Position.Index == 20)
                        {
                            this.model.Players[index].Position.Rent = 0;
                        }
                    }
                        
                    else     //if the player lost money
                    {
                        Console.WriteLine("You lost " + this.model.Players[index].Position.Rent + " Euros");
                        this.model.Board[20].Rent -= this.model.Players[index].Position.Rent;
                    }
                }
            }
        }

        public void BuyAPlace()
        {
            Console.WriteLine("Do you want to buy this place ? It costs " + this.model.Players[index].Position.Price + "Euros");
            Console.WriteLine("press 1 to buy it");
            string answer = Console.ReadLine();
            if (answer == "1")    //if the player wants to buy this place
            {
                if (this.model.Players[index].Balance < this.model.Players[index].Position.Price)   //if the player doesn't have enough money
                {
                    Console.writeLine("you don't have enough money to buy this place");
                }
                else
                {
                    this.model.Players[index].Balance -= this.model.Players[index].Position.Price;     //the player's money is updated
                    this.model.Players[index].Position.Owner = this.model.Players[index];              //the place's owner is updated
                    this.model.Players[index].Properties.Add(this.model.Players[index].Position);          //the place is added to the player's properties
                    this.model.Players[index].Properties.Sort();                                     //the list is sorted by index
                    Console.WriteLine("Congratulations, now you owe " + this.model.Players[index].Position.Name);

                    if (this.model.Players[index].Position.Index % 10 + 5 == 0)      //if the property is a train station
                    {
                        UpdateStationRent();
                    }
                }
                
                
                
            }
        }

        public void PayRent()
        {
            Console.WriteLine("you owe " + this.model.Players[index].Position.Rent + " Euros to " + this.model.Players[index].Position.Owner.Name);
            this.model.Players[index].Balance -= this.model.Players[index].Position.Rent;       //the player's money is updated
            int idPlayer = SearchPlayerID(this.model.Players[index].Position.Owner.Name);       //search of the owner's index
            this.model.Players[idPlayer].Balance += this.model.Players[index].Position.Rent;    //the owner's money is updated
        }

        public void UpdateStationRent()
        {
            List<int> listStations = new List<int>();
            int coefficient = 1;
            for (int i = 1; i < 5; i++)
            {
                if (this.model.Board[5 + 10 * i].Owner == this.model.Players[index])
                {
                    listStations.Add(5 + 10 * i);
                    coefficient*=2;
                }
            }
            for (int i = 0; i < listStations.Count; i++)
            {
                this.model.Board[listStations[i]].Rent *= coefficient/2;
            }
        }

        public void PlayersCreation()
        {
            //create the Players
            Console.WriteLine("How many Players are there ?");
            int nbPlayers = Convert.ToInt32(Console.ReadLine());
            while (nbPlayers < 2)
            {
                Console.WriteLine("there must be at least 2 Players. Enter the number of Players again");
                nbPlayers = Convert.ToInt32(Console.ReadLine());
            }
            this.model.Players = new List<Player>();
            for (int i = 0; i < nbPlayers; i++)
            {
                Console.WriteLine("Enter player " + (i + 1) + "'s name");
                string name = Console.ReadLine();
                while (Exist(name))
                {
                    Console.WriteLine("this name is already taken, choose another one");
                    name = Console.ReadLine();
                }
                Console.WriteLine("enter your symbol");
                char symbol = Convert.ToChar(Console.ReadLine());
                while (Exist(symbol))
                {
                    Console.WriteLine("this name is already taken, choose another one");
                    symbol = Convert.ToChar(Console.ReadLine());
                }
                this.model.Players.Add(new Player(name, this.model.Board[0], symbol));
            }
        }

        public void EndGame()
        {
            if (index == 0)
            {
                Console.WriteLine("do you want to stop ?");
                Console.WriteLine("press 1 to stop, or another key to continue");
                string answer = Console.ReadLine();
                if (answer == "1")
                    this.model.End = true;
                
            }
            if (this.model.Players.Count == 1)
                this.model.End = true;
        }

        public int Winner()
        {
            //the winner is the last player, or the one who has the most money if the game is interrupted
            int WinnerIndex = 0;
            int WinnerMoney = 0;
            for (int i = 0; i < this.model.Players.Count; i++)
            {
                if (this.model.Players[i].Balance > WinnerMoney)
                {
                    WinnerIndex = i;
                    WinnerMoney = this.model.Players[i].Balance;
                }
            }
            return WinnerIndex;
        }

        public bool Exist(string name)
        {
            bool exist = false;
            for (int i = 0; i < this.model.Players.Count; i++)
            {
                if (name == this.model.Players[i].Name)
                {
                    exist = true;
                    i = this.model.Players.Count;
                }
            }
            return exist;
        }

        public bool Exist(char symbol)
        {
            bool exist = false;
            for (int i = 0; i < this.model.Players.Count; i++)
            {
                if (symbol == this.model.Players[i].Symbol)
                {
                    exist = true;
                    i = this.model.Players.Count;
                }
            }
            return exist;
        }

        public int SearchPlayerID(string name)
        {
            int id = -1;
            for (int i = 0; i < this.model.Players.Count; i++)
            {
                if (name == this.model.Players[i].Name)
                {
                    id = i;
                    i = this.model.Players.Count;
                }
            }
            return id;
        }

        public void DisplayGame()
        {
            this.view.DisplayGame();
        }
    }
}
