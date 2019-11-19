using System;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = Game.GetInstance();
            Game game2 = Game.GetInstance();
            Console.WriteLine(game == game2);
        }

        static void Monopoly()
        {

            Game game = Game.GetInstance();
            Game game2 = Game.GetInstance();
            Console.WriteLine(game == game2);
            GameView gameView = new GameView();
            GameController controller = new GameController(game, gameView);
            
        }
    }
}
