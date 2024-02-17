using Grid_Test.__Globals;
using Grid_Test.My_Libs.My_Lib_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Grid_Test._2_Deps._A_10_Game_Area_Handler
{
    internal class Game_Area_Handler
    {
        //-------------------------------------------------------------------------------------
        private Grid gameArea = new Grid();
        const string handle_The_Keys_Strokes = "handle_The_Keys_Strokes";
        private Key_Strokes_Handler obj_Key_Strokes_Handler=new Key_Strokes_Handler();  
        //-------------------------------------------------------------------------------------

        public Grid handle_The_Game_Area(MainWindow mainWindow)
        {
            create_And_Add_Grid(mainWindow);
            add_Required_Cols();
            add_Required_Rows();

            return gameArea;
        }
        //-------------------------------------------------------------------------------------

        private void create_And_Add_Grid(MainWindow mainWindow)
        {
            gameArea.Name = Globals.gameArea_Name;
            gameArea.Focusable = true;
            gameArea.Background = Globals.gameArea_Background;
            gameArea.Height = Globals.gameArea_Height;
            gameArea.Width = Globals.gameArea_Width;
            gameArea.ShowGridLines = true;
            gameArea.HorizontalAlignment = HorizontalAlignment.Left;
            gameArea.VerticalAlignment = VerticalAlignment.Top;
            mainWindow.Content = gameArea;
            gameArea.Focus();
           // gameArea.AddHandler(Keyboard.AddKeyDownHandler,new);


        }

        

        //-------------------------------------------------------------------------------------

        private void add_Required_Cols()
        {
           for(int i=0; i < Globals.No_Of_gameArea_Cols; i++)
            {
                
                ColumnDefinition col = new ColumnDefinition();
                gameArea.ColumnDefinitions.Add(col);

            }
        }
        //-------------------------------------------------------------------------------------

        private void add_Required_Rows()
        {
            for(int i = 0; i < Globals.No_Of_gameArea_Rows; i++)
            {
                RowDefinition row = new RowDefinition();
                gameArea.RowDefinitions.Add(row);
            }
           
        }
        //-------------------------------------------------------------------------------------
        private void add_Required_Items()
        {

        }

    }
}
