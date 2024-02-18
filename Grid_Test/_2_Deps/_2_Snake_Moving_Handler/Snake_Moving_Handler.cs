using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Grid_Test.__Globals;
using Grid_Test.My_Libs.My_Lib_1.Globals;
using Grid_Test._2_Deps._1_Snake_Body_Handler;
using System.Windows.Shapes;
using Grid_Test._2_Deps._9_List_Of_Snake_Parts_Handler;

namespace Grid_Test._2_Deps._2_Snake_Moving_Handler
{
    internal class Snake_Moving_Handler
    {
        //------------------------------------------------------------------------------------
        Globals globals = new Globals();
        private List_Of_Snake_Parts_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Parts_Handler();
        //------------------------------------------------------------------------------------
        public void move_Snake_To_Selected_Direction(string selected_Direction)
        {
            //--
            Dictionary<string, int> recs_Positions_At_Pressing_The_Dir_Key = new Dictionary<string, int>();
            //--
            recs_Positions_At_Pressing_The_Dir_Key = get_Position_Of_All_Snake_Body_At_Pressing_The_Dir_Key();
            //--
            set_Position_Of_All_Snake_Body_After_Pressing_The_Dir_Key(
               recs_Positions_At_Pressing_The_Dir_Key,
                detect_Next_Step_For_Snake_Head(recs_Positions_At_Pressing_The_Dir_Key, selected_Direction),
                selected_Direction
                );
            //--
        }
        //------------------------------------------------------------------------------------
        private Dictionary<string, int> get_Position_Of_All_Snake_Body_At_Pressing_The_Dir_Key()
        {
            //--
            Dictionary<string, int> dic_Positions_At_Pres_Dire = new Dictionary<string, int>();
            dic_Positions_At_Pres_Dire.Clear();
            //--
            int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_list_Of_The_Snake_Parts();
            //--
            for (int i = 0; i < listCount; i++)
            {
                //--
                var current_item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(i);
                //--
                dic_Positions_At_Pres_Dire.Add(globals.key_Col_Body_ + i, Grid.GetColumn(current_item_From_The_List));
                dic_Positions_At_Pres_Dire.Add(globals.key_Row_Body_ + i, Grid.GetRow(current_item_From_The_List));
                //--
            }
            //--
            return dic_Positions_At_Pres_Dire;
        }
        //------------------------------------------------------------------------------------
        private void set_Position_Of_All_Snake_Body_After_Pressing_The_Dir_Key( Dictionary<string, int> dic_Positions_At_Pres_Left, int next_Col_For_Snake_Head, string selected_Direction)
        {
            //--
            if (selected_Direction == Global_Directions.str_goRight)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.right;
                //--
                move_Snake_To_Right_Direction(dic_Positions_At_Pres_Left, next_Col_For_Snake_Head);
                //--
            }
            //--
            else if (selected_Direction == Global_Directions.str_goLeft)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.left;
                //--
                move_Snake_To_Left_Direction( dic_Positions_At_Pres_Left, next_Col_For_Snake_Head);
                //--
            }
            //--
            else if (selected_Direction == Global_Directions.str_goUp)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.up;
                //--
                move_Snake_To_Up_Direction( dic_Positions_At_Pres_Left, next_Col_For_Snake_Head);
                //--
            }
            //--
            else if (selected_Direction == Global_Directions.str_goDown)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.down;
                //--
                move_Snake_To_Down_Direction(dic_Positions_At_Pres_Left, next_Col_For_Snake_Head);
                //--
            }
            //--

        }
        //------------------------------------------------------------------------------------
        private void move_Snake_To_Down_Direction( Dictionary<string, int> dic_Positions_At_Pres_Dire, int next_Col_For_Snake_Head)
        {
            //--
            int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_list_Of_The_Snake_Parts();
            //--
            for (int i = 0; i < listCount; i++)
            {
                //--
                var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(i);
                //--
                if (i == 0)
                {
                    //--
                    int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + i];
                    int Y = next_Col_For_Snake_Head;
                    //--
                    set_Position_For_Snake_Part(curr_Item_From_The_List, X, Y);
                    //--
                }
                //--
                else
                {
                    //--
                    int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + (i - 1)];
                    int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + (i - 1)];
                    //--
                    set_Position_For_Snake_Part(curr_Item_From_The_List,X, Y);
                    //--
                }
                //--

            }
            //--
        }
        //------------------------------------------------------------------------------------
        private void move_Snake_To_Up_Direction(Dictionary<string, int> dic_Positions_At_Pres_Dire, int next_Col_For_Snake_Head)
        {
            //--
            int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_list_Of_The_Snake_Parts();
            //--
            for (int i = 0; i < listCount; i++)
            {
                //--
                var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(i);
                //--
                if (i == 0)
                {
                    //--
                    int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + i];
                    int Y = next_Col_For_Snake_Head;
                    //--
                    set_Position_For_Snake_Part(curr_Item_From_The_List, X, Y);
                    //--
                }
                //--
                else
                {
                    //--
                    int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + (i - 1)];
                    int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + (i - 1)];
                    //--
                    set_Position_For_Snake_Part(curr_Item_From_The_List,X, Y);
                    //--
                }
                //--
            }
            //--
        }
        //------------------------------------------------------------------------------------
        private void move_Snake_To_Left_Direction(Dictionary<string, int> dic_Positions_At_Pres_Dire, int next_Col_For_Snake_Head)
        {
            //--
            int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_list_Of_The_Snake_Parts();
            //--
            for (int i = 0; i < listCount; i++)
            {
                //--
                var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(i);
                //--
                if (i == 0)
                {
                    //--
                    int X = next_Col_For_Snake_Head;
                    int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + i];
                    //--
                    set_Position_For_Snake_Part(curr_Item_From_The_List, X, Y);
                    //--
                }
                //--
                else
                {
                    //--
                    int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + (i - 1)];
                    int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + (i - 1)];
                    //--
                    set_Position_For_Snake_Part(curr_Item_From_The_List, X, Y);

                }
                //--
            }
            //--

        }
        //------------------------------------------------------------------------------------
        private void move_Snake_To_Right_Direction(Dictionary<string, int> dic_Positions_At_Pres_Dire, int next_Col_For_Snake_Head)
        {
            //--
            int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_list_Of_The_Snake_Parts();
            //--
            for (int i = 0; i < listCount; i++)
            {
                //--
                var curr_Item_From_The_List=obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(i);
                //--
                if (i == 0)
                {
                    //--
                    int X = next_Col_For_Snake_Head;
                    int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + i];
                    //--
                    set_Position_For_Snake_Part(curr_Item_From_The_List, X, Y);
                    //--
                    //! bug#10 if program work fine remove the 2 comments below.
                 ///   Grid.SetColumn(curr_Item_From_The_List, next_Col_For_Snake_Head);
                  ///  Grid.SetRow(curr_Item_From_The_List, dic_Positions_At_Pres_Left[globals.key_Row_Body_ + i]);
                }
                else
                {  
                    //--
                    int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + (i - 1)];
                    int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + (i - 1)];
                    //--
                    set_Position_For_Snake_Part(curr_Item_From_The_List, X, Y);
                    //! bug#10 if program work fine remove the 2 comments below.

                    ///   Grid.SetColumn(curr_Item_From_The_List, dic_Positions_At_Pres_Left[globals.key_Col_Body_ + (i - 1)]);
                    ///   Grid.SetRow(curr_Item_From_The_List, dic_Positions_At_Pres_Left[globals.key_Row_Body_ + (i - 1)]);
                }
                //--

            }
            //--
        }
        //------------------------------------------------------------------------------------
        private int detect_Next_Step_For_Snake_Head(Dictionary<string, int> dic_Positions_At_Pres_Dire, string selected_Direction)
        {
            //--
            int next_Step_For_Snake_Head = 0;
            //--
            if (selected_Direction == Global_Directions.str_goRight)
            {
                next_Step_For_Snake_Head = get_Next_Position_For_The_Snake_Head_In_Right_Dir(dic_Positions_At_Pres_Dire);
            }
            //--
            else if (selected_Direction == Global_Directions.str_goLeft)
            {
                next_Step_For_Snake_Head = get_Next_Position_For_The_Snake_Head_In_Left_Dir(dic_Positions_At_Pres_Dire);
            }
            //--
            else if (selected_Direction == Global_Directions.str_goUp)
            {
                next_Step_For_Snake_Head = get_Next_Position_For_The_Snake_Head_In_Up_Dir(dic_Positions_At_Pres_Dire);
             
            }
            //--
            else if (selected_Direction == Global_Directions.str_goDown)
            {
                next_Step_For_Snake_Head = get_Next_Position_For_The_Snake_Head_In_Down_Dir(dic_Positions_At_Pres_Dire);
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        //------------------------------------------------------------------------------------
        private void set_Position_For_Snake_Part(Rectangle snakePart,int X,int Y)
        {
            Grid.SetColumn(snakePart,X);
            Grid.SetRow(snakePart,Y);
        }
        //------------------------------------------------------------------------------------
        private int get_Next_Position_For_The_Snake_Head_In_Right_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
           int  next_Step_For_Snake_Head = dic_Positions_At_Pres_Dire[globals.key_Col_Body_+ "0"] +1;
            //--
            if (next_Step_For_Snake_Head == Globals.No_Of_gameArea_Rows)
            {
                next_Step_For_Snake_Head = 0;
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        //------------------------------------------------------------------------------------
        private int get_Next_Position_For_The_Snake_Head_In_Left_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
           int  next_Step_For_Snake_Head = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + "0"] - 1;
            //--
            if (next_Step_For_Snake_Head <0)
            {
                next_Step_For_Snake_Head = Globals.No_Of_gameArea_Cols-1;
            }
            //--

            return next_Step_For_Snake_Head;

        }
        //------------------------------------------------------------------------------------
        private int get_Next_Position_For_The_Snake_Head_In_Up_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
           int next_Step_For_Snake_Head = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + "0"] - 1;
            //--
            if (next_Step_For_Snake_Head < 0)
            {
                next_Step_For_Snake_Head = Globals.No_Of_gameArea_Rows-1;
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        //------------------------------------------------------------------------------------
        private int get_Next_Position_For_The_Snake_Head_In_Down_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
           int  next_Step_For_Snake_Head =dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + "0"] + 1;
            //--
            if (next_Step_For_Snake_Head == Globals.No_Of_gameArea_Rows)
            {
                next_Step_For_Snake_Head = 0;
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        //------------------------------------------------------------------------------------


    }
}
