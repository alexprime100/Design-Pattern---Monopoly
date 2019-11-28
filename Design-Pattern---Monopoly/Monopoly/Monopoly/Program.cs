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
            /*List<string> list = new List<string>();
            list.Add("z");
            list.Add("r");
            list.Add("g");
            Console.WriteLine(list.Contains("e"));
            Console.WriteLine(list.Contains("g"));*/
            //Console.WriteLine(16 / 6);
            MyCardFactory cf = new MyCardFactory();
            MoveCard card = (MoveCard)cf.CreateCard(CardType.MoveCard, "");
            MoveCard card2 = (MoveCard)cf.CreateCard(CardType.MoveCard, "");

            
            
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
