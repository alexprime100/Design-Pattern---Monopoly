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
        }

        public void initialization()
        {
            for (int i = 0; i < 40; i++)
            {
                this.model.Board[i] = new Position(i);
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
            NeighborhoodInitialization();
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
            this.model.Board[0].Rent = -200;   //the 200euros from the starting point are considered as a negative rent to pay

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

        public void NeighborhoodInitialization()
        {
            this.model.ListNeighborhood = new List<Neighborhood>();

            Neighborhood Pink = new Neighborhood("Pink", 0, 50);
            Pink.Avenues.Add(this.model.Board[1].Index);
            Pink.Avenues.Add(this.model.Board[3].Index);
            this.model.ListNeighborhood.Add(Pink);

            Neighborhood LightBlue = new Neighborhood("LightBlue", 1, 50);
            LightBlue.Avenues.Add(this.model.Board[6].Index);
            LightBlue.Avenues.Add(this.model.Board[8].Index);
            LightBlue.Avenues.Add(this.model.Board[9].Index);
            this.model.ListNeighborhood.Add(LightBlue);

            Neighborhood Purple = new Neighborhood("Purple", 2, 100);
            LightBlue.Avenues.Add(this.model.Board[11].Index);
            LightBlue.Avenues.Add(this.model.Board[13].Index);
            LightBlue.Avenues.Add(this.model.Board[14].Index);
            this.model.ListNeighborhood.Add(Purple);

            Neighborhood Orange = new Neighborhood("Orange", 3, 100);
            LightBlue.Avenues.Add(this.model.Board[16].Index);
            LightBlue.Avenues.Add(this.model.Board[18].Index);
            LightBlue.Avenues.Add(this.model.Board[19].Index);
            this.model.ListNeighborhood.Add(Orange);

            Neighborhood Red = new Neighborhood("Red", 4, 150);
            LightBlue.Avenues.Add(this.model.Board[21].Index);
            LightBlue.Avenues.Add(this.model.Board[23].Index);
            LightBlue.Avenues.Add(this.model.Board[24].Index);
            this.model.ListNeighborhood.Add(Red);

            Neighborhood Yellow = new Neighborhood("Yellow", 5, 150);
            LightBlue.Avenues.Add(this.model.Board[26].Index);
            LightBlue.Avenues.Add(this.model.Board[27].Index);
            LightBlue.Avenues.Add(this.model.Board[29].Index);
            this.model.ListNeighborhood.Add(Yellow);

            Neighborhood Green = new Neighborhood("Green", 6, 200);
            LightBlue.Avenues.Add(this.model.Board[31].Index);
            LightBlue.Avenues.Add(this.model.Board[32].Index);
            LightBlue.Avenues.Add(this.model.Board[34].Index);
            this.model.ListNeighborhood.Add(Green);

            Neighborhood DarkBlue = new Neighborhood("DarkBlue", 7, 200);
            LightBlue.Avenues.Add(this.model.Board[37].Index);
            LightBlue.Avenues.Add(this.model.Board[39].Index);
            this.model.ListNeighborhood.Add(DarkBlue);


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
            this.model.Board[17].Buy = false;
            this.model.Board[20].Buy = false;
            this.model.Board[22].Buy = false;
            this.model.Board[30].Buy = false;
            this.model.Board[33].Buy = false;
            this.model.Board[36].Buy = false;
            this.model.Board[38].Buy = false;


        }

        public void InitializationBoard()
        {
            this.model.BoardGame.TheBoard[0, 0].Street = this.model.Board[20].Index;
            this.model.BoardGame.TheBoard[0, 0].FillCell();
            this.model.BoardGame.TheBoard[0, 10].Street = this.model.Board[30].Index;
            this.model.BoardGame.TheBoard[0, 10].FillCell();
            this.model.BoardGame.TheBoard[10, 0].Street = this.model.Board[10].Index;
            this.model.BoardGame.TheBoard[10, 0].FillCell();
            this.model.BoardGame.TheBoard[10, 10].Street = this.model.Board[0].Index;
            this.model.BoardGame.TheBoard[10, 10].FillCell();
            for (int j = 1; j < 10; j++)
            {
                this.model.BoardGame.TheBoard[0, j].Street = this.model.Board[20 + j].Index;
                this.model.BoardGame.TheBoard[0, j].FillCell();
                this.model.BoardGame.TheBoard[10, j].Street = this.model.Board[10 - j].Index;
                this.model.BoardGame.TheBoard[10, j].FillCell();
                this.model.BoardGame.TheBoard[j, 10].Street = this.model.Board[30 + j].Index;
                this.model.BoardGame.TheBoard[j, 10].FillCell();
                this.model.BoardGame.TheBoard[j, 0].Street = this.model.Board[20 - j].Index;
                this.model.BoardGame.TheBoard[j, 0].FillCell();
            }
            for (int i = 0; i < this.model.BoardGame.Lenght; i++)
            {
                for (int j = 0; j < this.model.BoardGame.Lenght; j++)
                {
                    this.model.BoardGame.TheBoard[i, j].FillNullCell();
                }
            }

        }

        public void ObserversInitialization()
        {
            MyObserverFactory of = new MyObserverFactory();
            BoardObserver board = (BoardObserver)of.CreateObserver(ObserverType.BoardObserver, this.model.BoardGame);
            this.model.Observers.Add(board);
        }

        public void Start()
        {
            this.initialization();
            //create dices
            Dice d1 = new Dice();
            Dice d2 = new Dice();

            PlayersCreation();

            foreach(Player p in this.model.Players)
            {
                this.model.Board[0].ListPlayers.Add(p);
                this.model.BoardGame.TheBoard[10, 10].AddPlayer(p);
            }

            while (!this.model.End)  //while the game continues
            {
                this.model.Players[index].Play = true;    //Player index plays
                while (this.model.Players[index].Play)
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
            Console.WriteLine(this.model.Players[winner].Name + "!!!");
        }

        public void PlayATurn(Dice d1, Dice d2)
        {
            Roll(d1, d2);
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
                    if (this.model.Players[index].Position.Rent < 0)     //if the player earned money
                    {
                        Console.WriteLine("Congratulations, you earned " + (- this.model.Players[index].Position.Rent) + " Euros !");
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

        public void Roll(Dice d1, Dice d2)
        {
            Console.WriteLine(this.model.Players[index].Name + " plays");
            Console.WriteLine("do you want to check your money and your properties or to build houses somewhere? press 1 to see");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                this.model.Observers[index].Display();

                if (this.model.Players[index].Neighborhoods.Count > 0)
                {
                    Console.WriteLine("Do you want to build houses somewhere ? Press 1 to build houses");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "1")
                        BuildHouses();
                }
            }

            Console.WriteLine("Press any key to roll the dices");
            Console.ReadKey();
            if (this.model.Players[index].Jail)
            {
                jailRoll(d1, d2);
            }
            else
            {
                d1.roll();
                Console.WriteLine("Dice 1 : " + d1.CurrentFace);
                d2.roll();
                Console.WriteLine("Dice 2 : " + d2.CurrentFace);
                Console.WriteLine("total roll : " + Convert.ToString(d1.CurrentFace + d2.CurrentFace));

                int InitialPositionIndex = this.model.Players[index].Position.Index;
                int PositionIndex = InitialPositionIndex;
                this.model.Board[PositionIndex].ListPlayers.Remove(this.model.Players[index]);
                /**/
                PositionIndex += d1.CurrentFace + d2.CurrentFace;
                if (PositionIndex > 40)
                {
                    this.model.Players[index].Balance += 200;
                    Console.WriteLine("you earned 200Euros!");
                }
                this.model.Observers[index].update(null, this.model.Players[index]);

                PositionIndex %= 40;
                this.model.Players[index].Position = this.model.Board[PositionIndex];
                this.model.Board[PositionIndex].ListPlayers.Add(this.model.Players[index]);
                
                MovePlayer(InitialPositionIndex, PositionIndex);

                if (d1.CurrentFace != d2.CurrentFace)
                {
                    this.model.Players[index].Play = false;
                }
                else
                {
                    this.model.Players[index].ConsecutivesTurns++;
                }
                if (this.model.Players[index].Position.Index == 30 || this.model.Players[index].ConsecutivesTurns == 3)
                {
                    Console.WriteLine("YOU GO TO JAIL");
                    this.model.Players[index].ConsecutivesTurns = 1;
                    this.model.Players[index].Position = this.model.Board[10];
                    this.model.Board[PositionIndex].ListPlayers.Remove(this.model.Players[index]);
                    this.model.Board[10].ListPlayers.Add(this.model.Players[index]);
                    this.model.Players[index].Play = false;
                    this.model.Players[index].Jail = true;
                    MovePlayer(PositionIndex, 10);
                }
            }
        }

        public void MovePlayer(int index1, int index2)
        {
            List<int[]> indexes = new List<int[]>();
            indexes.Add(SearchStreetIndexes(index1));
            int i = indexes[0][0];
            int j = indexes[0][1];
            this.model.BoardGame.TheBoard[i, j].RemovePlayer(this.model.Players[index]);

            indexes.Add(SearchStreetIndexes(index2));
            i = indexes[1][0];
            j = indexes[1][1];
            this.model.BoardGame.TheBoard[i, j].AddPlayer(this.model.Players[index]);

            this.model.Observers[this.model.Observers.Count - 1].update(indexes, null, this.model.BoardGame);
            this.model.Observers[this.model.Observers.Count - 1].Display();
        }

        public void BuildHouses()
        {
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("you can build houses in the following neighborhoods");
                foreach (Neighborhood n in this.model.Players[index].Neighborhoods)
                    Console.WriteLine(n.Name + " neighborhood (id = " + n.ID + ")");
                int Nid = -1;
                while (!ExistNeighborhood(Nid))
                {
                    Console.WriteLine("enter the id of the neighborhood where you want to build houses");
                    Nid = Convert.ToInt32(Console.ReadLine());
                }
                if (this.model.ListNeighborhood[Nid].CurrentIndex < 0)
                {
                    Console.WriteLine("where do you want to build the first house ?");
                    foreach (int i in this.model.Players[index].Neighborhoods[Nid].Avenues)
                        Console.WriteLine(this.model.Board[i].Name + "(id = " + i + ")");

                    int Sid = -1;
                    while (ExistStreet(Sid, Nid))
                    {
                        Console.WriteLine("enter the  street id");
                        Sid = Convert.ToInt32(Console.ReadLine());
                    }
                    this.model.ListNeighborhood[Nid].CurrentIndex = this.model.Players[index].Neighborhoods[Nid].Avenues.IndexOf(Sid);
                }
                int Nhouses = -1;
                while (Nhouses < 0)
                {
                    Console.WriteLine("how many houses do you want to build ?");
                    Nhouses = Convert.ToInt32(Console.ReadLine());
                }
                List<int[]> Indexes1 = new List<int[]>();
                List<int[]> Indexes2 = new List<int[]>();
                for (int i = 0; i < Nhouses; i++)
                {
                    if (this.model.Players[index].Balance >= this.model.ListNeighborhood[Nid].HousePrice)
                    {
                        this.model.Board[this.model.ListNeighborhood[Nid].Avenues[this.model.ListNeighborhood[Nid].CurrentIndex]].HousesNumber++;
                        this.model.Board[this.model.ListNeighborhood[Nid].Avenues[this.model.ListNeighborhood[Nid].CurrentIndex]].Rent *= 2;
                        this.model.Players[index].Balance -= this.model.ListNeighborhood[Nid].HousePrice;
                        
                        int[] indexes1 = SearchStreetIndexes(this.model.Board[this.model.ListNeighborhood[Nid].Avenues[this.model.ListNeighborhood[Nid].CurrentIndex]].Index);
                        if (!Indexes1.Contains(indexes1))
                            Indexes1.Add(indexes1);

                        /*for (int k = 0; k < this.model.Players[index].Properties.Count; k++)
                        {
                            if (this.model.Players[index].Properties[k].Index == this.model.Board[this.model.ListNeighborhood[Nid].Avenues[this.model.ListNeighborhood[Nid].CurrentIndex]].Index)
                            {
                                Indexes2.Add(new int[] { k });
                            }
                        }*/
                        foreach(int x in this.model.ListNeighborhood[Nid].Avenues)
                        {
                            Indexes2.Add(new int[] { x });
                        }

                        this.model.BoardGame.TheBoard[indexes1[0], indexes1[1]].AddHouse();
                        this.model.ListNeighborhood[Nid].CurrentIndex++;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money to build more houses");
                        i = Nhouses;
                    }
                                        
                }
                this.model.Observers[this.model.Observers.Count - 1].update(Indexes1, null, this.model.BoardGame);
                this.model.Observers[index].update(Indexes2, this.model.Players[index]);

                this.model.Observers[this.model.Observers.Count - 1].Display();
                Console.WriteLine("Do you want to build houses in another neighborhood ? (Press 1)");
                string answer = Console.ReadLine();
                if (answer != "1")
                    Continue = false;
            }
            
        }

        public void jailRoll(Dice d1, Dice d2)
        {
            this.model.Players[index].JailTurn++;
            d1.roll();
            d2.roll();
            if (this.model.Players[index].JailTurn > 3 || d1.CurrentFace == d2.CurrentFace)
            {
                this.model.Board[10].ListPlayers.Remove(this.model.Players[index]);
                this.model.Players[index].JailTurn = 0;
                int PositionIndex = 10;
                PositionIndex += d1.CurrentFace + d2.CurrentFace;
                this.model.Players[index].Position = this.model.Board[PositionIndex];
                this.model.Board[PositionIndex].ListPlayers.Add(this.model.Players[index]);
                MovePlayer(10, PositionIndex);
            }
            this.model.Players[index].Jail = false;
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
                    Console.WriteLine("you don't have enough money to buy this place");
                }
                else
                {
                    this.model.Players[index].Balance -= this.model.Players[index].Position.Price;     //the player's money is updated
                    this.model.Players[index].Position.Owner = this.model.Players[index];              //the place's owner is updated
                    this.model.Players[index].Properties.Add(this.model.Players[index].Position);          //the place is added to the player's properties
                    this.model.Players[index].Properties.Sort();                                     //the list is sorted by index
                    Console.WriteLine("Congratulations, now you owe " + this.model.Players[index].Position.Name);
                    CheckForNeighborhood(this.model.Players[index].Position.Index);
                    if (this.model.Players[index].Position.Index % 10 + 5 == 0)      //if the property is a train station
                    {
                        UpdateStationRent();
                    }
                    List<int[]> indexes = new List<int[]>();
                    indexes.Add(new int[] { this.model.Players[index].Position.Index, this.model.Players[index].Properties.IndexOf(this.model.Players[index].Position) });
                    this.model.Observers[index].Add(this.model.Players[index]);

                }
                
                
                
            }
        }

        public void CheckForNeighborhood(int avenueIndex)
        {
            //check if the player ownes every other streets of the neighborhood
            bool CompleteNeighborhood = true;
            int NeighborhoodID = SearchNeighborhoodID(avenueIndex);
            foreach(int i in this.model.ListNeighborhood[NeighborhoodID].Avenues)
            {
                if (!this.model.Players[index].Properties.Contains(this.model.Board[i]))
                    CompleteNeighborhood = false;
            }
            if (CompleteNeighborhood)
            {
                Console.WriteLine("Congratulations, now you owe the whole " + this.model.ListNeighborhood[NeighborhoodID].Name + " neighborhood!");
                Console.WriteLine("every rents are doubled, and you can add houses!");
                foreach (int i in this.model.ListNeighborhood[NeighborhoodID].Avenues)
                {
                    this.model.Board[i].Rent *= 2;
                }
                this.model.Players[index].Neighborhoods.Add(this.model.ListNeighborhood[NeighborhoodID]);

                List<int[]> indexes = new List<int[]>();
                foreach (int x in this.model.ListNeighborhood[NeighborhoodID].Avenues)
                    indexes.Add(new int[] { x });
                this.model.Observers[index].update(indexes, this.model.Players[index]);
                Console.WriteLine("Do you want to build houses now ? (press 1)");
                string answer = Console.ReadLine();
                if (answer == "1")
                    BuildHouses();
            }
        }

        public int SearchNeighborhoodID(int avenueIndex)
        {
            int NeighborhoodID = -1;
            for (int i = 0; i < this.model.ListNeighborhood.Count; i++)
            {
                for (int j = 0; j < this.model.ListNeighborhood[i].Avenues.Count; j++)
                {
                    if (avenueIndex == this.model.ListNeighborhood[i].Avenues[j])
                    {
                        NeighborhoodID = i;
                        i = this.model.ListNeighborhood.Count;
                        j = this.model.ListNeighborhood[i].Avenues.Count;
                    }
                }
            }
            return NeighborhoodID;
        }

        public void PayRent()
        {
            Console.WriteLine("you owe " + this.model.Players[index].Position.Rent + " Euros to " + this.model.Players[index].Position.Owner.Name);
            this.model.Players[index].Balance -= this.model.Players[index].Position.Rent;       //the player's money is updated
            int idPlayer = SearchPlayerID(this.model.Players[index].Position.Owner.Name);       //search of the owner's index
            this.model.Players[idPlayer].Balance += this.model.Players[index].Position.Rent;    //the owner's money is updated
            this.model.Observers[index].update(null, this.model.Players[index]);
            this.model.Observers[idPlayer].update(null, this.model.Players[idPlayer]);
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
            List<int[]> indexes = new List<int[]>();
            for (int i = 0; i < listStations.Count; i++)
            {
                this.model.Board[listStations[i]].Rent *= coefficient/2;
                indexes.Add(new int[] { listStations[i] });
            }
            this.model.Observers[index].update(indexes, this.model.Players[index]);
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
            MyObserverFactory of = new MyObserverFactory();

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
                while (symbol == '#' || symbol == ' ')
                {
                    Console.WriteLine("Sorry, but this symbol is already used by the game, please choose another one");
                    symbol = Convert.ToChar(Console.ReadLine());
                }

                this.model.Players.Add(new Player(name, this.model.Board[0], symbol));
                PlayerObserver po = (PlayerObserver)of.CreateObserver(ObserverType.PlayerObserver);
                this.model.Observers.Add(po);
            }

            BoardObserver board = (BoardObserver)of.CreateObserver(ObserverType.BoardObserver, this.model.BoardGame);
            this.model.Observers.Add(board);
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

        public bool ExistNeighborhood(int id)
        {
            bool exist = false;
            for (int i = 0; i < this.model.Players[index].Neighborhoods.Count; i++)
            {
                if (id == this.model.Players[index].Neighborhoods[i].ID)
                {
                    exist = true;
                }
            }
            return exist;
        }

        public bool ExistStreet(int StreetId, int Nid)
        {
            bool exist = false;
            for (int i = 0; i < this.model.Players[index].Neighborhoods[Nid].Avenues.Count; i++)
            {
                if (StreetId == this.model.Players[index].Neighborhoods[Nid].Avenues[i])
                {
                    exist = true;
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

        public int[] SearchStreetIndexes(int index)
        {
            int[] indexes = new int[2];
            for (int j = 0; j <= 10; j++)
            {
                if (this.model.BoardGame.TheBoard[j,0].Street == index)
                {
                    indexes[0] = j;
                    indexes[1] = 0;
                    j = 11;
                }
                if (this.model.BoardGame.TheBoard[j, 10].Street == index)
                {
                    indexes[0] = j;
                    indexes[1] = 10;
                    j = 11;
                }
                if (this.model.BoardGame.TheBoard[0, j].Street == index)
                {
                    indexes[0] = 0;
                    indexes[1] = j;
                    j = 11;
                }
                if (this.model.BoardGame.TheBoard[10, j].Street == index)
                {
                    indexes[0] = 10;
                    indexes[1] = j;
                    j = 11;
                }
            }
            return indexes;
        }

        public void DisplayGame()
        {
            //this.view.DisplayGame();
        }

    }
}
