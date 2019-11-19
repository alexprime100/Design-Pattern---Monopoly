using System;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Monopoly()
        {
            Game game = new Game();
            GameView gameView = new GameView();
            GameController controller = new GameController(game, gameView);
        }
    }
}
