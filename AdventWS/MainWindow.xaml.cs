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

namespace AdventWS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _song;
        List<string> _words = new List<string>();
        string _currentW = "";

        public MainWindow()
        {
            InitializeComponent();
        }
        
        public List<string> WordInList(string song)
        {
            foreach (char c in _song)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (_currentW.Length > 0)
                    {
                        _words.Add(_currentW);
                        _currentW = "";
                    }
                }
                else
                {
                    _currentW += c;
                }
            }
            return _words;
        }

        public void ChristmasChecker(List<string> words)
        {
            bool found = false;
            foreach (string word in _words)
            {
                if(word == "jul")
                {
                    found = true;
                    break;
                }
            }
            if(found)
            {
                MessageBox.Show("Låten är en jullåt!");
            }
            else
            {
                MessageBox.Show("Låten är INTE en jullåt!");
            }

        }


        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            _song = txtSong.Text;

            WordInList(_song);

            ChristmasChecker(_words);

        }
    }
}