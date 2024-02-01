using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Grid_Test
{
    internal class create_Snake_Body
    {
        List<UIElement> list_Of_The_snake_Body=new List<UIElement>();
        private void add_new_Piece_To_Snake()
        {
            list_Of_The_snake_Body.Add(
                
             new Rectangle()
             {
                Fill = Brushes.Green,
                Stroke = new SolidColorBrush(Colors.Black)
             }
             ) ; 
        }
    }
}
