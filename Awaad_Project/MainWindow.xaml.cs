using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Awaad_Project
{
   
    public partial class MainWindow : Window
    {
        Class1 obj_Class1 = new Class1();
        public MainWindow()
        {
            InitializeComponent();
            obj_Class1.create_Rec_In_The_Canvas(gameArea);

        }
    }
}