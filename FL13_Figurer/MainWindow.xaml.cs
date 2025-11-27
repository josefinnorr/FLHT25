using System.Drawing;
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

namespace FL13_Figurer
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Skapa ett objekt av typen rectangle
            // Alt. skapa en instans av rectangle
            //Rectangle rectangle = new();
            //rectangle.Height = 12;
            //rectangle.Width = 4;

            //Rectangle rectangle2 = new();
            //rectangle.Height = 12;
            //rectangle.Width = 4;

            //double area = rectangle.GetArea();
            //double area2 = rectangle.GetArea();

            //Triangle triangle = new();
            //triangle.Height = 2;
            //triangle.BaseLength = 12;

            //double areaTri = triangle.GetArea();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new(width: 4, height: 12);
            Triangle triangle = new(baselength: 11, height: 2);
            Square square = new Square(side: 5);

            // Skapa lista för att räkna ut area
            // Lista + Loops = BFF

            List<Shape> shapes = new List<Shape>();
            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Add(square);

            // Kommer visa alla shapes i listan MEN
            // visar typ FL_Triangel osv
            // - vi vill bara ha lastname
            lstShapes.ItemsSource = shapes;


            double area = 0;

            foreach(Shape shape in shapes)
            {
                area += shape.GetArea(); 
            }
        }
    }
}