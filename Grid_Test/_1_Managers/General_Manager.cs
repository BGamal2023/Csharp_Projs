using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using Grid_Test.__Globals;
using Grid_Test._2_Deps._1_Snake_Body_Handler;

namespace Grid_Test._1_Managers

{
    internal class General_Manager
    {
        Snake_Body_Handler obj_Snake_Body_Handler=new Snake_Body_Handler();

        public void start_The_Game()
        {
                draw_The_Snake();
             

        }
        //-----------------------------------------------------------------
        public void move_Control_And_Monitor_Snake_Status(){
            move_The_Snake();
            feed_The_Snake();
            check_Collision();
            if(Globals.did_A_Collision_Occur==true){
                end_The_Game();
            }

        }
        //-----------------------------------------------------------------
        public void end_The_Game(){

        }

        public void draw_The_Snake() {
            
            if(obj_Snake_Body_Handler.list_Of_The_snake_Body.Count==0){
                obj_Snake_Body_Handler.list_Of_The_snake_Body.Add(
                    new Rectangle(){
                            Fill=Brushes.Red,
                 Stroke = new SolidColorBrush(Colors.Black)

                });
            }else{
                for(int i=0 ;i<obj_Snake_Body_Handler.list_Of_The_snake_Body.Count)
            }

         }
        //---------------------------------------------------------------
        public void move_The_Snake() { 


            _1_Snake_Body_Handler 
            List<UIElement> list_Snake_Parts = new List<UIElement>()
            {
                Head, body1, body2, body3, body4, body5, body6, body7
            };


            if (goRight)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goRight);
            }
            else if(goLeft)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goLeft);

            }

            else if (goUp)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goUp);

            }
            else if(goDown)
            {
                obj_Control_The_Snake_Moving.move_Snake_To_Selected_Direction(arr_Snake_Parts, Global_Directions.str_goDown);

            }
            else
            {
               

            }
        }
        //----------------------------------------------------------------
        public void check_Collision(){

        }
        //----------------------------------------------------------------
        public void feed_The_Snake( ){

        }
    }


}
