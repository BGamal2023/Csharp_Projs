using Grid_Test.__Globals;
using Grid_Test._2_Deps._1_Snake_Body_Handler;
using Grid_Test._2_Deps._8_Create_Rectangle;
using Grid_Test._2_Deps._9_List_Of_Snake_Parts_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Grid_Test._2_Deps._3_Snake_Food_Handler
{
    internal class Snake_Food_Handler
    {
        //-------------------------------------------------------------------------
        Creating_Rect obj_Creating_Rect = new Creating_Rect();
        List_Of_Snake_Parts_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Parts_Handler();
        List<int[]> li_Of_Snake_Parts_Cols_And_Rows = new List<int[]>();
        //-------------------------------------------------------------------------
        public void feed_The_Snake_V0(Grid gameArea)
        {

            //--
            var nextCol = new Random();
            var nextRow = new Random();
            //--
            int foodCol = nextCol.Next(1, Globals.No_Of_gameArea_Cols - 2);
            int foodRow = nextRow.Next(1, Globals.No_Of_gameArea_Rows - 2);
            //--

            var snakeFood = obj_Creating_Rect.create_Rec(
                  gameArea,
                  Globals.snake_Food_Color,
                  foodCol,
                  foodRow
                  );
            //--
            Globals.list_Snake_Food.Add(snakeFood);
            Globals.isFoodCollisionOccurred = false;
            //--


        }
        //-------------------------------------------------------------------------
        public void eat_Snake_Food(Grid gameArea)
        {
           gameArea.Children.Remove( Globals.list_Snake_Food[0]);
            Globals.list_Snake_Food.Clear();
        }
        //-------------------------------------------------------------------------
        public void feed_The_Snake_V1(Grid gameArea)
        {
            int[] arr_Of_Next_Food_Col_and_Row = get_The_Random_Row_And_Col_For_Snake_Food(gameArea);
            //--
            var snakeFood = obj_Creating_Rect.create_Rec(
                  gameArea,
                  Globals.snake_Food_Color,
                  arr_Of_Next_Food_Col_and_Row[1],
                  arr_Of_Next_Food_Col_and_Row[0]
                  );
            //--
            Globals.list_Snake_Food.Add(snakeFood);
            Globals.isFoodCollisionOccurred = false;
            //--
            //-------
        }
        //-------------------------------------------------------------------------
        public void feed_The_Snake_V2(Grid gameArea)
        {
            /// get list of current snake cols
            /// get list of crrrent snake rows
            /// get list of all cols possibilities for food to be drawn in 
            /// get list of all rows possibilities for food to be drawn in 
            /// last stepe subtract list of current col snake from list of all possible col
            /// also for rows 
            /// deliver these two listst to the Random next method.
            
            List<int> list_current_Snake_Parts_Cols= new List<int>();
            List<int> list_current_Snake_Parts_Rows=new List<int>();
            List<int> List_OF_gameArea_Cols = new List<int>();
            List<int> List_OF_gameArea_Rows=new List<int>();

            List<int> list_Of_Curr_Avail_Food_Cols=new List<int>();
            List<int> list_Of_Curr_Avail_Food_Rows;

            int list_Count = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_list_Of_The_Snake_Parts();

            //------ get list of current cols and rows for the snake.
            for (int i=0; i<list_Count; i++)
            {
                var snake_Part=obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(i);
                int current_Col=Grid.GetColumn(snake_Part);
                int current_Row=Grid.GetRow(snake_Part);
                list_current_Snake_Parts_Cols.Add(current_Col);
                list_current_Snake_Parts_Rows.Add(current_Row);
            }

            //------ get list for all cols and rows in the grid ....

            for (int i = 0; i < Globals.No_Of_gameArea_Cols; i++)
            {
                List_OF_gameArea_Cols.Add(i);
            }

            for (int i=0; i < Globals.No_Of_gameArea_Rows; i++)
            {
                List_OF_gameArea_Rows.Add(i);
            }

            //------- get list for food cols and rows0
            var list_Of_Curr_Avail_Food_Cols_V1 = List_OF_gameArea_Cols.Except(list_current_Snake_Parts_Cols);
            var  list_Of_Curr_Avail_Food_Rows_V1= List_OF_gameArea_Rows.Except(list_current_Snake_Parts_Rows);
            //-----------------------------------------

            //--
            var nextCol = new Random();
            var nextRow = new Random();
            //----------------------------------------------------------------------------------------
            Random r = new Random();
            IEnumerable<int> threeRandom = list_Of_Curr_Avail_Food_Rows_V1.OrderBy(x => r.Next()).Take(1);
            //--
            int foodCol = nextCol.Next(); ;
            int foodRow = nextRow.Next(0, list_Of_Curr_Avail_Food_Rows_V1.Count());
            //--
            var snakeFood = obj_Creating_Rect.create_Rec(
                  gameArea,
                  Globals.snake_Food_Color,
                  foodCol,
                  foodRow
                  );
            //--
            Globals.list_Snake_Food.Add(snakeFood);
            Globals.isFoodCollisionOccurred = false;
            //--



        }
        //-------------------------------------------------------------------------
        private int[] get_The_Random_Row_And_Col_For_Snake_Food(Grid gameArea)
        {
            //-------
            /// 0- get all cols and rows for the sanke.
            /// 1- create 2 random numbers.
            /// 2- check from mathcing 
            /// 3- if at least one match repeat for 1.
            /// 4- if not match ....create rectangel and set col and row.
            /// 0- get all cols and rows for the snake.
            //--
          

            li_Of_Snake_Parts_Cols_And_Rows.Clear();
            int counts_Snake_Body = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_list_Of_The_Snake_Parts();
            for (int i = 0; i < counts_Snake_Body; i++)
            {
                var snake_Part = obj_List_Of_Snake_Parts_Handler.get_Item_From_The_List(i);
                int snake_Part_Col = Grid.GetColumn(snake_Part);
                int snake_Part_Row = Grid.GetRow(snake_Part);
                int[] arr_One_Snake_Part_Cols_And_Rows = new int[] { snake_Part_Col, snake_Part_Row };
                li_Of_Snake_Parts_Cols_And_Rows.Add(arr_One_Snake_Part_Cols_And_Rows);
            }
            ///-    /// 1- create 2 random numbers.
            //--
            var ran_Obj_For_Col = new Random();
            var ran_Obj_For_Row = new Random();
            int next_Food_Col = ran_Obj_For_Col.Next(0, Globals.No_Of_gameArea_Cols);
            int next_Food_Row = ran_Obj_For_Row.Next(0, Globals.No_Of_gameArea_Rows); ;
            //--
            ///-2- check for mathcing .
            //--
            bool isMatching=false;
            for (int j = 0; j < li_Of_Snake_Parts_Cols_And_Rows.Count; j++)
            {
                int[] arr_One_Snake_Part_Cols_And_Rows = li_Of_Snake_Parts_Cols_And_Rows[j];
                if (next_Food_Row == arr_One_Snake_Part_Cols_And_Rows[0] && next_Food_Col == arr_One_Snake_Part_Cols_And_Rows[1])
                {
                    isMatching = true;
                    break;
                }
                else
                {
                  
                }

            }
            //--

            if (isMatching)
            {
                return get_The_Random_Row_And_Col_For_Snake_Food(gameArea);
            }
            else
            {
                return new int[] { next_Food_Row, next_Food_Col };

            }
            //--

            //----------

        }



    }
}
