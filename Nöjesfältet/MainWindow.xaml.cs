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
        int[] lengths = {
             186, 147, 175, 94, 171, 132, 145, 198, 104, 197,
             157, 198, 92, 129, 175, 124, 94, 185, 89, 106,
             135, 197, 103, 68, 136, 130, 197, 143, 102, 112,
             116, 175, 169, 140, 189, 194, 172, 182, 112, 163,
             164, 178, 168, 190, 143, 154, 168, 181, 157, 84,
             203, 188, 105, 175, 155, 140, 174, 203, 139, 106,
             173, 177, 195, 136, 166, 202, 161, 95, 181, 198,
             100, 141, 182, 97, 100, 191, 68, 101, 160, 93,
             146, 178, 74, 172, 184, 173, 138, 96, 144, 91,
             139, 104, 106, 142, 100, 179, 159, 160, 128, 121};


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

            int antalÅkare = 0;

            for (int i = 0; i < lengths.Length; i++)
            {
                if (lengths[i] >= 130 && lengths[i] <= 139)
                {
                    antalÅkare++;
                }
                
            }
            MessageBox.Show($"Antal åkare: {antalÅkare}");

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