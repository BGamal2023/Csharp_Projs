using Grid_Test._2_Deps._1_Snake_Body_Handler;
using Grid_Test._2_Deps._3_Snake_Food_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Grid_Test.__Globals
{
    internal class Globals
    {
     
     
        public string key_Col_Body_ = "Col_Position_At_Pressing_For_Body_";
        public string key_Row_Body_ = "Row_Position_At_Pressing_For_Body_";
        public static bool did_A_Collision_Occur=false;
        public static List<Snake_Parts> list_Snake_Parts=new List<Snake_Parts>();
        public static List<Snake_Food> list_Snake_Food=new List<Snake_Food>();
        public static int gameArea_MaxWidth=700;
        public static int gameArea_MaxHeight = 700;
        public static int No_Of_gameArea_Cols=26;
        public static int No_Of_gameArea_Rows=27;
        public static bool isFoodCollisionOccurred = false;
        public static bool isDeadCollisionOccurued=false;
        public static int gameSpeed = 400;
        public static UIElement collisionRec;
        public static int Score;
        public static int playerLife = 3;

    }
}
