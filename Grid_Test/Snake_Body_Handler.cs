using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Grid_Test
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

    }
}
