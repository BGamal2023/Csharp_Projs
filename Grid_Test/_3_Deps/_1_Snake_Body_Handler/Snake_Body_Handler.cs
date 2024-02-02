using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Grid_Test._3_Deps._1_Snake_Body_Handler

{
    class Snake_Body_Handler
    {
        int previous_Position;
        int current_Position;
        int col_At_Pre_Up;
        int col_At_Pre_Down;
        int row_At_Pre_Right;
        int row_At_Pre_Left;

        public UIElement uiElement { get; set; }



        List<UIElement> list_Of_The_snake_Body = new List<UIElement>();
        private void add_new_Piece_To_Snake()
        {
            list_Of_The_snake_Body.Add(

             new Rectangle()
             {
                 Fill = Brushes.Green,
                 Stroke = new SolidColorBrush(Colors.Black)
             }
             );
        }

    }
}
