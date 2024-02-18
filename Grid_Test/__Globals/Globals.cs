using Grid_Test._2_Deps._1_Snake_Body_Handler;
using Grid_Test._2_Deps._3_Snake_Food_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Grid_Test.__Globals
{
    internal class Globals
    {
     
     
        public string key_Col_Body_ = "Col_Position_At_Pressing_For_Body_";
        public string key_Row_Body_ = "Row_Position_At_Pressing_For_Body_";
        public static bool did_A_Collision_Occur=false;
        public static List<Rectangle> list_Snake_Food=new List<Rectangle>();
        public static int gameArea_MaxWidth=700;
        public static int gameArea_MaxHeight = 700;
        public static bool isFoodCollisionOccurred = false;
        public static bool isDeadCollisionOccurued=false;
        public static int timerTick = 500;
        public static UIElement collisionRec;
        public static int snake_Head_X = 20;
        public static int snake_Head_Y = 20;
        public static Brush snake_Head_Color = Brushes.Red;
        public static Brush snake_Body_Color = Brushes.Green;
        public static Brush snake_Food_Color = Brushes.SkyBlue;
        public static int Score;
        public static int playerLife;
        public static int playerHealth = 1;
        public static int Level;
        public static int Score_Level_1 = 200;
        public static int Score_Level_2 = 250;
        public static int Score_Level_3 = 350;
        public static int level_1_speed = 200;
        public static int level_2_speed = 100;
        public static int level_3_speed = 50;
        public static int snake_Width = 100;
        public static int snake_Height = 100;
        public static int currDirection = 0;
        public enum En_currentDirection
        {
            right=0, left=1, up=2, down=3
        }
        //-----------------gameArea----------------------
        public static string gameArea_Name = "gameArea";
        public static Brush gameArea_Background = Brushes.Black;
        public static int gameArea_Height = 500;
        public static int gameArea_Width = 500;
        public static int No_Of_gameArea_Cols = 20;
        public static int No_Of_gameArea_Rows = 20;



    }
}
