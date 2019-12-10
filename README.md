# Design-Pattern---Monopoly
Description of the classes:
We implemented 8 classes for the main Monopoly game, plus 7 card classes for the different types of “Chance” cards, as well as 7 classes for the implementation of the Observer design pattern.
All costs and prices are of type int because there are no cents in the original game of Monopoly
The main Monopoly game classes:
-	The Position class defines a space having:
o	An index (int: from 0 to 39) defining the position on the board
o	A name (string: for example, « Belleville’s Boulevard “)
o	An additional text (string: for example, “You’re at the “)
o	An owner of type Player (if it exists)
o	A buying price (int)
o	A rent (int)
o	A number of houses (int)
o	A list of Players currently on this position
o	A bool Go To Jail (only true for position 30)
o	A bool Visit Jail (only true for position 10)
o	A bool buy (only true if it is possible to buy this place)
-	The Neighbourhood class defines how to handle houses creation when a player has got all the streets from the same neighbourhood. Its attributes are: 
o	A name (string: corresponding to a colour in the physical game)
o	An identifier (id)
o	A list of avenues identifiers (int)
o	The cost of building a house (int)
o	An index corresponding to the index of the next house being built (int)
-	The Dice class defines the dices and has a function to throw them. It consists of:
o	An array of int from 1 to 6
o	The current value of the dice (int)
o	The roll function (a void that changes the current face)

-	The Player class defines Players having:
o	A name (string)
o	A sign used to for console display (char)
o	A current position (Object of type Position)
o	A list of properties (objects of type Position)
o	A list of possessed neighbourhoods (objects of type neighbourhood)
o	A balance (int)
o	A bool Jail (true if the player is in jail)
o	A bool play (true if the player is playing)
o	The number of consecutive turns (limited to 3 before having to go to jail)
-	The cell class handles displaying a position. It has:
o	A two-dimensional array of type char
o	An index of the corresponding position on the board (int)
-	The GameBoard class handles displaying the board, it has two attributes:
o	A two-dimensional array of type Cell, initialized as 11 by 11 in the constructor
o	The size corresponding to the size of a cell (int) initialized as 6 in the constructor

-	The Game class defines the current game and has 
o	An array of Positions used for all interactions between players and cells 
o	A GameBoard attribute to handle the display of the board
o	A list of Neighbourhoods
o	A list of Players
o	A list of cards
o	A list of observers used to update and display information about the board and the players
o	A bool end (false until some player decides to quit the game or is out of money) to quit the program
o	A static instance of type Game for the Singleton pattern.
o	Two Dice objects because the user throws two dices per turn

-	The GameController class is the most important class of the program. It has two attributes, the model and the index of the current player, and 31 methods which will be described here:
o	void Initialization (): this method gives values to all 40 positions of the board and calls the other initialization methods.
o	void NamesInitialization (): Gives a name to all 40 cells of the board.
o	void TextInitialization (): Sets up the text to display before the name
o	void PricesInitialization (): Sets up the price of each cell.
o	void RentsInitialization (): Sets up the price to pay for each cell if a player ends up on it and someone previously bought it.
o	void NeighbourhoodInitialization (): Creates neighbourhoods objects grouping every 2 or three adjacent avenues to recreate the same neighbourhoods as in the original game.
o	void OtherInitialization (): Sets up the Boolean visitJail and GoToJail to true for respectively position 10 and 30. Sets up the Buy values to false for every positon other than those a player can buy.
o	void InitializationBoard(): Sets up the board. As in the original game, the board is a 11 by 11 square with the cells on the sides. The empty space inside the big square is filled anyway with cells but in that case, as the empty constructor is called, the cells are filled with spaces.
o	void CardsInitialization (): Adds different “Chance” cards to the model.
o	void Start (): This is the method to be launch in the Program.cs class. Therefore, all the program revolves around this method. It starts by calling the initialization method previously explained, then adds players into the model, the list of players of this model and to the board and creates observers on the players and the board which are also added to the model. Then, it calls the update and displays methods of the model. Finally, the start function enters a loop for the proceeding of the game until the bool End of the model is set to true, which consists of: setting the bool Play of the current player to true, another loop calling the PlayATurn method until the end of the current player’s turn, then check if the balance of the player fell to 0 during his turn. If that is the case, the player and its observers are removed from the game. Then if the balance didn’t fell to 0, the number of consecutive turns of the player is set back to 0 and the index is incremented so in the next iteration of the loop, it is to the next player to play. At the end of this loop, the name of the winning player is displayed at the screen.
o	void PlayATurn (): This method only calls the Roll and PositionAction methods.
o	void PositionAction ():  This method handles events occurring when a Player steps on a specific position. It displays the text corresponding to the cell, asks the player if he wants to buy the cell (if possible) by calling the function BuyAPlace, operates the transaction between two players if the current player steps on a propriety by calling the function PayRent. If the player steps on a cell with a value of Rent not null but is not buyable, it is a tax cell and the rent of this cell is subtracted from the player’s balance. We mustn’t forget to call the update method of model.Observer to update the player’s money. If the position achieved is neither a tax or a buyable spot, we check if it corresponds to position 30, if so the player stepped on the jail cell and he must be moved to position 10, which is done by removing him from the list of players of the index 30 of model.Board and adding him to the list of players of index 10 of model.Board, as well as changing his attribute position to model.Board[10], the Boolean attributes Play and Jail are obviously set to false and true after this step and the method MovePlayer(30,10) is called to make the changes on the gameboard attribute of the model. If the player has stepped on a position where the name value is “Luck”, he must draw a card from the “Chance” deck. This is done by creating a random object named rand and an int object named rnd which will be any integer between 0 to the number of total “Luck” cards. Then, it calls the Action method from Icard interface, to execute the card’s action. If the luck card’s effect is to move the player, we perform the displacement by calling MovePlayer on the previous position and the new position, then calling PositionAction again to check if the new position triggers an action. If the card is not a displacement card we just update the model via model.Observers[index].update(null, model.Players[index]).
o	void Roll (): This method handles the events occurring while throwing the dices. It displays information on the screen such as who is playing and what to do to play. It asks if the user wants to check his properties and if he wants to build a house if he can. Then, the user must press a key to call the jailRoll function (if he is in jail) or roll his two dices. The result of each dice is displayed, and they are added together. Then, the position of the player is updated, and its former position is removed from the board. Then, the method checks if the player went through the starting point, if so, adds 200 euros to his balance. After these steps, we must call the player’s observer to update his balance. The position is set back between 0 and 39 with the operation %= 40. The MovePlayer method is called to make the changes on the player’s position. After this, we check if the player has rolled a double, if so the number of consecutive turns is incremented otherwise the bool play of the Player is set to false to exit the loop. Finally, we check if the value of consecutive turns is 3, if so, it is set back to 0 and the players goes to jail (position 10), meaning we change the value of the bool Play to false and the bool Jail to true and MovePlayer is called again to move to position 10.
o	void MovePlayer(int index1, int index2): this method is called every time a function from the controller moves the position of a player on the board. We need to call this method to move the player on the board otherwise its position would be changed but it would still be present on the board. We use the SearchStreetIndexes method wich is described lower. This method returns the position on the board given the position of the player. Then, we remove this player on the board position obtained and add it to the new board position. It is also in this method that we call the Display() method of the model’s observer and show the board to the user.
o	void BuildHouses (): This method is called when the player presses “1” when asked if he wants to check his possessions if he owns all the streets for a same neighbourhood. The method is built around a loop because we wanted to make it possible to build as many houses as possible(but with a limit of 8 houses per street) in a single turn (at the end of the code we ask the user if he wants to continue to build houses and the loop ends if he presses another key than “1”). The method starts by displaying all the neighbourhoods in which the player can build houses. Then, the user must enter the id (Nid in the code) of the neighbourhood he wants to start building. Then, if there is no previously built house in the neighbourhood, we ask the user where he wants to build the first one by asking for the street id. We check if this id corresponds to a street with the ExistStreet method (described lower). We ask him how many houses he wants to build at a time. Then, for each house to be build we check if the player has enough money to buy it and if the number of houses on this street is less than 8, in which case this is not possible to build anymore, and we display a message at the screen and exit the loop. Then, the number of houses is incremented, the rent is doubled on the selected street and the price of the house is subtracted from the player’s balance. After this, we add into a first list the indexes of the selected street on the game board and into a second list the street index. Then, we can add a house to the board with the method AddHouse (described lower) given the street indexes as parameters. We must update the observers on the board and the player after this process. We use for updating the board observer the first list containing board indexes and to update the player observer we use the second list containing the street indexes. Finally, we display the board to the user and ask him if he wants to start over the process in a different neighbourhood.
o	void jailRoll (): This method is called in Roll if the value of Player.Jail is true. It increments the value of JailTurn, rolls the dices and if the value of JailTurn is 3 or if the player gets a double it moves the player the same way as in the Roll method. Otherwise, the function ends by setting the bool Play of Player to false, which ends the turn of the current player.
o	void BuyAPlace (): This method is called when a player ends his turn on a buyable spot. If the player presses “1”, we check if he has enough money to buy the corresponding street. If so, we subtract from his balance the price of the street and change the owner of the street to the current player. Then, we add the street to the list of properties of this player, sort this list by index and update the observer on the player. We inform the user that the transaction is complete and check if the property bought is a train station, if so, we call UpdateStationRent (described lower), if not we check if the property bought is not a company, if so, we call CheckForNeighbourhood (described lower), if not we call UpdateCompaniesRent (described lower).
o	void CheckforNeighbourhood (int avenueIndex): This method is called from BuyAPlace and is used to inform the player if he obtained all the pieces of a neighbourhood. This is done by obtaining the id of the neighbourhood of the purchased street from BuyAPlace with SearchNeighbourhoodID(avenueIndex) (described lower). We check for each street in this neighbourhood if it is present in the list of properties of the current player and if not the bool value CompleteNeighbourhood is set to false. If that is not the case, we write a message on the screen to tell the player he got all the pieces of this neighbourhood. Then, we double all the rents of the streets of this neighbourhood. We add all the streets to a list of ints to update the observer with these streets and the position of the player. Finally, we ask the user if he wants to build houses, if so we call the BuildHouses method.
o	int SearchNeighbourhoodID (int avenueIndex): To find the id of the neighbourhood by having the index of street as a parameter, this method runs through all the streets in two for loops. The first one runs through all neighbourhoods and inside this one the second one runs through all streets. If the street index as parameter matches a street index, the two loops end and the value of the iterator in the first loop corresponds to the neighbourhood id.
o	void PayRent (): This function informs the current player of his price to pay to the other player and subtract the rent of the street to the balance of the current player. Then, with the method SearchPlayerID (described lower) we search for the id of the owner of the street and add to his balance the amount paid by the current player. After this, we call the update method of the observer of the current player as well as the observer of the owner of the street. If the position the current player stepped on is a distribution company, we must multiply the rent by the total number of two dices so the steps explained above do not change except we roll two dices at the beginning and multiply this result to the rent of the street. 
o	void UpdateStationRent (): This method is called in BuyAPlace when a player buys a train station. The rent to pay for a train station is proportional to the number of train station owned by the owner as in the original Monopoly game. This is done by filling a list of ints with the indexes of train stations owned by the current player and every time an index is added to the list an int coefficient is multiplied by two. After these steps we multiply by the coefficient previously calculated all the rents of the stations. Also, we have to create a list of int[] named indexes filled with the indexes of train stations owned by the current player to update the observers of the current player.
o	void UpdateCompaniesRent (): This method is called from BuyAPlace if the user buys position 12 or 28. The rule of companies in the original Monopoly game is that you have to multiply the result of a dice by the rent of the company and if you have both of the companies the rent increase. This method’s purpose is to increase the rent of the companies if the user owns both. 
o	void PlayersCreation (): This method can create from 2 to 8 players and asks the user the name and sign used to represent it on the board for of each player. A player can choose any char value but ‘#’ (which will be used to represent the houses), space, ‘-‘ and ‘|’ because these two chars are used for the board’s borders, also we check that no two players have the same name or char. Once the user has selected a name and char, it is added to the list of players in the model and a PlayerObserver is created for him. Finally, we create the board observer here and add it to the model.
o	void Endgame (): This method is called in the Start method when every player has played a turn. If the user presses “1”, we exit from the loop of Start by setting the bool end value to true, which will end the program.
o	int Winner (): This method returns the index of the winning player after the end of the game. This is done by checking for the player who has the biggest value of Balance and return its index.
o	bool Exists (string name): This method is used every time we need to check if a player exists. This is done by checking if the name in parameter is the same for each player. If we find a player that corresponds to the name in parameter, we return true.
o	bool Exists (char symbol): Same as the previous method but to check if a player has the char symbol in parameter.
o	bool existNeighbourhood (int id): Used in BuildHouses to check if a player owns a whole neighbourhood. If this function returns true, it will be possible for the current player to start building houses on this neighbourhood.
o	bool existStreet (int StreetId, int Nid): This method checks if the street in parameter belongs to the neighbourhood in parameter and returns true if that is the case.
o	int SearchPlayerID(string name): This method is like the Exist(string name) method except it returns the id of the player and not a bool.
o	int[] SearchStreetIndexes(int id): This method is used in the MovePlayer method of GameController. It returns the position on the board of a player given its position index. 



The first design pattern we implemented is the MVC architecture. The model is represented by the Game class because it is the class that stores all the information about the current game. The controller is the GameController class as it is the class containing all the methods and program logic. The view is handled by the observer pattern.

There are two types of observers. One for the board and one for the players (each player has an observer). To create them we used a factory pattern. The interface IObserver lists the two fundamental methods of observers: update and display. As we can only play one game at a time, we created a singleton pattern for the Game class. 
-	The board observer changes the game board into a two-dimensional array of type char with the method ConvertToCharMatrix, which is called into the constructor. It displays the different cells containing the borders (chars ‘-‘ and ‘|’), the list of players on the cells (represented by their symbol) and the houses built (represented by the char ‘#’). The central part of the board is not used and represented by spaces. At the beginning of the game, the board is entirely converted to a two-dimensional array of chars but after, when a cell is modified (by the movement of a player or the building of a house for example) only the part of the array corresponding to the modified cell is changed with the update method.
-	The player observer has two parameters
o	A copy of the associated player to access to his information. When the attributes of a player are modified (during a transaction for example) the attributes of the copy are actualised by the update method.
o	The list of properties of the player. A special class formed of a cell and a description is created. Indeed, every time a cell owned by the player is modified (during buying, house building for example) the description is updated with the update method. Then, the display method enables to display the balance of the player and the list of properties. For the properties the method only displays the description.
The “Chance” cards are created with a factory pattern as well. The factory enables us to have three different classes of cards, one for each type of action the card does. All cards implement the interface Icard which specifies that each card must implement a method named Action of type Player with a Player parameter. Each card has a type of card, a message, and an amount of money or a street’s position. The three types of cards are:
-	MoveCard. This is the cards specifying the user must move to a certain position on the board. In this case the action method sets the player’s position to the one specified during the creation of the card along with the street name which correspond to the message of the card.
-	PayCard. These cards ask the player to pay a certain amount of money. In this case the action method subtracts the amount of money from the balance of the player and the message displayed is the amount of money.
-	MoneyCard. These cards tell the player he has won money. In this case the action method adds to the balance of the player the amount of money specified during the creation of the card and the message is the amount won.	
