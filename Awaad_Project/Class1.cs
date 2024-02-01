using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Awaad_Project
{
    internal class Class1
    {

        //Translator concept
        public void create_Rec_In_The_Canvas(Canvas gameArea)
        {
            Rectangle rectangle = new Rectangle()
            {
                Width = 25,
                Height = 25,
                Fill = Brushes.Lime
                
            };

            gameArea.Children.Add(rectangle);
           
            

        }


    }
}
