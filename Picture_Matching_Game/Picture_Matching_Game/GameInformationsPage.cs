using System;
using System.Windows.Forms;

namespace Picture_Matching_Game
{
    public partial class GameInformationsPage : Form
    {

        // This static string variable contains player 1 name.
        public static string player1Name;
        // This static string variable contains player 2 name.
        public static string player2Name;

        public GameInformationsPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start button method. Check and go to Game page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            // player informations.
            player1Name = player1NameTextBox.Text;
            player2Name = player2NameTextBox.Text;

            // control to player names.
            if (player1NameTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Oyuncu-1 bilgisini girin.");
            }
            else if (player2NameTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Oyuncu-2 bilgisini girin.");
            }
            else // if player names correcly go to game page.
            {
                GamePage gamePage = new GamePage();
                this.Dispose();
                gamePage.Show();
            }

        }

        /// <summary>
        /// Back button method. Go to Welcome page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Hide();
        }
    }
}
