using System.Windows;

namespace HarryPotter_WS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hogwarts hogwarts = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Wizard wizard = new Wizard()
            {
                Name = txtName.Text
            };

            string name = txtName.Text;

            hogwarts.Wizards.Add(wizard);

            Wand wand = new Wand()
            {
                Kernal = "Dragonsblood",
                Name = $"{name}s Wand",
                Wood = "Olive"
            };

            wizard.Wand = wand;
        }
    }
}