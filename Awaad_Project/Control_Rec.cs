using Awaad_Project.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Awaad_Project
{
    internal class Control_Rec
    {
        private void method2(Canvas gameArea, UIElement rec)
        { 
        
        if(Global_Directions.goDown)
            {
                move_A_Rec_Down();
            }
        if(Global_Directions.goUp) 
            {
                move_A_Rec_Up();
            }
        if(Global_Directions.goLeft) 
            {
                move_A_Rec_Left();
            }
        if(Global_Directions.goRight) 
            {

                move_A_Rec_Right();
            }
        
        }

        private void move_A_Rec_Right()
        {
            throw new NotImplementedException();
        }

        private void move_A_Rec_Left()
        {
            throw new NotImplementedException();
        }

        private void move_A_Rec_Up()
        {
            throw new NotImplementedException();
        }

        private void move_A_Rec_Down()
        {
            throw new NotImplementedException();
        }

        //------------------------------------------------------------





        //------------------------------------------------------------
        private void move_A_Rec_To_Any_Dir(
            Canvas gameArea , UIElement rec ,int X , int Y)
        {
                
        }
        private void move_A_Rec_Right(Canvas gameArea, UIElement rec)
        {
           
        }

        private void method23()
        {
            List<Int32>list= new List<Int32>();
            for(int i=0; i < 700; i+=25)
            {
                list.Add(i);
            }
        }

        private void move_A_Rec_Left(Canvas gameArea, UIElement rec)
        {
            throw new NotImplementedException();
        }

        private void move_A_Rec_Up(Canvas gameArea, UIElement rec)
        {
            throw new NotImplementedException();
        }

        private void move_A_Rec_Down(Canvas gameArea, UIElement rec)
        {
            throw new NotImplementedException();
        }
    }
}
