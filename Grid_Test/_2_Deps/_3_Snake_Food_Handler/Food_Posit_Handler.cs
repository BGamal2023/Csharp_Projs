using Grid_Test.__Globals;
using Grid_Test._2_Deps._9_List_Of_Snake_Parts_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Snake_Game._2_Deps._3_Snake_Food_Handler
{
    internal class Food_Posit_Handler
    {
        //-----------------------------------------------------------------------------------------
        List<int[]> gameArea_Positions = new List<int[]>();
        List_Of_Snake_Parts_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Parts_Handler();
        List<int[]> list_Snake_Parts_Postitions=new List<int[]>();
        //-----------------------------------------------------------------------------------------
     /*   public int get_col_Nu_for_Snake_Food()
        {

        }*/
        //-----------------------------------------------------------------------------------------
      /*  public int get_Row_No_For_Snake_Food()
        {

        }
*/
        //-----------------------------------------------------------------------------------------

       /* public List<int[]> get_List_Of_Positions_For_Snake_Food(List<int[]> gameArea_Positions)
        {

            List<int[]> snake_Parts_Postions_List = get_Snake_Body_Positions();


            
        }*/
        //-----------------------------------------------------------------------------------------
        public List<int []> get_All_Positions_For_gameArea()
        {
            for(int i = 0; i < Globals.No_Of_gameArea_Rows; i++)
            {
                for(int j=0;j<Globals.No_Of_gameArea_Cols; j++)
                {
                    int[] position=new int[] { i, j };
                    gameArea_Positions.Add(position);

                }
            }
            return gameArea_Positions;  
        }
        //-----------------------------------------------------------------------------------------
        public void print_All_gameArea_positions(List<int[]> gameArea_Positions)
        {
            for(int i = 0;i < gameArea_Positions.Count; i++)
            {
                int[] position = gameArea_Positions[i];
                Console.WriteLine("position Row= " + position[0]+"...position col= " + position[1]);
            }
        }
        //-----------------------------------------------------------------------------------------
        private List<int[]> get_Snake_Body_Positions()
        {
            //--
            int count=obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_list_Of_The_Snake_Parts();

            //--
            for(int i=0; i < count; i++)
            {
                //--
                var snake_part = obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(i);
                int col=Grid.GetColumn(snake_part);
                int row=Grid.GetRow(snake_part);
                int[] snake_Part_Position=new int[] { row, col };
                list_Snake_Parts_Postitions.Add(snake_Part_Position);
                //--
            }
            //--
            return list_Snake_Parts_Postitions;
        }
        //-----------------------------------------------------------------------------------------
        private List<int[]> compare_The_Two_Lists_And_Get_Me_The_Final_List
            (List<int[]> gameArea_Positions, 
            List<int[]> list_Snake_Parts_Postitions)
        {
            //--
            List<int[]> list_of_food_Positions_without_snake_parts_Positions=gameArea_Positions;
            //--
            for(int i = 0; i < gameArea_Positions.Count; i++)
            {
                int[] gameArea_pos = gameArea_Positions[i];
                    for(int j=0;j< list_Snake_Parts_Postitions.Count; j++)
                {
                    int[] snake_Part_Pos = list_Snake_Parts_Postitions[j];

                    bool isEqual= compare_Two_Int_Arrays(gameArea_pos, snake_Part_Pos);
                    if (isEqual == true)
                    {
                        list_of_food_Positions_without_snake_parts_Positions.Remove(gameArea_Positions[i]);
                    }


                }
            }






            return list_of_food_Positions_without_snake_parts_Positions;
        }
        //-----------------------------------------------------------------------------------------
        private bool compare_Two_Int_Arrays(int[] array1, int[] array2)
        {
            bool isEqual=false;

            if (array1[0] == array2[0] && array1[1] == array2[1]) {
            isEqual=true;
            }

            return isEqual; 
        }

    }
}
