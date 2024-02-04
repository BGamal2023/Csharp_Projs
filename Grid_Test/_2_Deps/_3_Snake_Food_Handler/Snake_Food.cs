using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Grid_Test._2_Deps._3_Snake_Food_Handler
{
    internal class Snake_Food
    {
        public const int food_Width = 25;
        public const int food_Height = 25;
        public UIElement uiElement { get; set; }

        public double left_Position { get; set; }
        public double top_Position { get; set; }

    }
}
