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

namespace YatzyHW
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

            int onesEntered = int.Parse(ones.Text);
            int twosEntered = int.Parse(twos.Text);
            int threesEntered = int.Parse(threes.Text);
            int foursEntered = int.Parse(fours.Text);
            int fivesEntered = int.Parse(fives.Text);
            int sixesEntered = int.Parse(sixes.Text);

            int[] allowedTwos = {0, 2, 4, 6, 8, 10};
            int[] allowedThrees = {0, 3, 6, 9, 12, 15};
            int[] allowedFours = {0, 4, 8, 12, 16, 20};
            int[] allowedFives = {0, 5, 10, 15, 20, 25};
            int[] allowedSixes = {0, 6, 12, 18, 24, 30};

            bool valid = true;

            if (onesEntered != 0 && onesEntered < 1 || onesEntered >= 6)
            {
                MessageBox.Show("Ogiltigt värde för ettor. Försök igen.");
                valid = false;
            }
            if (twosEntered != 0 && twosEntered < 2 || twosEntered >= 11 || !allowedTwos.Contains(twosEntered))
            {
                MessageBox.Show("Ogiltigt värde för tvåor. Försök igen.");
                valid = false;
            }
            if (threesEntered != 0 && threesEntered < 3 || threesEntered >= 16 || !allowedThrees.Contains(threesEntered))
            {
                MessageBox.Show("Ogiltigt värde för treor. Försök igen.");
                valid = false;
            }
            if (foursEntered != 0 && foursEntered < 4 || foursEntered >= 21 || !allowedFours.Contains(foursEntered))
            {
                MessageBox.Show("Ogiltigt värde för fyror. Försök igen.");
                valid = false;
            }
            if (fivesEntered != 0 && fivesEntered < 5 || fivesEntered >= 26 || !allowedFives.Contains(fivesEntered))
            {
                MessageBox.Show("Ogiltigt värde för femmor. Försök igen.");
                valid = false;
            }
            if (sixesEntered != 0 && sixesEntered < 6 || sixesEntered >= 31 || !allowedSixes.Contains(sixesEntered))
            {
                MessageBox.Show("Ogiltigt värde för sexor. Försök igen.");
                valid = false;
            }
            int sum = (onesEntered + twosEntered + threesEntered + foursEntered + fivesEntered + sixesEntered);

            if (valid == true)
            {
                if (sum >= 63)
                {
                    sum = (sum + 50);

                    resultDisplay.Content = ($"Du fick: {sum} poäng \n- inklusive bonus.");
                }

                else
                {
                    resultDisplay.Content = ($"Du fick: {sum} poäng.");
                }
            }

        }
    }
}