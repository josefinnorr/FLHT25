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

namespace Rock_Paper_Scissors_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random _rnd = new Random();
        string _playerChoice;
        string _compChoice;
        int _playerScore;
        int _compScore;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method handles the computers choice: rock, paper or scissors.
        /// </summary>
        /// <returns></returns>
        private string CompChoice()
        {
            int compChoice = _rnd.Next(1, 4);

            if(compChoice == 1)
            {
                _compChoice = "Rock";
            }

            if(compChoice == 2)
            {
                _compChoice = "Paper";
            }

            if(compChoice == 3)
            {
                _compChoice = "Scissors";
            }

            return _compChoice;
        }

        /// <summary>
        /// Method handles the winner of the game by comparing strings.
        /// </summary>
        private void DetermineWinner()
        {
            if (_compChoice == _playerChoice)
            {
                txtStatus.Text = ($"It's a draw!\nYou both chose {_playerChoice}.");
                lstRoundWins.Items.Add("Draw");
                lstRoundWins.ScrollIntoView(lstRoundWins.Items[lstRoundWins.Items.Count - 1]);

            }
            else if ((_playerChoice == "Rock" && _compChoice == "Scissors") ||
                     (_playerChoice == "Paper" && _compChoice == "Rock") ||
                     (_playerChoice == "Scissors" && _compChoice == "Paper"))
            {
                txtStatus.Text = ($"You win!\nComputer chose {_compChoice}.");
                _playerScore++;
                lstRoundWins.Items.Add("You won");
                lstRoundWins.ScrollIntoView(lstRoundWins.Items[lstRoundWins.Items.Count - 1]);


            }
            else
            {
                txtStatus.Text = ($"You lose.\nComputer chose {_compChoice}.");
                _compScore++;
                lstRoundWins.Items.Add("Computer won");
                lstRoundWins.ScrollIntoView(lstRoundWins.Items[lstRoundWins.Items.Count - 1]);

            }

            lstScore.Items.Clear();
            lstScore.Items.Add($"Your Score: {_playerScore}");
            lstScore.Items.Add($"Computer Score: {_compScore}");

        }

        private void btnRock_Click(object sender, RoutedEventArgs e)
        {
            _compChoice = CompChoice();
            _playerChoice = "Rock";
            DetermineWinner();

        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            _compChoice = CompChoice();
            _playerChoice = "Paper";
            DetermineWinner();
        }

        private void btnScissors_Click(object sender, RoutedEventArgs e)
        {
            _compChoice = CompChoice();
            _playerChoice = "Scissors";
            DetermineWinner();
        }
    }
    }