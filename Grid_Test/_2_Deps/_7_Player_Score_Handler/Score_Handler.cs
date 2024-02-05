using Grid_Test.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Grid_Test._2_Deps._7_Player_Score_Handler
{
    internal class Score_Handler
    {
        public void update_Player_Sore(Label scoreValue)
        {
            scoreValue.Content = Globals.Score;
        }
    }
}
