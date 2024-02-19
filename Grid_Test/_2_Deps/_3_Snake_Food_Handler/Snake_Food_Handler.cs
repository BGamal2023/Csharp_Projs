using Grid_Test.__Globals;
using Grid_Test._2_Deps._1_Snake_Body_Handler;
using Grid_Test._2_Deps._8_Create_Rectangle;
using Grid_Test._2_Deps._9_List_Of_Snake_Parts_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Grid_Test._2_Deps._3_Snake_Food_Handler
{
    internal class Snake_Food_Handler
    {
        //-------------------------------------------------------------------------
        Creating_Rect obj_Creating_Rect = new Creating_Rect();
        List_Of_Snake_Parts_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Parts_Handler();
        //-------------------------------------------------------------------------
        public void feed_The_Snake(Grid gameArea)
        {

            //--
            var nextCol = new Random();
            var nextRow = new Random();
            int counts_Snake_Body = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_list_Of_The_Snake_Parts();
            bool matching = false;
            //--
            do
            {
                int foodCol = nextCol.Next(1, Globals.No_Of_gameArea_Cols - 2);
                int foodRow = nextRow.Next(1, Globals.No_Of_gameArea_Rows - 2);
                //--
                for (int i = 0; i < counts_Snake_Body; i++)
                {
                    var snake_Part = obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(i);
                    int snake_Part_Col = Grid.GetColumn(snake_Part);
                    int snake_Part_Row = Grid.GetRow(snake_Part);
                    if (foodCol == snake_Part_Col && foodRow == snake_Part_Row)
                    {
                        matching = true;
                    }
                    else
                    {
                        matching = false;
                    }
                }
                //--
            } while (matching);
            //--
          var snakeFood=  obj_Creating_Rect.create_Rec(
                gameArea,
                Globals.snake_Food_Color,
                nextCol.Next(0, Globals.No_Of_gameArea_Cols),
                nextRow.Next(0, Globals.No_Of_gameArea_Rows)
                );
            //--
            Globals.list_Snake_Food.Add(snakeFood);
            Globals.isFoodCollisionOccurred = false;
            //--
        }
        //-------------------------------------------------------------------------
        public void eat_Snake_Food(Grid gameArea)
        {
           gameArea.Children.Remove( Globals.list_Snake_Food[0]);
            Globals.list_Snake_Food.Clear();
        }
        //-------------------------------------------------------------------------
     


    }
}
