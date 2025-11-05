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

namespace FL2
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

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;

            if (name == "")
            {
                MessageBox.Show("Fyll i ditt namn.");
                return;
            }

            if (age == "")
            {
                MessageBox.Show("Fyll i din ålder.");
                return;
            }

            MessageBox.Show($"Hej {name}, du är {age} år.");

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txtAge_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}