using System;
using System.Collections.Generic;
using System.Text;
namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Monopoly();
            
        }

        static void Monopoly()
        {

            Game game = Game.GetInstance();
            GameController controller = new GameController(game);
            controller.Start();
        }

        public static void couple(int i, int j)
        {
            Console.WriteLine("[" + i + ", " + j + "]");
        }
    }
}
