using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Grid_Test
{
    internal class Control_The_Snake_Moving
    {
        Globals globals= new Globals();
        //----------------------------------------------------------------------------
        public void move_Snake_To_Selected_Direction( UIElement[] arr_Snake_Parts,string selected_Direction)
        {
            Dictionary<string , int> recs_Positions_At_Pressing_Any_Dir_Key = new Dictionary<string , int>();
            recs_Positions_At_Pressing_Any_Dir_Key=
            get_Position_Of_All_Snake_Body_At_Pressing_Any_Dir_Key(arr_Snake_Parts);
            set_Position_Of_All_Snake_Body_After_Pressing_The_Dir_Key(
                arr_Snake_Parts,
               recs_Positions_At_Pressing_Any_Dir_Key,
                detect_Next_Step_For_Snake_Head(recs_Positions_At_Pressing_Any_Dir_Key, selected_Direction)
                , selected_Direction
                );
        }
        //--------------------------------------------------------------------------------
        private Dictionary<string, int> get_Position_Of_All_Snake_Body_At_Pressing_Any_Dir_Key(UIElement[] arr_Snake_Parts)
        {
            Dictionary<string, int> dic_Positions_At_Pres_Dire = new Dictionary<string, int>();

            dic_Positions_At_Pres_Dire.Clear();
          

             for (int i = 0; i < arr_Snake_Parts.Length; i++)
                {
                    dic_Positions_At_Pres_Dire.Add(globals.key_Col_Body_+ i, Grid.GetColumn(arr_Snake_Parts[i]));
                    dic_Positions_At_Pres_Dire.Add(globals.key_Row_Body_+ i, Grid.GetRow(arr_Snake_Parts[i]));
                }

            return dic_Positions_At_Pres_Dire;
        }
        //-------------------------------------------------------------------------------------------
        private void set_Position_Of_All_Snake_Body_After_Pressing_The_Dir_Key(UIElement[] arr_Snake_Parts,Dictionary<string, int> dic_Positions_At_Pres_Left, int next_Col_For_Snake_Head,string selected_Direction)
        {

            //! changed from Globals.go_Right .......to str_goRight

            if (selected_Direction == Globals.str_goRight)
            {
                move_Snake_To_Right_Direction(arr_Snake_Parts,dic_Positions_At_Pres_Left,next_Col_For_Snake_Head);;
            }
            else if( selected_Direction == Globals.str_goLeft)
            {
                move_Snake_To_Left_Direction(arr_Snake_Parts, dic_Positions_At_Pres_Left, next_Col_For_Snake_Head);
            }
            else if(selected_Direction == Globals.str_goUp)
            {
                move_Snake_To_Up_Direction(arr_Snake_Parts, dic_Positions_At_Pres_Left, next_Col_For_Snake_Head);
            }
            else if (selected_Direction == Globals.str_goDown)
            {
                move_Snake_To_Down_Direction(arr_Snake_Parts, dic_Positions_At_Pres_Left, next_Col_For_Snake_Head);
            }

        }
        //-------------------------------------------------------------------------------------------
        private void move_Snake_To_Down_Direction(UIElement[] arr_Snake_Parts, Dictionary<string, int> dic_Positions_At_Pres_Left, int next_Col_For_Snake_Head)
        {

            for (int i = 0; i < arr_Snake_Parts.Length; i++)
            {
                if (i == 0)
                {
                    Grid.SetColumn(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Col_Body_ + i]);
                    Grid.SetRow(arr_Snake_Parts[i], next_Col_For_Snake_Head);
                }
                else
                {
                    Grid.SetColumn(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Col_Body_ + (i - 1)]);
                    Grid.SetRow(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Row_Body_ + (i - 1)]);
                }

            }
        }
        //------------------------------------------------------------------------------------------
        private void move_Snake_To_Up_Direction(UIElement[] arr_Snake_Parts,Dictionary<string, int> dic_Positions_At_Pres_Left,int next_Col_For_Snake_Head)
        {
            for (int i = 0; i < arr_Snake_Parts.Length; i++)
            {
                if (i == 0)
                {
                    Grid.SetColumn(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Col_Body_ + i]);
                    Grid.SetRow(arr_Snake_Parts[i], next_Col_For_Snake_Head );
                }
                else
                {
                    Grid.SetColumn(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Col_Body_ + (i - 1)]);
                    Grid.SetRow(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Row_Body_+ (i - 1)]);
                }

            }
        }
        //-------------------------------------------------------------------------------------------
        private void move_Snake_To_Left_Direction( UIElement[] arr_Snake_Parts,Dictionary<string, int> dic_Positions_At_Pres_Left,int next_Col_For_Snake_Head)
        {
            for (int i = 0; i < arr_Snake_Parts.Length; i++)
            {
                if (i == 0)
                {
                    Grid.SetColumn(arr_Snake_Parts[i], next_Col_For_Snake_Head);
                    Grid.SetRow(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Row_Body_ + i]);
                }
                else
                {
                    Grid.SetColumn(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Col_Body_ + (i - 1)]);
                    Grid.SetRow(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Row_Body_ + (i - 1)]);
                }

            }
        }
        //-------------------------------------------------------------------------------------------
        private void move_Snake_To_Right_Direction(UIElement[] arr_Snake_Parts,Dictionary<string, int> dic_Positions_At_Pres_Left,int next_Col_For_Snake_Head)
        {
            for (int i = 0; i < arr_Snake_Parts.Length; i++)
            {
                if (i == 0)
                {
                    Grid.SetColumn(arr_Snake_Parts[i], next_Col_For_Snake_Head);
                    Grid.SetRow(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Row_Body_ + i]);
                }
                else
                {
                    Grid.SetColumn(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Col_Body_ + (i - 1)]);
                    Grid.SetRow(arr_Snake_Parts[i], dic_Positions_At_Pres_Left[globals.key_Row_Body_ + (i - 1)]);
                }

            }
        }
        //------------------------------------------------------------------------------------
        private int detect_Next_Step_For_Snake_Head(Dictionary<string, int> dic_Positions_At_Pres_Dire,string selected_Direction)
        {
            int next_Step_For_Snake_Head = 0;

            if (selected_Direction == Globals.str_goRight)
            {
                next_Step_For_Snake_Head =
                    dic_Positions_At_Pres_Dire[globals.key_Col_Body_+"0"] + 1;

            }
            else if (selected_Direction == Globals.str_goLeft)
            {
                next_Step_For_Snake_Head =
                    dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + "0"] - 1;
            }
            else if (selected_Direction == Globals.str_goUp)
            {
                next_Step_For_Snake_Head =
                    dic_Positions_At_Pres_Dire[globals.key_Row_Body_+"0"] - 1;
            }
            else if (selected_Direction == Globals.str_goDown)
            {
                next_Step_For_Snake_Head =
                         dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + "0"] +1;
            }

            return next_Step_For_Snake_Head;
        }
        //-------------------------------------------------------------------------------------
    }
}
