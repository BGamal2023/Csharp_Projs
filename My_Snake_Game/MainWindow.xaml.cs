using Awaad_Project._0_Draw_The_Snake;
using Awaad_Project._1_Snake_Controlling_Dep;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Awaad_Project
{
 
    public partial class MainWindow : Window
    {
        List<Snake_Parts> list_snakeParts = new List<Snake_Parts>();
        DispatcherTimer myTimer = new DispatcherTimer();
        private int count = 0;
        private double left_Of_Last_Snake_Part;
        private double top_OF_Last_Snake_Part;
        private int snakeLength;
        private Key_Strokes_Handler obj_Moving_The_Snake=new Key_Strokes_Handler();
        private int movingDistance = 50;
        Snake_Parts snake_Head = new Snake_Parts();
        //------------------------------------------------------------------------------------
        public MainWindow()
        {
            InitializeComponent();
            gameArea.Focus();
            start_The_Game();
        }
        //-----------------------------------------------------------------------------------
        private void start_The_Game()
        {
            //draw the snake
            // move and control the snake 
            // food the snake 
            // get snake bigger(draw the snake)

            add_The_Head_Of_The_Snake_To_The_List_Of_Snake_Parts();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();
            add_New_Part_To_Body_Of_The_Snake();

            myTimer.Tick += timer_Tick_Callback;
            myTimer.Interval = TimeSpan.FromMilliseconds(500);
            myTimer.Start();
        }
        //------------------------------------------------------------------------------------
        private void timer_Tick_Callback(object? sender, EventArgs e)
        {
            draw_The_Snake();
            move_And_Control_The_Snake();
        }
        //------------------------------------------------------------------------------------
        private void food_The_Snake()
        {
           
        }
        //------------------------------------------------------------------------------------
        private void draw_The_Snake()
        {
           
           
           

                for (int i = 0; i < list_snakeParts.Count; i++)
                {
                   
                    Canvas.SetLeft(list_snakeParts[i].uiElement, list_snakeParts[i].left_Position);
                    Canvas.SetTop(list_snakeParts[i].uiElement, list_snakeParts[i].top_Position);
                }
            }
        //------------------------------------------------------------------------------------
        private void move_And_Control_The_Snake()
        {
            obj_Moving_The_Snake.move_And_Control_The_Snake_Direction(list_snakeParts, movingDistance, gameArea,mylable);
            

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
        private double get_The_Left_Of_Last_Snake_Part()
        {
            double my_left_Of_Last_Snake_Part=0;

            if(list_snakeParts.Count > 0)
            {
              
                var lastItem = list_snakeParts[^1];
                my_left_Of_Last_Snake_Part = lastItem.left_Position;
            }
           

            return my_left_Of_Last_Snake_Part;

        }
        //------------------------------------------------------------------------------------
        private double get_The_Top_Of_Last_Snake_Part()
        {
            double my_top_Of_Last_Snake_Part = 0;


            if (list_snakeParts.Count > 0)
            {
                var lastItem = list_snakeParts[^1];
                my_top_Of_Last_Snake_Part = lastItem.top_Position;
            }
                
           


            return my_top_Of_Last_Snake_Part;
        }
        //------------------------------------------------------------------------------------
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            obj_Moving_The_Snake.detect_The_Pressed_Keyboard_Key(
                e, list_snakeParts, mylable, movingDistance);
        }
        //------------------------------------------------------------------------------------


    }
}