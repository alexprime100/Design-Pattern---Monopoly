using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class GameView
    {
        public void DisplayGame(Game g, string name)
        {
            int ObserverId = 0;
            for (int i = 0; i < g.Observers.Count; i++)
            {
                if (g.Observers[i].Name == name)
                {
                    ObserverId = i;
                    i = g.Observers.Count;
                }
            }
            g.Observers[ObserverId].update();
        }
    }
}
