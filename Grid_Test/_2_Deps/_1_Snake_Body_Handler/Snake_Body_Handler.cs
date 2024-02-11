using Grid_Test.__Globals;
using Grid_Test._2_Deps._8_Create_Rectangle;
using Grid_Test.My_Libs.My_Lib_1;
using Grid_Test.My_Libs.My_Lib_1.Globals;
using System;
using System.Collections.Generic;
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
        //---------------------------------------------------------------------------------------
        public void add_The_Head_Of_The_Snake_To_The_List_Of_Snake_Parts(Grid gameArea)
        {

         obj_Creating_Rect.create_Rec(gameArea, Globals.snake_Head_Color,
                                   Globals.snake_Head_X, Globals.snake_Head_Y,
                                   Globals.list_Snake_Parts);
           
           
            
        }
        //---------------------------------------------------------------------------------------
        public void add_New_Part_To_Body_Of_The_Snake(Grid gameArea)
        {

            var last_Snake_Part= Globals.list_Snake_Parts[^1];

            if (Global_Directions.goRight)
            {

                add_During_Moving_Right
                    ( gameArea,Globals.snake_Body_Color,
                     Grid.GetColumn(last_Snake_Part) - 1,
                     Grid.GetRow(last_Snake_Part));
               
            }
            else if(Global_Directions.goLeft)
            {

                add_During_Moving_Left(gameArea,
              Globals.snake_Body_Color,
              Grid.GetColumn(last_Snake_Part) + 1,
              Grid.GetRow(last_Snake_Part));
               
            }
            else if(Global_Directions.goUp)
            {
                add_During_Moving_UP(
                    gameArea,
              Globals.snake_Body_Color,
              Grid.GetColumn(last_Snake_Part),
              Grid.GetRow(last_Snake_Part) - 1);
              
            }
            else if (Global_Directions.goDown)
            {
                add_During_Moving_Down(
                      gameArea,
              Globals.snake_Body_Color,
              Grid.GetColumn(last_Snake_Part),
              Grid.GetRow(last_Snake_Part) + 1);
              
            }
           

           
        }
        //---------------------------------------------------------------------------------------
        private void add_During_Moving_Down(
            Grid gameArea,
            Brush color,
            int X,
            int Y)
        {
         obj_Creating_Rect.create_Rec(gameArea,
                color,
              X,
              Y,
              Globals.list_Snake_Parts);
           
        }
        //---------------------------------------------------------------------------------------
        private void add_During_Moving_UP(Grid gameArea,
            Brush color,
            int X,
            int Y)
        {
         obj_Creating_Rect.create_Rec(gameArea,
                color,
              X,
              Y,
              Globals.list_Snake_Parts);
        }
        //---------------------------------------------------------------------------------------
        private void add_During_Moving_Left(Grid gameArea,
            Brush color,
            int X,
            int Y)
        {


         obj_Creating_Rect.create_Rec(gameArea,
                color,
              X,
              Y,
              Globals.list_Snake_Parts);
        }
        //---------------------------------------------------------------------------------------
        private void add_During_Moving_Right(Grid gameArea,
            Brush color,
            int X,
            int Y)
        {

         obj_Creating_Rect.create_Rec(gameArea,
                 color,
               X,
               Y,
              Globals.list_Snake_Parts);

        }
        //---------------------------------------------------------------------------------------
       
      
           
    }
}
