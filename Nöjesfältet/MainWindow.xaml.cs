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

namespace Nöjesfältet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _length;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            _length = int.Parse(txtLength.Text);

            if(_length < 140)
            {
                MessageBox.Show("Tyvärr, du är inte tillräckligt lång för att åka.");
            }
            else
            {
                MessageBox.Show("Du är tillräckligt lång för att åka!");
            }
        }
    }
}