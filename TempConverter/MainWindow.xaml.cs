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

namespace TempConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double _temp = 0;
        double _kelvin = 0;
        double _fahrenheit = 0;
        double _celsius = 0;

        double[] celsiusConversions = new double[3];
        double[] fahrenheitConversions = new double[3];
        double[] kelvinConversions= new double[3];
        string[] presentation = { "Celsius: ", "Fahrenheit: ", "Kelvin: " };

        public MainWindow()
        {
            InitializeComponent();
        }

        private double[] CelsiusConv()
        {
            _celsius = _temp;
            _kelvin = _celsius + 273.15;
            _fahrenheit = _celsius * 1.8 + 32;

            return new double[] { _celsius, _fahrenheit, _kelvin };
        }

        private double[] FahrenheitConv()
        {
            _fahrenheit = _temp;
            _celsius = (_fahrenheit - 32) * 5 / 9;
            _kelvin = (_fahrenheit - 32) * 5.0 / 9.0 + 273.15;

            return new double[] { _celsius, _fahrenheit, _kelvin };
        }

        private double[] KelvinConv()
        {
            _kelvin = _temp;
            _celsius = _kelvin - 273.15;
            _fahrenheit = (_kelvin - 273.15) * 9.0 / 5.0 + 32;

           return new double[] { _celsius, _fahrenheit, _kelvin };
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtTemp.Text, out _temp))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            lstResults.Items.Clear();
           
            if (chkCelsius.IsChecked == true)
            {
               celsiusConversions = CelsiusConv();

                for (int i = 0; i < celsiusConversions.Length; i++)
                {
                    string results = ($"{presentation[i]}{celsiusConversions[i]}");
                    lstResults.Items.Add(results);
                }
               
            }

            if(chkFahrenheit.IsChecked == true)
            {
                fahrenheitConversions = FahrenheitConv();

                for (int i = 0; i < fahrenheitConversions.Length; i++)
                {
                    string results = ($"{presentation[i]}{fahrenheitConversions[i]}");
                    lstResults.Items.Add(results);
                }
            }

            if(chkKelvin.IsChecked == true)
            {
                kelvinConversions = KelvinConv();

                for (int i = 0; i < kelvinConversions.Length; i++)
                {
                    string results = ($"{presentation[i]}{kelvinConversions[i]}");
                    lstResults.Items.Add(results);
                }
            }
        }
    }
}