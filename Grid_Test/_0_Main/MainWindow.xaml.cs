using Grid_Test._2_Deps._2_Snake_Moving_Handler;
using Grid_Test.My_Libs.My_Lib_1.Globals;
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

namespace Grid_Test

{
    //! bug #0 bug in move .....durin down if you rapidly press left then up ...the snake befor 
    //! go left it will move up


    //! i am try to test   draw_The_Snake_V2(); it need to be tested again 


    public partial class MainWindow : Window
    {
        
        bool goUp;
        bool goDown;
        bool goLeft;
        bool goRight;
        DispatcherTimer myTimer=new DispatcherTimer();
        List<UIElement> list_snake_parts= new List<UIElement>();
        Dictionary<String, int> dic_Positions_At_Pres_Right = new Dictionary<string, int>();
        Dictionary<String, int> dic_Positions_At_Pres_Left = new Dictionary<string, int>();
        Dictionary<String, int> dic_Positions_At_Pres_UP = new Dictionary<string, int>();
        Dictionary<String, int> dic_Positions_At_Pres_Down = new Dictionary<string, int>();
        Snake_Moving_Handler obj_Control_The_Snake_Moving=new Snake_Moving_Handler();
        Dictionary<string, int> dic_Positions_At_Pres_Dire=new Dictionary<string, int>();






        public MainWindow()
        {
            InitializeComponent();
            gameArea.Focus();
            myTimer.Tick += timer_Tick_Callback;
            myTimer.Interval = TimeSpan.FromMilliseconds(500);
            myTimer.Start();

         

        }

        private void timer_Tick_Callback(object? sender, EventArgs e)
        {
           
            
            draw_The_Snake_V2();

        }

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    if (goDown == false)
                    {
                        goUp = true;
                        goDown = false;
                        goRight = false;
                        goLeft = false;
                        mylabel.Content = "Up key";
                    }
                    break;

                case Key.Down:
                    if (goUp == false)
                    {
                        goDown = true;
                        goUp = false;
                        goRight = false;
                        goLeft = false;
                        mylabel.Content = "Down key";

                    }
                    break;

                case Key.Left:
                    if (goRight == false)
                    {
                        goLeft = true;
                        goDown = false;
                        goUp = false;
                        goRight = false;
                        mylabel.Content = "Left key";
                    }
                    break;

                case Key.Right:
                    if (goLeft == false)
                    {
                        goRight = true;
                        goDown = false;
                        goUp = false;
                        goLeft = false;
                        mylabel.Content = "Right key";
                    }
                    break;

                case Key.Space:
                    mylabel.Content = "space key";
                   
                    break;
            }
        }

        private void draw_The_Snake()
        {
            UIElement[] arr_Snake_Parts = [Head, body1, body2, body3, body4, body5, body6, body7];
            if (goRight)
            {

                go_Awaad_Right_V2(arr_Snake_Parts, dic_Positions_At_Pres_Left);


                /*   for (int i = 1; i < arr_Snake_Parts.Length; i++)
                   {
                       go_Awaad_Right(arr_Snake_Parts[i - 1], arr_Snake_Parts[i]);
                   }*/


            }
            else if (goLeft)
            {

                go_Awaad_Left(arr_Snake_Parts, dic_Positions_At_Pres_Left);
                
               
                

   
                /*
                                int head_Col_At_Pressing_Left = get_Col_Pos(Head);
                                int head_Row_At_Pressed_Left = get_Row_Pos(Head);

                                int At_Pre_body1_Col_b_1 = Grid.GetColumn(body1);
                                int At_Pre_body1_Row_b1 = Grid.GetRow(body1);

                                int At_Pre_body1_Col_b_2 = Grid.GetColumn(body2);
                                int At_Pre_body1_Row_b2 = Grid.GetRow(body2);

                                int At_Pre_body1_Col_b_3 = Grid.GetColumn(body3);
                                int At_Pre_body1_Row_b3 = Grid.GetRow(body3);

                                int At_Pre_body1_Col_b_4 = Grid.GetColumn(body4);
                                int At_Pre_body1_Row_b4 = Grid.GetRow(body4);

                                int At_Pre_body1_Col_b_5 = Grid.GetColumn(body5);
                                int At_Pre_body1_Row_b5 = Grid.GetRow(body5);

                                int At_Pre_body1_Col_b_6 = Grid.GetColumn(body6);
                                int At_Pre_body1_Row_b6 = Grid.GetRow(body6);*/
              
                   
               
/*
                Grid.SetColumn(Head, next_Col_For_Snake_Head);
                Grid.SetRow(Head, head_Row_At_Pressed_Left);

                Grid.SetColumn(body1, head_Col_At_Pressing_Left);
                Grid.SetRow(body1, head_Row_At_Pressed_Left);

                Grid.SetColumn(body2, At_Pre_body1_Col_b_1);
                Grid.SetRow(body2, At_Pre_body1_Row_b1);

                Grid.SetColumn(body3, At_Pre_body1_Col_b_2);
                Grid.SetRow(body3, At_Pre_body1_Row_b2);

                Grid.SetColumn(body4, At_Pre_body1_Col_b_3);
                Grid.SetRow(body4, At_Pre_body1_Row_b3);

                Grid.SetColumn(body5, At_Pre_body1_Col_b_4);
                Grid.SetRow(body5, At_Pre_body1_Row_b4);

                Grid.SetColumn(body6, At_Pre_body1_Col_b_5);
                Grid.SetRow(body6, At_Pre_body1_Row_b5);

                Grid.SetColumn(body7, At_Pre_body1_Col_b_6);
                Grid.SetRow(body7, At_Pre_body1_Row_b6);*/
            }
            else if (goDown)
            {



               
                int At_Pressed_Col_player=Grid.GetColumn(Head);
                int At_Pressed_Row_player=Grid.GetRow(Head);
           

                int At_Pre_body1_Col_b_1 = Grid.GetColumn(body1);
                int At_Pre_body1_Row_b1 = Grid.GetRow(body1);

                int At_Pre_body1_Col_b_2 = Grid.GetColumn(body2);
                int At_Pre_body1_Row_b2 = Grid.GetRow(body2);

                int At_Pre_body1_Col_b_3 = Grid.GetColumn(body3);
                int At_Pre_body1_Row_b3 = Grid.GetRow(body3);

                int At_Pre_body1_Col_b_4 = Grid.GetColumn(body4);
                int At_Pre_body1_Row_b4 = Grid.GetRow(body4);

                int At_Pre_body1_Col_b_5 = Grid.GetColumn(body5);
                int At_Pre_body1_Row_b5 = Grid.GetRow(body5);

                int At_Pre_body1_Col_b_6 = Grid.GetColumn(body6);
                int At_Pre_body1_Row_b6 = Grid.GetRow(body6);




                int next_row = At_Pressed_Row_player + 1;

                Grid.SetColumn(Head, Grid.GetColumn(Head));
                Grid.SetRow(Head, next_row);

                Grid.SetColumn(body1, At_Pressed_Col_player);
                Grid.SetRow(body1, At_Pressed_Row_player);

                Grid.SetColumn(body2, At_Pre_body1_Col_b_1);
                Grid.SetRow(body2, At_Pre_body1_Row_b1);

                Grid.SetColumn(body3, At_Pre_body1_Col_b_2);
                Grid.SetRow(body3, At_Pre_body1_Row_b2);

                Grid.SetColumn(body4, At_Pre_body1_Col_b_3);
                Grid.SetRow(body4, At_Pre_body1_Row_b3);

                Grid.SetColumn(body5, At_Pre_body1_Col_b_4);
                Grid.SetRow(body5, At_Pre_body1_Row_b4);

                Grid.SetColumn(body6, At_Pre_body1_Col_b_5);
                Grid.SetRow(body6, At_Pre_body1_Row_b5);

                Grid.SetColumn(body7, At_Pre_body1_Col_b_6);
                Grid.SetRow(body7, At_Pre_body1_Row_b6);

            }
            else if (goUp)
            {
                int At_Pressed_Col_player = Grid.GetColumn(Head);
                int At_Pressed_Row_player = Grid.GetRow(Head);




                int At_Pre_body1_Col_b_1 = Grid.GetColumn(body1);
                int At_Pre_body1_Row_b1 = Grid.GetRow(body1);

                int At_Pre_body1_Col_b_2 = Grid.GetColumn(body2);
                int At_Pre_body1_Row_b2 = Grid.GetRow(body2);

                int At_Pre_body1_Col_b_3 = Grid.GetColumn(body3);
                int At_Pre_body1_Row_b3 = Grid.GetRow(body3);

                int At_Pre_body1_Col_b_4 = Grid.GetColumn(body4);
                int At_Pre_body1_Row_b4 = Grid.GetRow(body4);

                int At_Pre_body1_Col_b_5 = Grid.GetColumn(body5);
                int At_Pre_body1_Row_b5 = Grid.GetRow(body5);

                int At_Pre_body1_Col_b_6 = Grid.GetColumn(body6);
                int At_Pre_body1_Row_b6 = Grid.GetRow(body6);




                int next_row = At_Pressed_Row_player - 1;

                Grid.SetColumn(Head, Grid.GetColumn(Head));
                Grid.SetRow(Head, next_row);

                Grid.SetColumn(body1, At_Pressed_Col_player);
                Grid.SetRow(body1, At_Pressed_Row_player);

                Grid.SetColumn(body2, At_Pre_body1_Col_b_1);
                Grid.SetRow(body2, At_Pre_body1_Row_b1);

                Grid.SetColumn(body3, At_Pre_body1_Col_b_2);
                Grid.SetRow(body3, At_Pre_body1_Row_b2);

                Grid.SetColumn(body4, At_Pre_body1_Col_b_3);
                Grid.SetRow(body4, At_Pre_body1_Row_b3);


                Grid.SetColumn(body5, At_Pre_body1_Col_b_4);
                Grid.SetRow(body5, At_Pre_body1_Row_b4);

                Grid.SetColumn(body6, At_Pre_body1_Col_b_5);
                Grid.SetRow(body6, At_Pre_body1_Row_b5);

                Grid.SetColumn(body7, At_Pre_body1_Col_b_6);
                Grid.SetRow(body7, At_Pre_body1_Row_b6);

            }
            else
            {

                int playerCol = Grid.GetColumn(Head);
                int playerRow = Grid.GetRow(Head);

               
                Grid.SetColumn(body1, playerCol-1);
                Grid.SetRow(body1, playerRow);

                Grid.SetColumn(body2, Grid.GetColumn(body1)-1);
                Grid.SetRow(body2, playerRow);

                Grid.SetColumn(body3, Grid.GetColumn(body2)-1);
                Grid.SetRow(body3, playerRow);

                Grid.SetColumn(body4, Grid.GetColumn(body3)-1);
                Grid.SetRow(body4, playerRow);

                Grid.SetColumn(body5, Grid.GetColumn(body4)-1);
                Grid.SetRow(body5, playerRow);

                Grid.SetColumn(body6, Grid.GetColumn(body5)-1);
                Grid.SetRow(body6, playerRow);

                Grid.SetColumn(body7, Grid.GetColumn(body6) -1);
                Grid.SetRow(body7, playerRow);
                
              /*  playerCol++;
                Grid.SetColumn(Head, playerCol);
                Grid.SetRow(Head, playerRow);*/
            }




        }

        private void go_Awaad_Right_V2(UIElement[] arr_Snake_Parts, Dictionary<string, int> dic_Positions_At_Pres_Right)
        {
            get_Position_Of_Rects_At_Pressing_Right(arr_Snake_Parts, dic_Positions_At_Pres_Right);

            int next_Col_For_Snake_Head = dic_Positions_At_Pres_Right["Col_Position_At_Pressing_Left_For_Body_0"] + 1;

            set_Recs_Posts_In_Right_Dir(arr_Snake_Parts, dic_Positions_At_Pres_Right, next_Col_For_Snake_Head);
        }

        private void get_Position_Of_Rects_At_Pressing_Right(UIElement[] arr_Snake_Parts, Dictionary<String,int> dic_Positions_At_Pres_Right)
        {
            dic_Positions_At_Pres_Right.Clear();
            for (int i = 0; i < arr_Snake_Parts.Length; i++)
            {
                dic_Positions_At_Pres_Right.Add("Col_Position_At_Pressing_Left_For_Body_" + i, Grid.GetColumn(arr_Snake_Parts[i]));
                dic_Positions_At_Pres_Right.Add("Row_Position_At_Pressing_Left_Fro_Body_" + i, Grid.GetRow(arr_Snake_Parts[i]));
            }
        }

        private void set_Recs_Posts_In_Right_Dir(UIElement[] arr_Snake_Parts, Dictionary<String, int> dic_Positions_At_Pres_Right,int next_Col_For_Snake_Head)
        {
            for (int i = 0; i < arr_Snake_Parts.Length; i++)
            {
                if (i == 0)
                {
                    Grid.SetColumn(arr_Snake_Parts[i], next_Col_For_Snake_Head);
                    Grid.SetRow(arr_Snake_Parts[i], dic_Positions_At_Pres_Left["Row_Position_At_Pressing_Left_Fro_Body_" + i]);
                }
                else
                {
                    Grid.SetColumn(arr_Snake_Parts[i], dic_Positions_At_Pres_Left["Col_Position_At_Pressing_Left_For_Body_" + (i - 1)]);
                    Grid.SetRow(arr_Snake_Parts[i], dic_Positions_At_Pres_Left["Row_Position_At_Pressing_Left_Fro_Body_" + (i - 1)]);
                }

            }

        }

        //----------------------------------------------------------------------

        private void go_Awaad_Right( UIElement right_Rec, UIElement left_Rec)
        {
          


            Grid.SetColumn(left_Rec, Grid.GetColumn(right_Rec) - 1);
            Grid.SetRow(left_Rec, Grid.GetRow(Head));
        }

        //---------------------------------------------------------------------
        //------------------------------------------------------------------------

        private int get_Col_Pos(UIElement one_Snake_Part)
        {
            return Grid.GetColumn(one_Snake_Part);
            
        }
        //-----------------------------------------------------------------------
        private int get_Row_Pos(UIElement one_Snake_Part)
        {
            return Grid.GetRow(one_Snake_Part);
        }
        //-------------------------------------------------------------------------
       private void go_Awaad_Left(UIElement[] arr_Snake_Parts, Dictionary<String,int> dict_any_jsldjf)
        {
            get_Position_Of_Rects_At_Pressing_Left(arr_Snake_Parts, dict_any_jsldjf);

            int next_Col_For_Snake_Head = dict_any_jsldjf["Col_Position_At_Pressing_Left_For_Body_0"] - 1;

            set_Recs_Posts_In_Left_Dir(arr_Snake_Parts, dict_any_jsldjf, next_Col_For_Snake_Head);
           
        }

        //------------------------------------------------------------------------------
        private void get_Position_Of_Rects_At_Pressing_Left(UIElement[] arr_any_lkjsdljf, Dictionary<String, int> dict_any_jsldjf)
        {
            dict_any_jsldjf.Clear();
            for (int i = 0; i < arr_any_lkjsdljf.Length; i++)
            {   
                dict_any_jsldjf.Add("Col_Position_At_Pressing_Left_For_Body_" + i, Grid.GetColumn(arr_any_lkjsdljf[i]));
                dict_any_jsldjf.Add("Row_Position_At_Pressing_Left_Fro_Body_" + i, Grid.GetRow(arr_any_lkjsdljf[i]));
            }
        }
        private void set_Recs_Posts_In_Left_Dir(UIElement[] arr_any_lkjsdljf, Dictionary<String, int> dic_Positions_At_Pres_Left, int next_Col_For_Snake_Head)
        {
            for (int i = 0; i < arr_any_lkjsdljf.Length; i++)
            {
                if (i == 0)
                {
                    Grid.SetColumn(arr_any_lkjsdljf[i], next_Col_For_Snake_Head);
                    Grid.SetRow(arr_any_lkjsdljf[i], dic_Positions_At_Pres_Left["Row_Position_At_Pressing_Left_Fro_Body_" + i]);
                }
                else
                {
                    Grid.SetColumn(arr_any_lkjsdljf[i], dic_Positions_At_Pres_Left["Col_Position_At_Pressing_Left_For_Body_" + (i - 1)]);
                    Grid.SetRow(arr_any_lkjsdljf[i], dic_Positions_At_Pres_Left["Row_Position_At_Pressing_Left_Fro_Body_" + (i - 1)]);
                }

            }
        }
  
    //---------------------------------------------------------------------------------------

        private void draw_The_Snake_V2()
        {
            UIElement[] arr_Snake_Parts = [Head, body1, body2, body3, body4, body5, body6, body7];
            List<UIElement> list_Snake_Parts = new List<UIElement>()
            {
                Head, body1, body2, body3, body4, body5, body6, body7
            };


            if (goRight)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goRight);
            }
            else if(goLeft)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goLeft);

            }

            else if (goUp)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goUp);

            }
            else if(goDown)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goDown);

            }
            else
            {
               

            }
        }
    
    
    }
}