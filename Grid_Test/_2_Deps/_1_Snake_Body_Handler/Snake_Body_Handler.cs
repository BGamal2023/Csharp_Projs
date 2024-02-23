using Grid_Test.__Globals;
using Grid_Test._2_Deps._8_Create_Rectangle;
using Grid_Test._2_Deps._9_List_Of_Snake_Parts_Handler;
using Grid_Test.My_Libs.My_Lib_1;
using Grid_Test.My_Libs.My_Lib_1.Globals;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Grid_Test._2_Deps._1_Snake_Body_Handler

{
    class Snake_Body_Handler
    {
        //---------------------------------------------------------------------------------------
        Creating_Rect obj_Creating_Rect =new Creating_Rect();
        List_Of_Snake_Parts_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Parts_Handler();
        //---------------------------------------------------------------------------------------
        public void add_The_Head_Of_The_Snake_To_The_List_Of_Snake_Parts(Grid gameArea)
        {
            //---------------
            var snakeHead =obj_Creating_Rect.create_Rec (gameArea, Globals.snake_Head_Color,Globals.snake_Head_X, Globals.snake_Head_Y);
            //---------------
            obj_List_Of_Snake_Parts_Handler.add_To_The_List(snakeHead);
            //---------------
        }
        //---------------------------------------------------------------------------------------
        public void add_New_Part_To_Body_Of_The_Snake(Grid gameArea)
        {
            //---------------
            var last_Snake_Part = obj_List_Of_Snake_Parts_Handler.get_The_Last_Item_In_The_List();
            //---------------
            if (Global_Directions.goRight)
            {
                //------
                int X = Grid.GetColumn(last_Snake_Part) - 1;
                int Y = Grid.GetRow(last_Snake_Part);
                if (X < 0)
                {
                    X = 0;
                }
                //------
                add_During_Moving(gameArea, Globals.snake_Body_Color, X, Y);
                //------
            }
            //---------------
            else if (Global_Directions.goLeft)
            {
                //------
                int X = Grid.GetColumn(last_Snake_Part) + 1;
                int Y = Grid.GetRow(last_Snake_Part);
              
                //------
                add_During_Moving(gameArea, Globals.snake_Body_Color, X, Y);
                //------
            }
            //---------------
            else if (Global_Directions.goUp)
            {
                //--
                int X = Grid.GetColumn(last_Snake_Part) ;
                int Y = Grid.GetRow(last_Snake_Part) + 1;
                //--
                add_During_Moving(gameArea, Globals.snake_Body_Color, X, Y);
                //--
            }
            //---------------
            else if (Global_Directions.goDown)
            {
                //--
                
                int X = Grid.GetColumn(last_Snake_Part);
                int Y = Grid.GetRow(last_Snake_Part)-1;
                if (Y < 0)
                {
                    Y = 0;
                }
                //--
                add_During_Moving(gameArea, Globals.snake_Body_Color, X, Y);
                //--
            }
            //---------------
        }
        //---------------------------------------------------------------------------------------
        private void add_During_Moving (Grid gameArea,Brush color,int X,int Y)
        {     
        //! bug#10 rename this method again
            //------
            var newRec = obj_Creating_Rect.create_Rec(gameArea, Globals.snake_Body_Color, X, Y);
            //------
            obj_List_Of_Snake_Parts_Handler.add_To_The_List(newRec);
            //------
        }
        //---------------------------------------------------------------------------------------



    }
}
