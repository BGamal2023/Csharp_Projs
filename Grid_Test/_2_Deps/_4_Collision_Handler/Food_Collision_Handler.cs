﻿using Grid_Test.__Globals;
using Grid_Test._2_Deps._1_Snake_Body_Handler;
using Grid_Test._2_Deps._3_Snake_Food_Handler;
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
            UIElement SnakeHead = Globals.list_Snake_Parts[0].uiElement;
            UIElement food_Rec = Globals.list_Snake_Food[0].uiElement;

            int curCol_SnakeHead = Grid.GetColumn(SnakeHead);
            int curCol_food_Rec=Grid.GetColumn(food_Rec);

            int curRow_SnakeHead=Grid.GetRow(SnakeHead);
            int curRow_food_Rec = Grid.GetRow(food_Rec);


            if(curCol_SnakeHead==curCol_food_Rec && curRow_SnakeHead == curRow_food_Rec)
            {
                Globals.isFoodCollisionOccurred = true;
                Globals.Score++;
            }

        }
    }
}
