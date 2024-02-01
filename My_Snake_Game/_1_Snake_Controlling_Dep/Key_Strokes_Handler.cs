using Awaad_Project._0_Draw_The_Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static System.Formats.Asn1.AsnWriter;

namespace Awaad_Project._1_Snake_Controlling_Dep
{
    internal class Key_Strokes_Handler
    {
        public bool goUp;
        public bool goDown;
        public bool goLeft;
       public bool goRight;
        //------------------------------------------------------------------------
        public void detect_The_Pressed_Keyboard_Key(
            KeyEventArgs e,
            List<Snake_Parts> snakeParts,
            Label mylabel,
            double movingDistance)
        {
            switch (e.Key)
            {
                case Key.Up:
                    if (goDown == false)
                    {
                        goUp= true;
                        goDown = false;
                        goRight = false;
                        goLeft = false;
                        mylabel.Content = "Up key";
                       
                    }
                    break;

                case Key.Down:
                    if (goUp == false)
                    {
                        goDown= true;
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
                    start_NewGame();
                    break;
            }
           
        }
        //------------------------------------------------------------------------
        public void move_And_Control_The_Snake_Direction(
            List<Snake_Parts> snakeParts,
            double movingDistance,
            Canvas gameArea,
            Label mylabel)
        {
            if(goUp==true)
            {
                go_To_Up_Direction(snakeParts, movingDistance);
            }
            else if(goDown==true) {
                go_To_Down_Direction(snakeParts, movingDistance);

            }else if(goLeft==true)
            {
                go_To_Left_Direction(snakeParts, movingDistance); 
            }else if(goRight==true)
            {
                go_To_Right_Direction(snakeParts, movingDistance,gameArea,mylabel);
            }
            else
            {
               
            }
        }
        //------------------------------------------------------------------------
        public void go_To_Left_Direction(
            List<Snake_Parts> snakeParts,
            double movingDistance)
        {

            for (int i = 0; i < snakeParts.Count; i++)
            {

                snakeParts[i].top_Position = snakeParts[0].top_Position;
            }
            for (int i = 0; i < snakeParts.Count; i++)
            {



                if (i == 0)
                {
                    snakeParts[i].left_Position = snakeParts[i].left_Position - movingDistance;
                }

                if (i != 0)
                {
                    snakeParts[i].left_Position = (snakeParts[i - 1].left_Position + Snake_Parts.snake_Height);

                }
            }




        }
        //------------------------------------------------------------------------
        public void go_To_Right_Direction(
            List<Snake_Parts> snakeParts,
            double movingDistance,
            Canvas gameArea,
            Label mylabel)
        {
            if (snakeParts[0].left_Position + Snake_Parts.snake_Width < 800)
            {
                
                set_Top_Pos_R_Dir( snakeParts);
               
                for (int i = 0; i < snakeParts.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeParts[i].left_Position = snakeParts[i].left_Position + movingDistance;
                    }

                    if (i != 0)
                    {
                        snakeParts[i].left_Position = (snakeParts[i - 1].left_Position - Snake_Parts.snake_Height);

                    }
                }
            }
            else
            {
               
                
                    snakeParts[0].left_Position = 0;
                
            }

            mylabel.Content = snakeParts[0].left_Position;

        }
        //------------------------------------------------------------------------
        public void go_To_Up_Direction(
            List<Snake_Parts> snakeParts,
            double movingDistance)
        {

            for (int i = 0; i < snakeParts.Count; i++)
            {

                snakeParts[i].left_Position = snakeParts[0].left_Position;
            }
            for (int i = 0; i < snakeParts.Count; i++)
            {



                if (i == 0)
                {
                    snakeParts[i].top_Position = snakeParts[i].top_Position - movingDistance;
                }

                if (i != 0)
                {
                    snakeParts[i].top_Position = (snakeParts[i - 1].top_Position + Snake_Parts.snake_Height);

                }
            }



        }
        //------------------------------------------------------------------------
        public void go_To_Down_Direction(
            List<Snake_Parts> snakeParts,
            double movingDistance)
        {
            for (int i = 0; i < snakeParts.Count; i++)
            {

                snakeParts[i].left_Position = snakeParts[0].left_Position;
            }
            for(int i = 0;i < snakeParts.Count;i++)
            {



                if (i == 0)
                {
                    snakeParts[i].top_Position = snakeParts[i].top_Position + movingDistance;
                }
           
                if (i != 0)
                {
                    snakeParts[i].top_Position = (snakeParts[i - 1].top_Position - Snake_Parts.snake_Height);

                }
            }





        }
        //------------------------------------------------------------------------
        public void set_Top_Pos_R_Dir(List<Snake_Parts> snakeParts)
        {
            for (int i = 0; i < snakeParts.Count; i++)
            {

                snakeParts[i].top_Position = snakeParts[0].top_Position;
            }
        }
        //------------------------------------------------------------------------
        public void set_Left_Pos_R_Dir(List<Snake_Parts> snakeParts)
        {

        }
        //------------------------------------------------------------------------
        public void set_Top_Pos_L_Dir(List<Snake_Parts> snakeParts) { }
        //------------------------------------------------------------------------
        public void set_Left_Pos_L_Dir(List<Snake_Parts> snakeParts) { }
        //------------------------------------------------------------------------
        public void set_Top_Pos_U_Dir(List<Snake_Parts> snakeParts) { }
        //------------------------------------------------------------------------
        public void set_Left_Pos_U_Dir(List<Snake_Parts> snakeParts) { }
        //------------------------------------------------------------------------
        public void set_Top_Pos_D_Dir(List<Snake_Parts> snakeParts) { }
        //------------------------------------------------------------------------
        public void set_Left_Pos_D_Dir(List<Snake_Parts> snakeParts) { }
        //------------------------------------------------------------------------
        public void start_NewGame()
        {

        }
        //------------------------------------------------------------------------

    }
}
