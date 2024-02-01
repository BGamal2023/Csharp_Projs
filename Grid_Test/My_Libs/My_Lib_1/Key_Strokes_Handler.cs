
using System.Windows.Input;


namespace Grid_Test.My_Libs.My_Lib_1
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
                        Global_Directions.goUp = true;
                        Global_Directions.goDown = false;
                        Global_Directions.goRight = false;
                        Global_Directions.goLeft = false;
                    }
                    break;

                case Key.Down:
                    if (Global_Directions.goUp == false)
                    {
                        Global_Directions.goDown = true;
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
