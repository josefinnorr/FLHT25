using System.Windows;

namespace FL8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _passengersInLine;
        bool nextRide;

        public bool CanRideOnNextRound()
        {
            int passengersBefore = int.Parse(txtNumberOfPassengers.Text);
            int pplInCarousel = (24 * 2);

            if (pplInCarousel <= passengersBefore)
            {
                 nextRide = true;
                return nextRide;
            }
            else
            {
                 nextRide = false;
                return nextRide;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {

            int passengers = int.Parse(txtNumberOfPassengers.Text);

            if (passengers % 2 == 0)
            {
                MessageBox.Show("Karusellen är i balans");
                return;
            }
            else
            {
                MessageBox.Show("Karusellen är i obalans");
                return;
            }
        }

        private void btnQueue_Click(object sender, RoutedEventArgs e)
        {
            if (CanRideOnNextRound() == true)
            {
                MessageBox.Show("Du får vänta lite till.");
            }
            else
            {
                MessageBox.Show("Du får åka!!");
            }

        }
    }
}