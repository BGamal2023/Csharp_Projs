using Grid_Test.__Globals;
using Grid_Test._2_Deps._1_Snake_Body_Handler;
using Grid_Test._2_Deps._3_Snake_Food_Handler;
using Grid_Test._2_Deps._9_List_Of_Snake_Parts_Handler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Grid_Test._2_Deps._4_Collision_Handler
{
    internal class Food_Collision_Handler
    {
        public void detect_The_Food_Collision()
        {
            List_Of_Snake_Parts_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Parts_Handler();
            //---------
            UIElement SnakeHead = obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(0);
            UIElement food_Rec = Globals.list_Snake_Food[0];
            int curCol_SnakeHead = Grid.GetColumn(SnakeHead);
            int curCol_food_Rec=Grid.GetColumn(food_Rec);
            int curRow_SnakeHead=Grid.GetRow(SnakeHead);
            int curRow_food_Rec = Grid.GetRow(food_Rec);
            //---------
            detect_The_Food_Collision_In_Right_Dir(curCol_SnakeHead, curCol_food_Rec,curRow_SnakeHead,curRow_food_Rec);
            //---------
            detect_The_Food_Collision_In_Left_Dir(curCol_SnakeHead, curCol_food_Rec, curRow_SnakeHead, curRow_food_Rec);
            //---------
            detect_The_Food_Collision_In_Up_Dir(curCol_SnakeHead, curCol_food_Rec, curRow_SnakeHead, curRow_food_Rec);
            //---------
            detect_The_Food_Collision_In_Down_Dir(curCol_SnakeHead, curCol_food_Rec, curRow_SnakeHead, curRow_food_Rec);
/*
            if (curCol_SnakeHead==curCol_food_Rec && curRow_SnakeHead == curRow_food_Rec)
            {
                Globals.isFoodCollisionOccurred = true;
                Globals.Score++;
            }*/

        }
        //----------------------------------------------------------------------------------------------------------------------
        private void detect_The_Food_Collision_In_Right_Dir(int curCol_SnakeHead,int curCol_food_Rec,int curRow_SnakeHead, int curRow_food_Rec) {
            if (Globals.currDirection == (int)Globals.En_currentDirection.right)
            {
                if (curCol_SnakeHead + 1 == curCol_food_Rec && curRow_SnakeHead==curRow_food_Rec)
                {
                    Globals.isFoodCollisionOccurred = true;
                    Globals.Score++;
                }
            }

        }
        //----------------------------------------------------------------------------------------------------------------------
        private void detect_The_Food_Collision_In_Left_Dir(int curCol_SnakeHead, int curCol_food_Rec, int curRow_SnakeHead, int curRow_food_Rec) {
            if (Globals.currDirection == (int)Globals.En_currentDirection.left)
            {
                if (curCol_SnakeHead - 1 == curCol_food_Rec && curRow_SnakeHead == curRow_food_Rec)
                {
                    Globals.isFoodCollisionOccurred = true;
                    Globals.Score++;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        private void detect_The_Food_Collision_In_Up_Dir(int curCol_SnakeHead, int curCol_food_Rec, int curRow_SnakeHead, int curRow_food_Rec) {
            if (Globals.currDirection == (int)Globals.En_currentDirection.up)
            {
                if (curRow_SnakeHead - 1 == curRow_food_Rec&& curCol_SnakeHead==curCol_food_Rec)
                {
                    Globals.isFoodCollisionOccurred = true;
                    Globals.Score++;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        private void detect_The_Food_Collision_In_Down_Dir(int curCol_SnakeHead, int curCol_food_Rec, int curRow_SnakeHead, int curRow_food_Rec) {

            if (Globals.currDirection == (int)Globals.En_currentDirection.down )
            {
                if (curRow_SnakeHead + 1 == curRow_food_Rec&&curCol_SnakeHead == curCol_food_Rec)
                {
                    Globals.isFoodCollisionOccurred = true;
                    Globals.Score++;
                }
            }
        }
    }
}
