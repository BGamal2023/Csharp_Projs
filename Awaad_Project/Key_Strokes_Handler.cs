
using Awaad_Project.Globals;
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
        
        //------------------------------------------------------------------------
        public void handle_The_Keys_Strokes(KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    if (Global_Directions.goDown == false)
                    {
                        Global_Directions.goUp= true;
                        Global_Directions.goDown = false;
                        Global_Directions.goRight = false;
                        Global_Directions.goLeft = false;
                    }
                    break;

                case Key.Down:
                    if (Global_Directions.goUp == false)
                    {
                        Global_Directions.goDown= true;
                        Global_Directions.goUp = false;
                        Global_Directions.goRight = false;
                        Global_Directions.goLeft = false;

                    }
                    break;

                case Key.Left:
                    if (Global_Directions.goRight == false)
                    {
                        Global_Directions.goLeft = true;
                        Global_Directions.goDown = false;
                        Global_Directions.goUp = false;
                        Global_Directions.goRight = false;
                    }
                    break;

                case Key.Right:
                    if (Global_Directions.goLeft == false)
                    {
                        Global_Directions.goRight = true;
                        Global_Directions.goDown = false;
                        Global_Directions.goUp = false;
                        Global_Directions.goLeft = false;
                    }
                    break;

                case Key.Space:
                    break;
            }
           
        }
        //------------------------------------------------------------------------


    }
}
