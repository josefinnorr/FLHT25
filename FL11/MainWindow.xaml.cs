using System.Windows;

namespace FL11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double _totalSum = 0;
        int _nmbrOfPrdcts = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rabatt baserad på antal varor kunden köper.
        /// </summary>
        /// <returns></returns>
        private double DiscountBsdOnPrdcts()
        {
            double discount = 0;

            if (_nmbrOfPrdcts > 5 && _nmbrOfPrdcts < 10)
            {
                discount = _totalSum * 0.1;
            }
            else if (_nmbrOfPrdcts >= 10)
            {
                discount = _totalSum * 0.2;
            }
            return discount;
        }

        /// <summary>
        /// Rabatt baserad på kundens totala köp.
        /// </summary>
        /// <returns></returns>
        private double DiscountBsdOnPrize()
        {
            double discount = 0;
            if (_totalSum >= 500 && _totalSum < 1000)
            {
                discount = _totalSum * 0.05;
            }
            if (_totalSum >= 1000 && _totalSum < 2000)
            {
                discount = _totalSum * 0.1;
            }
            else if (_totalSum >= 2000)
            {
                discount = _totalSum * 0.2;
            }
            return discount;
        }

        private double TotalDiscount()
        {
            double discount = 0;
            discount = DiscountBsdOnPrdcts();
            discount += DiscountBsdOnPrize();
            return discount;
        }

        private double FinalPrize()
        {
            double finalPrice = _totalSum - TotalDiscount();
            return finalPrice;
        }

        private void btnsumma_Click(object sender, RoutedEventArgs e)
        {
            
            //hämta in summan från gränssnittet

            double pris = double.Parse(txtPris.Text);

            _nmbrOfPrdcts++;

            //öka totalsumman med varans pris

            _totalSum += pris;


            //hämtar discount från metod.

            double discount = TotalDiscount();

            //visar priset
           txtTotal.Text = FinalPrize().ToString();

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            _totalSum = 0;
            txtPris.Text = "";
            txtTotal.Text = "";
        }
    }
}