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

        private void WithAdult()
        {
            if(chkWithAdult.IsChecked == true)
            {
                _length = 130;
            }
        }

        private void CarouselCheck()
        {
            if(_length >= 150)
            {
                MessageBox.Show("Du får åka alla karuseller!");
            }
            else if(_length <= 149 && _length >= 140)
            {
                MessageBox.Show("Du får åka: Småbarnens Karusell, Snurrande tekoppar, Flygande elefanter och Lilla berg-och-dalbanan.");
            }
            else if(_length <= 139 && _length >= 130)
            {
                MessageBox.Show("Du får åka: Småbarnens Karusell, Snurrande tekoppar och Flygande elefanter.");
            }
            else if(_length <= 129 && _length >= 110)
            {
                MessageBox.Show("Du får åka: Småbarnens Karusell och Snurrande tekoppar.");
            }
            else if(_length <= 89)
            {
                MessageBox.Show("Du får åka Småbarnens Karusell");
            }

        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            _length = int.Parse(txtLength.Text);

            WithAdult();
            CarouselCheck();

            //if(_length < 140)
            //{
            //    MessageBox.Show("Tyvärr, du är inte tillräckligt lång för att åka.");
            //}
            //else
            //{
            //    MessageBox.Show("Du är tillräckligt lång för att åka!");
            //}
        }
    }
}