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

namespace FL14_Eggfarm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Farm _farm = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _farm.BuyEggs(120);

            List<Egg> fertileEggs = _farm.GetAllEggs();
            lstEggs.ItemsSource = null;
            lstEggs.ItemsSource = fertileEggs;
        }

        private void lstEggs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Egg? selectedEgg = lstEggs.SelectedItem as Egg;

            if(selectedEgg is null)
            {
                return;
            }
            Chicken? chicken = _farm.HatchEgg(selectedEgg);

            if (chicken is null)
            {
                MessageBox.Show("Det blev ingen kyckling.");
            }
            else
            {
                MessageBox.Show($"Kycklingen {chicken.Name} med ID {chicken.ID} har kläckts");
            }
        }
    }
} 