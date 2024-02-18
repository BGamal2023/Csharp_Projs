using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Controls;
using Grid_Test.__Globals;
using System.Windows.Media;
using Grid_Test.My_Libs.My_Lib_1.Globals;
using Grid_Test._2_Deps._8_Create_Rectangle;


namespace Grid_Test._2_Deps._9_List_Of_Snake_Parts_Handler
{
    internal class List_Of_Snake_Parts_Handler
    {
        private static List<Rectangle> list_Of_The_Snake_Parts = new List<Rectangle>();
        private Creating_Rect obj_Creating_Rect=new Creating_Rect();
        //---------------------------------------------------------------------------------------------
        public void add_To_The_List(Rectangle rect)
        {
            
            list_Of_The_Snake_Parts.Add(rect);

        }
        //---------------------------------------------------------------------------------------------
        public List<Rectangle> get_The_List()
        {
          return  list_Of_The_Snake_Parts;
        }
        //---------------------------------------------------------------------------------------------
        public int get_Col(int i)
        {
            return Grid.GetColumn(list_Of_The_Snake_Parts[i]);
        }
        //---------------------------------------------------------------------------------------------
        public int get_Row(int i)
        {
            return Grid.GetRow(list_Of_The_Snake_Parts[i]);

        }
        //---------------------------------------------------------------------------------------------
        public int get_The_Count_Of_list_Of_The_Snake_Parts()
        {
            return list_Of_The_Snake_Parts.Count;
        }
        //---------------------------------------------------------------------------------------------
        public Rectangle get_The_Last_Item_In_The_List()
        {
            return list_Of_The_Snake_Parts[^1];
        }
        //---------------------------------------------------------------------------------------------
        public Rectangle get_Item_From_The_List(int i)
        {
            return list_Of_The_Snake_Parts[i];
        }
 

    }
}
