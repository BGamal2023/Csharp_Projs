using Grid_Test.__Globals;
using Grid_Test._2_Deps._9_List_Of_Snake_Parts_Handler;
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
            List_Of_Snake_Parts_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Parts_Handler();
            //-------------
            UIElement SnakeHead = obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(0);
            int curCol_SnakeHead = Grid.GetColumn(SnakeHead);
            int curRow_SnakeHead=Grid.GetRow(SnakeHead);
            //-------------
           int listCount= obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_list_Of_The_Snake_Parts();
            for (int i=1; i < listCount; i++)
            {
                var currItem=obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(i);
                if (
                    curCol_SnakeHead == Grid.GetColumn(currItem)
                    && 
                    curRow_SnakeHead == Grid.GetRow(currItem)
                    )
                {
                    Globals.isDeadCollisionOccurued = true;
                }

            }
        }
        //-------------------------------------------------------------------------------------------------

    }
}
