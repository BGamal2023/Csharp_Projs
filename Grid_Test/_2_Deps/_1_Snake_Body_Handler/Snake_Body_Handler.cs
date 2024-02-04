using Grid_Test.__Globals;
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
        public Snake_Parts snake_Head=new Snake_Parts();
       //------------------------------------------------------------------------------------
        public void add_The_Head_Of_The_Snake_To_The_List_Of_Snake_Parts(Grid gameArea)
        {

            snake_Head.uiElement = new Rectangle()
            {
                Width = Snake_Parts.snake_Width,
                Height = Snake_Parts.snake_Height,
                Fill = Brushes.Red,
                Stroke= Brushes.Black,
                StrokeThickness = 1


            };
            snake_Head.left_Position = 100;
            snake_Head.top_Position = 100;

            gameArea.Children.Add(snake_Head.uiElement);
            Grid.SetColumn(snake_Head.uiElement, 8);
            Grid.SetRow(snake_Head.uiElement, 5);
            
            Globals.list_Snake_Parts.Add(snake_Head);

            
        }
        //------------------------------------------------------------------------------------
        public void add_New_Part_To_Body_Of_The_Snake(Grid gameArea)
        {
                    Snake_Parts snake_Part=new Snake_Parts();
            snake_Part.uiElement = new Rectangle()
            {
                Width = Snake_Parts.snake_Width,
                Height = Snake_Parts.snake_Height,
                Fill = Brushes.Green,
                Stroke = Brushes.Black,
                StrokeThickness = 1

                    };
            snake_Part.left_Position = get_The_Left_Of_Last_Snake_Part() - Snake_Parts.snake_Width;
            snake_Part.top_Position = get_The_Top_Of_Last_Snake_Part();

            gameArea.Children.Add(snake_Part.uiElement);
            Globals.list_Snake_Parts.Add(snake_Part);
                
            
           
        }
        //------------------------------------------------------------------------------------
        public double get_The_Left_Of_Last_Snake_Part()
        {
            double my_left_Of_Last_Snake_Part=0;

            if (Globals.list_Snake_Parts.Count > 0)
            {
              
                var lastItem = Globals.list_Snake_Parts[^1];
                my_left_Of_Last_Snake_Part = lastItem.left_Position;
            }
           

            return my_left_Of_Last_Snake_Part;

        }
        //------------------------------------------------------------------------------------
        public double get_The_Top_Of_Last_Snake_Part()
        {
            double my_top_Of_Last_Snake_Part = 0;


            if (Globals.list_Snake_Parts.Count > 0)
            {
                var lastItem = Globals.list_Snake_Parts[^1];
                my_top_Of_Last_Snake_Part = lastItem.top_Position;
            }
                
           


            return my_top_Of_Last_Snake_Part;
        }
     
        //------------------------------------------------------------------------------------
        public void add_New_Part_To_The_gameArea(){
        }
        public void draw_The_Snake(){

        }



    }
}
