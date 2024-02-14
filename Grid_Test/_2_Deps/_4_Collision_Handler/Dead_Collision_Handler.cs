using Grid_Test.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Grid_Test._2_Deps._4_Collision_Handler
{
    internal class Dead_Collision_Handler
    {
        //-------------------------------------------------------------------------------------------------
        public void detect_The_Dead_Collision()
        {
            //-------------
            UIElement SnakeHead = Globals.list_Snake_Parts[0];
            int curCol_SnakeHead = Grid.GetColumn(SnakeHead);
            int curRow_SnakeHead=Grid.GetRow(SnakeHead);
            //-------------
            for (int i=1; i < Globals.list_Snake_Parts.Count; i++)
            {
                if (
                    curCol_SnakeHead == Grid.GetColumn(Globals.list_Snake_Parts[i])
                    && 
                    curRow_SnakeHead == Grid.GetRow(Globals.list_Snake_Parts[i])
                    )
                {
                    Globals.isDeadCollisionOccurued = true;
                }

            }
        }
        //-------------------------------------------------------------------------------------------------

    }
}
