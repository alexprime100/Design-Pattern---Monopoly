using System;
using System.Collections.Generic;
using System.Text;
namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Monopoly();
            /*List<string> list = new List<string>();
            list.Add("z");
            list.Add("r");
            list.Add("g");
            Console.WriteLine(list.Contains("e"));
            Console.WriteLine(list.Contains("g"));*/
            
            
        }

        static void Monopoly()
        {

            Game game = Game.GetInstance();
            GameController controller = new GameController(game);
            controller.Start();
        }
    }
}
