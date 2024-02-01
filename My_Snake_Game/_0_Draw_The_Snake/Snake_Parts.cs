using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Awaad_Project._0_Draw_The_Snake
{
    internal class Snake_Parts
    {
       public const int snake_Width = 25;
       public const int snake_Height = 25;
       public UIElement uiElement { get; set; }
        public double left_Position {  get; set; }
        public double top_Position {  get; set; }
       
        public bool IsHead {  get; set; }
       
    }
}
