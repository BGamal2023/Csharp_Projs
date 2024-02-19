using Grid_Test.__Globals;
using Grid_Test._1_Managers;
using Grid_Test._2_Deps._2_Snake_Moving_Handler;
using Grid_Test._2_Deps._A_10_Game_Area_Handler;
using Grid_Test.My_Libs.My_Lib_1;
using Grid_Test.My_Libs.My_Lib_1.Globals;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Grid_Test

{
    /// bug #0 bug in move .....durin down if you rapidly press left then up ...the snake befor 
    /// go left it will move up
    ///i am try to test   draw_The_Snake_V2(); it need to be tested again 
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        //-------------------------------------------------------------------------------------
        General_Manager obj_General_Manager = new General_Manager();
        Key_Strokes_Handler obj_Key_Strokes_Handler=new Key_Strokes_Handler();
        DispatcherTimer myTimer=new DispatcherTimer();
        //-------------------------------------------------------------------------------------
        public MainWindow()
        {
            //--
            InitializeComponent();
            //--
          Grid gameArea=obj_General_Manager.start_The_Game(this);
            //--
          obj_General_Manager.handle_The_Snake_In_The_gameArea( myTimer, gameArea);
            //--
        }
        //-------------------------------------------------------------------------------------
        private void handle_The_Keys_Strokes(object sender, KeyEventArgs e)
        {
             obj_Key_Strokes_Handler.handle_The_Keys_Strokes(e);



        }
        //-------------------------------------------------------------------------------------

    }
}