using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class GameController
    {
        private Game model;
        private int index;                //index of the player who is playing

        public GameController(Game model)
        {
            this.model = model;
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
            InitializationBoard();
            //ObserversInitialization();

            CardsInitialization();
        }

        public void NamesInitialization()
        {
            this.model.Board[0].Name = "Starting Point";

            this.model.Board[1].Name = "Belleville's Boulevard";
            this.model.Board[2].Name = "Luck";
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
            this.model.Board[17].Name = "Luck";
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
            this.model.Board[33].Name = "Luck";
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
            this.model.Board[27].Price = 260;
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

            this.model.Board[12].Rent = 4;
            this.model.Board[28].Rent = 4;

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
            this.model.BoardGame.TheBoard[0, 0] = new Cell( this.model.Board[20].Index);
            this.model.BoardGame.TheBoard[0, 10] = new Cell( this.model.Board[30].Index);
            this.model.BoardGame.TheBoard[10, 0] = new Cell(this.model.Board[10].Index);
            this.model.BoardGame.TheBoard[10, 10] = new Cell(this.model.Board[0].Index);
            for (int j = 1; j < 10; j++)
            {
                this.model.BoardGame.TheBoard[0, j] = new Cell(this.model.Board[20 + j].Index);
                this.model.BoardGame.TheBoard[10, j] = new Cell(this.model.Board[10 - j].Index);
                this.model.BoardGame.TheBoard[j, 10] = new Cell(this.model.Board[30 + j].Index);
                this.model.BoardGame.TheBoard[j, 0] = new Cell(this.model.Board[20 - j].Index);
            }
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    this.model.BoardGame.TheBoard[i, j] = new Cell();
                }
            }

        }

        public void ObserversInitialization()
        {
            MyObserverFactory of = new MyObserverFactory();
            BoardObserver board = (BoardObserver)of.CreateObserver(ObserverType.BoardObserver, this.model.BoardGame);
            this.model.Observers.Add(board);
        }

        public void CardsInitialization()
        {
            MyCardFactory cf = new MyCardFactory();
            //Money Cards
            this.model.Cards.Add((MoneyCard)cf.CreateCard(CardType.MoneyCard, "Bank is versing you ", 50));
            this.model.Cards.Add((MoneyCard)cf.CreateCard(CardType.MoneyCard, "your building is paying back, you earn ", 150));
            this.model.Cards.Add((MoneyCard)cf.CreateCard(CardType.MoneyCard, "Congratulations, you won the crosswords competition, you earn ", 100));
            this.model.Cards.Add((MoneyCard)cf.CreateCard(CardType.MoneyCard, "Bank is reimbursing you ", 20));
            this.model.Cards.Add((MoneyCard)cf.CreateCard(CardType.MoneyCard, "You inherit ", 100));
            this.model.Cards.Add((MoneyCard)cf.CreateCard(CardType.MoneyCard, "Your sale is paying back, you earn ",50 ));
            this.model.Cards.Add((MoneyCard)cf.CreateCard(CardType.MoneyCard, "you earn your annual income : ", 100));
            this.model.Cards.Add((MoneyCard)cf.CreateCard(CardType.MoneyCard, "Congratulations, you won the beauty competition, you earn ",100));
            this.model.Cards.Add((MoneyCard)cf.CreateCard(CardType.MoneyCard, "receive your interest at 7% ", 25));
            this.model.Cards.Add((MoneyCard)cf.CreateCard(CardType.MoneyCard, "Bank error in your favor, you earn ",200));

            //pay cards
            this.model.Cards.Add((PayCard)cf.CreateCard(CardType.PayCard, "Pay your insurance : ", 200));
            this.model.Cards.Add((PayCard)cf.CreateCard(CardType.PayCard, "Pay the hospital : ",100));
            this.model.Cards.Add((PayCard)cf.CreateCard(CardType.PayCard, "Pay the doctor : ", 50));
            this.model.Cards.Add((PayCard)cf.CreateCard(CardType.PayCard, "fine for drunkenness", 20));
            this.model.Cards.Add((PayCard)cf.CreateCard(CardType.PayCard, "pay the school fees ",150));
            this.model.Cards.Add((PayCard)cf.CreateCard(CardType.PayCard, "fine for speeding ",15));
            
            //move cards
            this.model.Cards.Add((MoveCard)cf.CreateCard(CardType.MoveCard, "", 0, this.model.Board[0]));
            this.model.Cards.Add((MoveCard)cf.CreateCard(CardType.MoveCard, "", 0, this.model.Board[0]));
            this.model.Cards.Add((MoveCard)cf.CreateCard(CardType.MoveCard, "", 0, this.model.Board[30]));
            this.model.Cards.Add((MoveCard)cf.CreateCard(CardType.MoveCard, "", 0, this.model.Board[1]));
            this.model.Cards.Add((MoveCard)cf.CreateCard(CardType.MoveCard, "", 0, this.model.Board[30]));
            this.model.Cards.Add((MoveCard)cf.CreateCard(CardType.MoveCard, "", 0, this.model.Board[11]));
            this.model.Cards.Add((MoveCard)cf.CreateCard(CardType.MoveCard, "", 0, this.model.Board[15]));
            this.model.Cards.Add((MoveCard)cf.CreateCard(CardType.MoveCard, "", 0, this.model.Board[39]));
            this.model.Cards.Add((MoveCard)cf.CreateCard(CardType.MoveCard, "", 0, this.model.Board[24]));


        }

        public void Start()
        {
            this.initialization();
            
            //PlayersCreation();
            this.model.Players.Add(new Player("alex", this.model.Board[0], '+'));
            this.model.Players.Add(new Player("damien", this.model.Board[0], '*'));
            MyObserverFactory of = new MyObserverFactory();
            PlayerObserver al = (PlayerObserver)of.CreateObserver(ObserverType.PlayerObserver, null, this.model.Players[0]);
            PlayerObserver da = (PlayerObserver)of.CreateObserver(ObserverType.PlayerObserver, null, this.model.Players[1]);

            BoardObserver bo = (BoardObserver)of.CreateObserver(ObserverType.BoardObserver, this.model.BoardGame);
            this.model.Observers.Add(al);
            this.model.Observers.Add(da);
            this.model.Observers.Add(bo);
            foreach(Player p in this.model.Players)
            {
                this.model.Board[0].ListPlayers.Add(p);
                this.model.BoardGame.TheBoard[10, 10].AddPlayer(p);
            }
            /*for (int i = 0; i < this.model.Observers.Count; i++)
            {
                Console.WriteLine(i + " " + this.model.Observers[i].name);
            }
            Console.ReadKey();*/
            int[] indexes = new int[] { 10, 10 };
            List<int[]> ids = new List<int[]>();
            ids.Add(indexes);
            this.model.Observers[this.model.Observers.Count - 1].update(ids, null, false, this.model.BoardGame);
            //Console.WriteLine("ok0");
            this.model.Observers[this.model.Observers.Count-1].Display();
            //Console.WriteLine("ok1");
            while (!this.model.End)  //while the game continues
            {
                this.model.Players[index].Play = true;    //Player index plays
                while (this.model.Players[index].Play)
                {
                    PlayATurn();
                }

                if (this.model.Players[index].Balance == 0)    //if this player is ruined, he is removed
                {
                    this.model.Players.RemoveAt(index);
                    this.model.Observers.RemoveAt(index);
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

        public void PlayATurn()
        {
            Roll();
            PositionAction();
        }

        public void PositionAction()
        {
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
                        Console.WriteLine("Congratulations, you earned " + (-this.model.Players[index].Position.Rent) + " Euros !");
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
                    this.model.Observers[index].update(null, this.model.Players[index]);
                }
                else
                {
                    if (this.model.Players[index].Position.Index == 30)
                    {
                        Console.WriteLine("YOU GO TO JAIL");
                        Console.ReadKey();
                        this.model.Players[index].ConsecutivesTurns = 0;
                        this.model.Players[index].Position = this.model.Board[10];
                        this.model.Board[30].ListPlayers.Remove(this.model.Players[index]);
                        this.model.Board[10].ListPlayers.Add(this.model.Players[index]);
                        this.model.Players[index].Play = false;
                        this.model.Players[index].Jail = true;
                        MovePlayer(30, 10);
                    }
                    else
                    {
                        if (this.model.Players[index].Position.Name == "Luck")
                        {
                            Console.WriteLine("press any key to pick a card");
                            Console.ReadKey();
                            Random rand = new Random();
                            int rnd = rand.Next(16, this.model.Cards.Count);
                            int positionIndex = this.model.Players[index].Position.Index;
                            this.model.Players[index] = this.model.Cards[rnd].Action(this.model.Players[index]);

                            if (this.model.Cards[rnd].GetType() == this.model.Cards[16].GetType())   //if it was a MoveCard
                            {
                                Console.WriteLine("you're moving to " + this.model.Players[index].Position.Name);
                                MovePlayer(positionIndex, this.model.Players[index].Position.Index);
                                PositionAction();          //the player is now on a new street, so the game has to execute this function again
                            }
                            else
                            {
                                this.model.Observers[index].update(null, this.model.Players[index]);
                            }
                        }
                    }
                    
                }
            }
        }

        public void Roll()
        {
            //asks to phe player if he wants to check his money and properties
            Console.WriteLine(this.model.Players[index].Name + " plays");
            Console.WriteLine("do you want to check your money and your properties or to build houses somewhere? press 1 to see");

            string answer = Console.ReadLine();
            if (answer == "1")
            {
                this.model.Observers[index].Display();    //displays player's money and properties

                if (this.model.Players[index].Neighborhoods.Count > 0)      //if the player ownes at least one complete neighborhood he can build houses
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
                jailRoll();
            }
            else
            {
                //the program randomly rolls the dices
                this.model.D1.roll();
                Console.WriteLine("Dice 1 : " + this.model.D1.CurrentFace);
                this.model.D2.roll();
                Console.WriteLine("Dice 2 : " + this.model.D2.CurrentFace);
                Console.WriteLine("total roll : " + Convert.ToString(this.model.D1.CurrentFace + this.model.D2.CurrentFace));

                int InitialPositionIndex = this.model.Players[index].Position.Index;
                int PositionIndex = InitialPositionIndex;
                this.model.Board[PositionIndex].ListPlayers.Remove(this.model.Players[index]);    //the player lefts his former position
                
                PositionIndex += this.model.D1.CurrentFace + this.model.D2.CurrentFace;
                if (PositionIndex > 40)          //the player earns 200euros if he goes through the starting point
                {
                    this.model.Players[index].Balance += 200;
                    Console.WriteLine("you earned 200Euros!");
                }
                this.model.Observers[index].update(null, this.model.Players[index]);         //the player's observer updates his money

                PositionIndex %= 40;
                this.model.Players[index].Position = this.model.Board[PositionIndex];
                this.model.Board[PositionIndex].ListPlayers.Add(this.model.Players[index]);        //the player arrives at his new position
                Console.ReadKey();
                MovePlayer(InitialPositionIndex, PositionIndex);              //the player moves on the board

                if (this.model.D1.CurrentFace != this.model.D2.CurrentFace)
                {
                    this.model.Players[index].Play = false;
                }
                else
                {
                    this.model.Players[index].ConsecutivesTurns++;
                }
                if (this.model.Players[index].ConsecutivesTurns == 3)
                {
                    Console.WriteLine("YOU GO TO JAIL");
                    Console.ReadKey();
                    this.model.Players[index].ConsecutivesTurns = 0;
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

            this.model.Observers[this.model.Observers.Count - 1].update(indexes, null, false, this.model.BoardGame);
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

                int Nid = -1;                  //Nid is the neighborhood's index
                while (!ExistNeighborhood(Nid))      //the program checks if this index exists
                {
                    Console.WriteLine("enter the id of the neighborhood where you want to build houses");
                    Nid = Convert.ToInt32(Console.ReadLine());
                }

                if (this.model.ListNeighborhood[Nid].CurrentIndex < 0)           //if there are no houses in this neighborhood
                {
                    Console.WriteLine("where do you want to build the first house ?");
                    foreach (int i in this.model.Players[index].Neighborhoods[Nid].Avenues)
                        Console.WriteLine(this.model.Board[i].Name + "(id = " + i + ")");

                    int Sid = -1;              //Sid is the street's index
                    while (!ExistStreet(Sid, Nid))         //the program checks if this id exists
                    {
                        Console.WriteLine("enter the  street id");
                        Sid = Convert.ToInt32(Console.ReadLine());
                    }
                    //currentIndex is the street's index where the next house will be built
                    this.model.ListNeighborhood[Nid].CurrentIndex = this.model.Players[index].Neighborhoods[Nid].Avenues.IndexOf(Sid);
                }

                int Nhouses = -1;
                while (Nhouses < 0)
                {
                    Console.WriteLine("how many houses do you want to build ?");
                    Nhouses = Convert.ToInt32(Console.ReadLine());
                }

                List<int[]> Indexes1 = new List<int[]>();              //this list contains the streets' indexes in the matrix board. it will be used to update the board's observer
                List<int[]> Indexes2 = new List<int[]>();              //this list contains the street's index. it will be used to update the players's observer

                for (int i = 0; i < Nhouses; i++)
                {
                    int streetIndex = this.model.ListNeighborhood[Nid].Avenues[this.model.ListNeighborhood[Nid].CurrentIndex];

                    if (this.model.Players[index].Balance >= this.model.ListNeighborhood[Nid].HousePrice && this.model.Board[streetIndex].HousesNumber < 8)       //if the player has enough money to build this house
                    {
                        this.model.Board[streetIndex].HousesNumber++;      //the program adds a house on this street
                        this.model.Board[streetIndex].Rent *= 2;             //the rent is doubled
                        this.model.Players[index].Balance -= this.model.ListNeighborhood[Nid].HousePrice;             //the player's money is updated
                        
                        //the programs searches the street's indexes in the matrix board
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
                        this.model.ListNeighborhood[Nid].CurrentIndex %= this.model.ListNeighborhood[Nid].Avenues.Count;
                    }
                    else
                    {
                        if (this.model.Players[index].Balance < this.model.ListNeighborhood[Nid].HousePrice)
                            Console.WriteLine("You don't have enough money to build more houses");
                        if (this.model.Board[streetIndex].HousesNumber >= 8)
                            Console.WriteLine("you cannot build more than 8 houses on a street");
                        i = Nhouses;
                    }
                                        
                }
                this.model.Observers[this.model.Observers.Count - 1].update(Indexes1, null, false, this.model.BoardGame);
                this.model.Observers[index].update(Indexes2, this.model.Players[index]);

                this.model.Observers[this.model.Observers.Count - 1].Display();
                Console.WriteLine("Do you want to build houses in another neighborhood ? (Press 1)");
                string answer = Console.ReadLine();
                if (answer != "1")
                    Continue = false;
            }
            
        }

        public void jailRoll()
        {
            this.model.Players[index].JailTurn++;
            this.model.D1.roll();
            Console.WriteLine("Dice 1 : " + this.model.D1.CurrentFace);
            this.model.D2.roll();
            Console.WriteLine("Dice 2 : " + this.model.D2.CurrentFace);
            Console.WriteLine("total roll : " + Convert.ToString(this.model.D1.CurrentFace + this.model.D2.CurrentFace));
            if (this.model.Players[index].JailTurn > 3 || this.model.D1.CurrentFace == this.model.D2.CurrentFace)
            {
                this.model.Board[10].ListPlayers.Remove(this.model.Players[index]);
                this.model.Players[index].JailTurn = 0;
                int PositionIndex = 10;
                PositionIndex += this.model.D1.CurrentFace + this.model.D2.CurrentFace;
                this.model.Players[index].Position = this.model.Board[PositionIndex];
                this.model.Board[PositionIndex].ListPlayers.Add(this.model.Players[index]);
                MovePlayer(10, PositionIndex);
                this.model.Players[index].Jail = false;
                this.model.Players[index].Play = false;
            }
            else
                this.model.Players[index].Play = false;
            
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
                    this.model.Observers[index].update(null, this.model.Players[index], true);
                    
                    if (this.model.Players[index].Position.Index % 10 == 5)      //if the property is a train station
                    {
                        UpdateStationRent();
                    }
                    else
                    {
                        if (this.model.Players[index].Position.Index != 12 && this.model.Players[index].Position.Index != 28)   //if the property is not a company
                        {
                            CheckForNeighborhood(this.model.Players[index].Position.Index);
                        }
                        else
                        {
                            UpdateCompaniesRent();
                        }
                    }
                }
            }
        }

        public void CheckForNeighborhood(int avenueIndex)
        {
            //check if the player ownes every other streets of the neighborhood
            bool CompleteNeighborhood = true;
            int NeighborhoodID = SearchNeighborhoodID(avenueIndex);     //searches the neighborhood's id
            foreach(int i in this.model.ListNeighborhood[NeighborhoodID].Avenues)     //if there is one street in the neighborhood that the player doesn't owne, the neighborhood is not owned
            {
                if (!this.model.Players[index].Properties.Contains(this.model.Board[i]))
                    CompleteNeighborhood = false;
            }
            if (CompleteNeighborhood)
            {
                Console.WriteLine("Congratulations, now you owe the whole " + this.model.ListNeighborhood[NeighborhoodID].Name + " neighborhood!");
                Console.WriteLine("every rents are doubled, and you can add houses!");
                foreach (int i in this.model.ListNeighborhood[NeighborhoodID].Avenues)     //every rents are doubled
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
            bool Continue = true;
            for (int i = 0; i < this.model.ListNeighborhood.Count && Continue; i++)
            {
                for (int j = 0; j < this.model.ListNeighborhood[i].Avenues.Count && Continue; j++)
                {
                    if (avenueIndex == this.model.ListNeighborhood[i].Avenues[j])
                    {
                        NeighborhoodID = i;
                        Continue = false;
                    }
                }
            }
            return NeighborhoodID;
        }

        public void PayRent()
        {
            if (this.model.Players[index].Position.Index == 12 || this.model.Players[index].Position.Index == 28)
            {
                int totalRoll = this.model.D1.CurrentFace + this.model.D1.CurrentFace;
                Console.WriteLine("you owe " + (this.model.Players[index].Position.Rent * totalRoll) + " Euros to " + this.model.Players[index].Position.Owner.Name);
                this.model.Players[index].Balance -= this.model.Players[index].Position.Rent * totalRoll;       //the player's money is updated
                int idPlayer = SearchPlayerID(this.model.Players[index].Position.Owner.Name);       //search of the owner's index
                this.model.Players[idPlayer].Balance += this.model.Players[index].Position.Rent * totalRoll;    //the owner's money is updated
                this.model.Observers[index].update(null, this.model.Players[index]);
                this.model.Observers[idPlayer].update(null, this.model.Players[idPlayer]);
            }
            else
            {
                Console.WriteLine("you owe " + this.model.Players[index].Position.Rent + " Euros to " + this.model.Players[index].Position.Owner.Name);
                this.model.Players[index].Balance -= this.model.Players[index].Position.Rent;       //the player's money is updated
                int idPlayer = SearchPlayerID(this.model.Players[index].Position.Owner.Name);       //search of the owner's index
                this.model.Players[idPlayer].Balance += this.model.Players[index].Position.Rent;    //the owner's money is updated
                this.model.Observers[index].update(null, this.model.Players[index]);
                this.model.Observers[idPlayer].update(null, this.model.Players[idPlayer]);
            }
            
        }

        public void UpdateStationRent()
        {
            List<int> listStations = new List<int>();
            int coefficient = 1;
            for (int i = 0; i < 4; i++)
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

        public void UpdateCompaniesRent()
        {
            if (this.model.Board[12].Owner == this.model.Players[index] && this.model.Board[28].Owner == this.model.Players[index])
            {
                this.model.Board[12].Rent = 10;
                this.model.Board[28].Rent = 10;
            }
        }

        public void PlayersCreation()
        {
            //create the Players
            Console.WriteLine("there must be at least 2 Players, and at most 8 players");
            Console.WriteLine("How many Players are there ?");
            int nbPlayers = Convert.ToInt32(Console.ReadLine());
            while (nbPlayers < 2 || nbPlayers > 8)
            {
                Console.WriteLine("there must be at least 2 players, and at most 8 players. Enter the number of Players again");
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
                Console.WriteLine("enter a symbol (type char) for your pawn");
                char symbol = Convert.ToChar(Console.ReadLine());
                while (Exist(symbol) || symbol == '#' || symbol == ' ' || symbol == '-' || symbol == '|')    //'#' is used to represent houses, '-' and '|' are used for the board's borders
                {
                    Console.WriteLine("sorry, this symbol is already taken by another player or already used by the game, please choose another one");
                    symbol = Convert.ToChar(Console.ReadLine());
                }
                
                this.model.Players.Add(new Player(name, this.model.Board[0], symbol));
                PlayerObserver po = (PlayerObserver)of.CreateObserver(ObserverType.PlayerObserver, null, this.model.Players[this.model.Players.Count - 1]);
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

        public int[] SearchStreetIndexes(int id)
        {
            //searches a street's indexes in the matrix board
            int[] indexes = new int[2];
            bool end = false;
            for (int j = 0; j <= 10 && !end; j++)
            {
                if (this.model.BoardGame.TheBoard[j,0].Street == id)
                {
                    indexes[0] = j;
                    indexes[1] = 0;
                    end = true;
                }
                if (this.model.BoardGame.TheBoard[j, 10].Street == id)
                {
                    indexes[0] = j;
                    indexes[1] = 10;
                    end = true;
                }
                if (this.model.BoardGame.TheBoard[0, j].Street == id)
                {
                    indexes[0] = 0;
                    indexes[1] = j;
                    end = true;
                }
                if (this.model.BoardGame.TheBoard[10, j].Street == id)
                {
                    indexes[0] = 10;
                    indexes[1] = j;
                    end = true;
                }
                if (end)
                    j = 11;
            }
            return indexes;
        }

    }
}
