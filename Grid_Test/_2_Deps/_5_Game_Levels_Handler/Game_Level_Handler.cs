using Grid_Test.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Grid_Test._2_Deps._5_Game_Levels_Handler
{
    internal class Game_Level_Handler
    {
        public void update_Game_Level(DispatcherTimer gameTimer)
        {
            if (Globals.list_Snake_Parts.Count == Globals.Score_Level_1)
            {
                Globals.Level = 1;
                Globals.timerTick = Globals.level_1_speed;

                gameTimer.Interval = TimeSpan.FromMilliseconds(Globals.timerTick);

            }
            else if (Globals.list_Snake_Parts.Count == Globals.Score_Level_2)
            {
                Globals.Level = 2;
                Globals.timerTick = Globals.level_2_speed;
                gameTimer.Interval = TimeSpan.FromMilliseconds(Globals.timerTick);

            }
            else if (Globals.list_Snake_Parts.Count == Globals.Score_Level_3)
            {
                Globals.Level = 3;
                Globals.timerTick = Globals.level_3_speed;
                gameTimer.Interval = TimeSpan.FromMilliseconds(Globals.timerTick);

            }
        }
    }
}
