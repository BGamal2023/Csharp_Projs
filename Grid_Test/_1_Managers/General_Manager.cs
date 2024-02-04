using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using Grid_Test.__Globals;
using Grid_Test._2_Deps._1_Snake_Body_Handler;
using Grid_Test._2_Deps._2_Snake_Moving_Handler;
using Grid_Test._2_Deps._3_Snake_Food_Handler;
using Grid_Test._2_Deps._4_Collision_Handler;
using Grid_Test.My_Libs.My_Lib_1.Globals;

namespace Grid_Test._1_Managers

{
    internal class General_Manager
    {
        Snake_Body_Handler obj_Snake_Body_Handler=new Snake_Body_Handler();
        Snake_Moving_Handler obj_Snake_Moving_Handler=new Snake_Moving_Handler();
        Snake_Food_Handler obj_Snake_Food_Handler=new Snake_Food_Handler();
        Food_Collision_Handler obj_Food_Collision_Handler=new Food_Collision_Handler();
        Dead_Collision_Handler obj_Dead_Collision_Handler=new Dead_Collision_Handler();

        //---------------------------------------------------------------

        public void start_The_Game(Grid gameArea)
        {
                draw_The_Snake(gameArea);
               obj_Snake_Food_Handler.add_Snake_Food(gameArea);
             

        }
        //---------------------------------------------------------------
        public void move_Control_And_Monitor_Snake_Status(DispatcherTimer gameTimer,Grid gameArea)
        {
            gameTimer.Tick += (sender, e) => { timer_Tick_Callback(sender, e, gameArea,gameTimer); };
            gameTimer.Interval = TimeSpan.FromMilliseconds(Globals.gameSpeed);
            gameTimer.Start();
        
        }

        private void timer_Tick_Callback(object? sender, EventArgs e, Grid gameArea,DispatcherTimer gameTimer)
        {
            check_Dead_Collision(gameTimer);
            move_The_Snake();
            check_Food_Collision();
            feed_The_Snake(gameArea);
          
        }

        //-----------------------------------------------------------------
        public void draw_The_Snake(Grid gameArea)
        {
            obj_Snake_Body_Handler.add_The_Head_Of_The_Snake_To_The_List_Of_Snake_Parts(
                gameArea);

           

        }
        //-----------------------------------------------------------------
        public void move_The_Snake()
        {
            if (Global_Directions.goRight)
            {
                obj_Snake_Moving_Handler.move_Snake_To_Selected_Direction(
                  Globals.list_Snake_Parts, Global_Directions.str_goRight);
            }
            else if (Global_Directions.goLeft)
            {
                obj_Snake_Moving_Handler.move_Snake_To_Selected_Direction(
                  Globals.list_Snake_Parts, Global_Directions.str_goLeft);
            }
            else if (Global_Directions.goUp)
            {
                obj_Snake_Moving_Handler.move_Snake_To_Selected_Direction(
                  Globals.list_Snake_Parts, Global_Directions.str_goUp);
            }
            else if (Global_Directions.goDown)
            {
                obj_Snake_Moving_Handler.move_Snake_To_Selected_Direction(
                  Globals.list_Snake_Parts, Global_Directions.str_goDown);
            }
            else
            {
                obj_Snake_Moving_Handler.move_Snake_To_Selected_Direction(
                  Globals.list_Snake_Parts, Global_Directions.str_goRight);
            }


        
                    

           /* List<UIElement> list_Snake_Parts = new List<UIElement>()
            {
                Head, body1, body2, body3, body4, body5, body6, body7
            };*/


           /* if (goRight)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goRight);
            }
            else if (goLeft)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goLeft);

            }

            else if (goUp)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goUp);

            }
            else if (goDown)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goDown);

            }
            else
            {


            }*/
        }
        //----------------------------------------------------------------
        public void check_Food_Collision()
        {
            obj_Food_Collision_Handler.detect_The_Food_Collision();
        }
        //----------------------------------------------------------------
        public void feed_The_Snake(Grid gameArea)
        {
            if (Globals.isFoodCollisionOccurred == true)
            {
                obj_Snake_Food_Handler.eat_Snake_Food(gameArea);
                obj_Snake_Body_Handler.add_New_Part_To_Body_Of_The_Snake(gameArea);
                obj_Snake_Food_Handler.add_Snake_Food(gameArea);
                Globals.isFoodCollisionOccurred = false;
            }
        }
        //----------------------------------------------------------------
        //----------------------------------------------------------------
        public void check_Dead_Collision(DispatcherTimer gameTimer)
        {


            obj_Dead_Collision_Handler.detect_The_Dead_Collision();
            end_The_Game(gameTimer);
            
        }
        //-------------------------------------------------------------
        public void end_The_Game(DispatcherTimer gameTimer)
        {
            if (Globals.isDeadCollisionOccurued == true)
            {
                Globals.playerLife--;
                
            }

            if (Globals.playerLife == 0)
            {
                gameTimer.Stop();   
            }
        }



    }





}

    
    


