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
using Grid_Test._2_Deps._A_10_Game_Area_Handler;


namespace Grid_Test._1_Managers

{
    internal class General_Manager
    {
        //------------------------------------------------------------------------------------
        Snake_Body_Handler obj_Snake_Body_Handler =new Snake_Body_Handler();
        Snake_Moving_Handler obj_Snake_Moving_Handler=new Snake_Moving_Handler();
        Snake_Food_Handler obj_Snake_Food_Handler=new Snake_Food_Handler();
        Food_Collision_Handler obj_Food_Collision_Handler=new Food_Collision_Handler();
        Dead_Collision_Handler obj_Dead_Collision_Handler=new Dead_Collision_Handler();
        Score_Handler obj_Score_Handler=new Score_Handler();
        Game_Level_Handler obj_Game_Level_Handler=new Game_Level_Handler();
        Game_Area_Handler obj_Game_Area_Handler = new Game_Area_Handler();
        //------------------------------------------------------------------------------------
        public Grid start_The_Game(MainWindow mainwindow)
        {
            Grid gameArea = obj_Game_Area_Handler.handle_The_Game_Area(mainwindow);
                add_The_Snake_Head_To_The_gameArea(gameArea);
               obj_Snake_Food_Handler.add_The_First_Snake_Food_To_The_gameArea(gameArea);
            
             
            return gameArea;
        }
        //------------------------------------------------------------------------------------
        public void handle_The_Snake_In_The_gameArea(
            DispatcherTimer gameTimer,
            Grid gameArea
           )
        {

            start_The_Timer_That_Will_Cyclically_Call_The_Snake_Handling_Methods(gameTimer,gameArea);
         

    
        
        }
        //------------------------------------------------------------------------------------
        private void start_The_Timer_That_Will_Cyclically_Call_The_Snake_Handling_Methods(DispatcherTimer gameTimer, Grid gameArea)
        {
            //--
            gameTimer.Tick += (sender, e) =>
            {
                //--
                /// timer_Tick_Callback(
                /// sender, e, gameArea, gameTimer, scoreValue, playerHealth, level);*/
                timer_Tick_Callback(sender, e, gameArea, gameTimer);
                //--
            };
            //--
            gameTimer.Interval = TimeSpan.FromMilliseconds(Globals.timerTick);
            //--
            gameTimer.Start();
            //--
        }
        //------------------------------------------------------------------------------------
        private void timer_Tick_Callback(
            object? sender, 
            EventArgs e, 
            Grid gameArea,
            DispatcherTimer gameTimer
            )
        {
            //--
            check_Dead_Collision(gameTimer);
            //--
            move_The_Snake();
            //--
            feed_The_Snake(gameArea);
            //--
            check_Food_Collision();
            //--
           /// update_Player_Score( scoreValue);
           /// update_Player_Healthy(playerHealth);
           /// update_The_Game_Level(level,gameTimer);


        }
        //------------------------------------------------------------------------------------
        public void add_The_Snake_Head_To_The_gameArea(Grid gameArea)
        {
            obj_Snake_Body_Handler.add_The_Head_Of_The_Snake_To_The_List_Of_Snake_Parts(
                gameArea);
        }
        //------------------------------------------------------------------------------------
        public void move_The_Snake()
        {
            //--
            if (Global_Directions.goRight)
            {
                obj_Snake_Moving_Handler.move_Snake_To_Selected_Direction(Global_Directions.str_goRight);
            }
            //--
            else if (Global_Directions.goLeft)
            {
                obj_Snake_Moving_Handler.move_Snake_To_Selected_Direction(Global_Directions.str_goLeft);
            }
            //--
            else if (Global_Directions.goUp)
            {
                obj_Snake_Moving_Handler.move_Snake_To_Selected_Direction(Global_Directions.str_goUp);
            }
            //--
            else if (Global_Directions.goDown)
            {
                obj_Snake_Moving_Handler.move_Snake_To_Selected_Direction(Global_Directions.str_goDown);
            }
            //--
            else
            {
                obj_Snake_Moving_Handler.move_Snake_To_Selected_Direction(Global_Directions.str_goRight);
            }
            //--

       
        }
        //------------------------------------------------------------------------------------
        public void check_Food_Collision()
        {
            obj_Food_Collision_Handler.detect_The_Food_Collision();
        }
        //------------------------------------------------------------------------------------
        public void feed_The_Snake(Grid gameArea)
        {
            //--
            if (Globals.isFoodCollisionOccurred == true)
            {
                obj_Snake_Food_Handler.eat_Snake_Food(gameArea);
                obj_Snake_Body_Handler.add_New_Part_To_Body_Of_The_Snake(gameArea);
                obj_Snake_Food_Handler.add_The_First_Snake_Food_To_The_gameArea(gameArea);
                Globals.isFoodCollisionOccurred = false;
            }
            //--
        }
        //------------------------------------------------------------------------------------
        public void check_Dead_Collision(DispatcherTimer gameTimer)
        {
            //--
            obj_Dead_Collision_Handler.detect_The_Dead_Collision();
            //--
            end_The_Game(gameTimer);
            //--
        }
        //------------------------------------------------------------------------------------
        public void end_The_Game(DispatcherTimer gameTimer)
        {
            //--
            if (Globals.isDeadCollisionOccurued == true)
            {
                Globals.playerHealth--;
                Globals.isDeadCollisionOccurued =false;
            }
            //--
            if (Globals.playerHealth == 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over");
            }
            //--
        }
        //------------------------------------------------------------------------------------
        public void update_Player_Score(Label scoreValue)
        {
            //--
            obj_Score_Handler.update_Player_Sore(scoreValue);
            //--
        }
        //------------------------------------------------------------------------------------
        public void update_Player_Healthy(Label player_Healthy)
        {
            //--
            player_Healthy.Content = Globals.playerHealth;
            //--
        }
        //------------------------------------------------------------------------------------
        public void update_The_Game_Level(Label levelValue,DispatcherTimer gameTimer)
        {
            //--
            levelValue.Content = Globals.Level;
            //--
            obj_Game_Level_Handler.update_Game_Level(gameTimer);
            //--
        }
        //------------------------------------------------------------------------------------
        public void add_Some_Other_Components_To_mainWidow(MainWindow mainWindow)
        {
           //--
            Label Score_Value=new Label();
            Label player_Healthy=new Label();
            Label level_Value=new Label();
            //--
            mainWindow.Content = Score_Value;
            mainWindow.Content=player_Healthy;
            mainWindow.Content=level_Value;
            //--
        }

    }





}

    
    


