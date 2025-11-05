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

namespace FL1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            ColorBox.Fill = Brushes.LightBlue;
            messageInBoxBlue();

            double boxSize = 200;
            ColorBox.Width = boxSize;
            ColorBox.Height = boxSize;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            ColorBox.Fill = Brushes.Tomato;
            messageInBoxRed();
        }

        static public void messageInBoxBlue()
        {
            MessageBox.Show("You pressed the blue button.");
        }

        static public void messageInBoxRed ()
        {
            MessageBox.Show("You pressed the red button.");
        }
    }
}