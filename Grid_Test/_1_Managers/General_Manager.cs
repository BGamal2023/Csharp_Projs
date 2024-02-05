using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Reflection.Emit;
using Grid_Test.__Globals;
using Grid_Test._2_Deps._1_Snake_Body_Handler;
using Grid_Test._2_Deps._2_Snake_Moving_Handler;
using Grid_Test._2_Deps._3_Snake_Food_Handler;
using Grid_Test._2_Deps._4_Collision_Handler;
using Grid_Test._2_Deps._7_Player_Score_Handler;
using Grid_Test.My_Libs.My_Lib_1.Globals;
using Label = System.Windows.Controls.Label;
using Grid_Test._2_Deps._5_Game_Levels_Handler;


namespace Grid_Test._1_Managers

{
    internal class General_Manager
    {
        Snake_Body_Handler obj_Snake_Body_Handler=new Snake_Body_Handler();
        Snake_Moving_Handler obj_Snake_Moving_Handler=new Snake_Moving_Handler();
        Snake_Food_Handler obj_Snake_Food_Handler=new Snake_Food_Handler();
        Food_Collision_Handler obj_Food_Collision_Handler=new Food_Collision_Handler();
        Dead_Collision_Handler obj_Dead_Collision_Handler=new Dead_Collision_Handler();
        Score_Handler obj_Score_Handler=new Score_Handler();
        Game_Level_Handler obj_Game_Level_Handler=new Game_Level_Handler(); 
        //---------------------------------------------------------------
        public void start_The_Game(Grid gameArea)
        {
                draw_The_Snake(gameArea);
               obj_Snake_Food_Handler.add_Snake_Food(gameArea);
             

        }
        //---------------------------------------------------------------
        public void move_Control_And_Monitor_Snake_Status(
            DispatcherTimer gameTimer,
            Grid gameArea,
            Label scoreValue,
            Label playerHealth,
            Label level)
        {
            gameTimer.Tick += (sender, e) =>
            {
                timer_Tick_Callback(
                sender, e, gameArea, gameTimer, scoreValue,playerHealth,level);
            };
            gameTimer.Interval = TimeSpan.FromMilliseconds(Globals.gameSpeed);
            gameTimer.Start();

    
        
        }
        //---------------------------------------------------------------
        private void timer_Tick_Callback(
            object? sender, 
            EventArgs e, 
            Grid gameArea,
            DispatcherTimer gameTimer, 
            Label scoreValue,
            Label playerHealth,
            Label level
            )
        {
            check_Dead_Collision(gameTimer);
            move_The_Snake();
            feed_The_Snake(gameArea);
            check_Food_Collision();
            update_Player_Score( scoreValue);
            update_Player_Healthy(playerHealth);
            update_The_Game_Level(level,gameTimer);


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
                Globals.playerHealth--;
                Globals.isDeadCollisionOccurued =false;
            }

            if (Globals.playerHealth == 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over");
            }
        }
        //-------------------------------------------------------------------
        public void update_Player_Score(Label scoreValue)
        {
            obj_Score_Handler.update_Player_Sore(scoreValue);
        }
        //---------------------------------------------------------------
        public void update_Player_Healthy(Label player_Healthy)
        {
            player_Healthy.Content = Globals.playerHealth;
        }
        //---------------------------------------------------------------
        public void update_The_Game_Level(Label levelValue,DispatcherTimer gameTimer)
        {
            levelValue.Content = Globals.Level;

            obj_Game_Level_Handler.update_Game_Level(gameTimer);
        }


    }





}

    
    


