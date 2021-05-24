using System;
using System.IO;
using System.Windows.Forms;

namespace Picture_Matching_Game
{
    public partial class HighScoresPage : Form
    {
        // This string contains player name and player score database path.
        string scoreBoardTxtPath = @"..\..\scoreBoard.txt";
        // This string array contains player details.
        private string[] _playerDetails = File.ReadAllLines(@"..\..\scoreBoard.txt");
        // This string array contains a player details.
        private string[] _playerNamesAndScores;

        public HighScoresPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Print scores method.
        /// </summary>
        private void PrintScores()
        {

            // listview configurations.
            scoreBoardListView.View = View.Details;
            scoreBoardListView.GridLines = true;

            // add columns.
            scoreBoardListView.Columns.Add("Skor", 220);
            scoreBoardListView.Columns.Add("Oyuncu", 220);

            // add all players.
            for (int i = 0; i < _playerDetails.Length; i++)
            {
                _playerNamesAndScores = _playerDetails[i].Split('#');
                scoreBoardListView.Items.Add(_playerNamesAndScores[1]);
                scoreBoardListView.Items[i].SubItems.Add(_playerNamesAndScores[0]);
            }

            // sorting player with score.
            scoreBoardListView.Sorting = SortOrder.Descending;
        }

        /// <summary>
        /// Hihgg scores pge load method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighScoresPage_Load(object sender, EventArgs e)
        {
            // call to 'print scores' method.
            PrintScores();
        }

        /// <summary>
        /// Reset button method. Delete all scores infprmation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetbutton_Click(object sender, EventArgs e)
        {
            File.Delete(scoreBoardTxtPath);
            FileStream filecreate = new FileStream(scoreBoardTxtPath, FileMode.OpenOrCreate, FileAccess.Write);
            filecreate.Close();
            scoreBoardListView.Items.Clear();
        }

        /// <summary>
        /// Back button method. Go to Welcome Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            this.Dispose();
            welcomePage.Show();
        }

    }
}
