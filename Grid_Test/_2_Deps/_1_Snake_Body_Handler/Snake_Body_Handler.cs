using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Grid_Test._2_Deps._1_Snake_Body_Handler

{
    class Snake_Body_Handler
    {

        
       public const int snake_Width = 25;
       public const int snake_Height = 25;
       public UIElement uiElement { get; set; }
        public double left_Position {  get; set; }
        public double top_Position {  get; set; }
       
        public bool IsHead {  get; set; }
       






      public  void add_New_Part_To_Body_Of_The_Snake()

        {
                   
            = new Rectangle()
                    {
                        Width = Snake_Parts.snake_Width,
                        Height = Snake_Parts.snake_Height,
                        Fill = Brushes.Yellow,

                    };
            snake_Part.left_Position = get_The_Left_Of_Last_Snake_Part() - Snake_Parts.snake_Width;
            snake_Part.top_Position = get_The_Top_Of_Last_Snake_Part();

                    gameArea.Children.Add(snake_Part.uiElement);
                    list_snakeParts.Add(snake_Part);
                
            
           
        }


     //------------------------------------------------------------------------------------
        private void add_The_Head_Of_The_Snake_To_The_List_Of_Snake_Parts()
        {

            snake_Head.uiElement = new Rectangle()
            {
                Width = Snake_Parts.snake_Width,
                Height = Snake_Parts.snake_Height,
                Fill = Brushes.Red,

            };
            snake_Head.left_Position = 100;
            snake_Head.top_Position = 100;

            gameArea.Children.Add(snake_Head.uiElement);
            list_snakeParts.Add(snake_Head);

            
        }
        //------------------------------------------------------------------------------------
        private void add_New_Part_To_Body_Of_The_Snake()
        {
                    Snake_Parts snake_Part=new Snake_Parts();
                    snake_Part.uiElement = new Rectangle()
                    {
                        Width = Snake_Parts.snake_Width,
                        Height = Snake_Parts.snake_Height,
                        Fill = Brushes.Yellow,

                    };
            snake_Part.left_Position = get_The_Left_Of_Last_Snake_Part() - Snake_Parts.snake_Width;
            snake_Part.top_Position = get_The_Top_Of_Last_Snake_Part();

                    gameArea.Children.Add(snake_Part.uiElement);
                    list_snakeParts.Add(snake_Part);
                
            
           
        }
        //------------------------------------------------------------------------------------







    }
}
