using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Picture_Matching_Game
{
    public partial class GamePage : Form
    {
        #region Variables

        // This string contains player name and player score database path.
        string scoreBoardTxtPath = @"..\..\scoreBoard.txt";
        // This string array contains card images.
        string[] cardImages = {
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\carpi.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\kalp.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\kare.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\ucgen.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\yildiz.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\yuvarlak.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\carpi.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\kalp.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\kare.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\ucgen.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\yildiz.png",
            @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\yuvarlak.png"
        };
        // This string array contains after shuffling card images.
        string[] buttonImages = new string[12];
        // This button array contains dynamic create buttons.
        Button[] buttonArray = new Button[12];
        // This integer variable contains card show time.
        private int _cardShowTimerCounter = 3;
        // This integer variable contains round time.
        private int _roundTimerCounter = 10;
        // This integer variable contains openned card.
        private int _opennedCard = 0;
        // This string array contains knowned cards.
        string[] knownedCards = new string[12];
        // This integer variable contains knowned cards array index.
        int knownedCardsIndex = 0;
        // This integer variable conrains total knowned card.
        private int _knownedCard = 0;
        // This string variable contains first openned card image path.
        private string _firstCardImagePath;
        // This string variable contains second openned card image path.
        private string _secondCardImagePath;
        // This string variable contains first openned card name.
        private string _firstCardName;
        // This string variable contains second openned card name.
        private string _secondCardName;
        // This integer variable contains player 1 point.
        private int _player1point = 0;
        // This integer variable contains player 2 point.
        private int _player2point = 0;

        #endregion

        public GamePage()
        {
            InitializeComponent();
        }

        #region Private methods

        /// <summary>
        /// Create uttons method.
        /// </summary>
        private void CreateButtons()
        {
            // create all buttons
            for (int i = 0; i < buttonArray.Length; i++)
            {
                Button button = new Button();

                buttonArray[i] = button;

                buttonArray[i].Size = new Size(125, 162);

                buttonArray[i].Name = i.ToString();

                // add click event to buttons.
                buttonArray[i].Click += new EventHandler(Cards_Click);

                // add buttons to flow layout panel.
                flowLayoutPanel.Controls.Add(buttonArray[i]);

            }

        }

        /// <summary>
        /// Dynamic created buttons click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cards_Click(object sender, EventArgs e)
        {
            // new button object. clicked button.
            Button button = (Button)sender;

            // control to first or second card.
            if (_opennedCard == 0)
            {
                // first card information.
                _firstCardImagePath = buttonImages[Convert.ToInt32(button.Name)];
                button.Image = Image.FromFile(buttonImages[Convert.ToInt32(button.Name)]);
                _firstCardName = button.Name;

                _opennedCard++;
            }
            else
            {
                // second card information.
                _secondCardImagePath = buttonImages[Convert.ToInt32(button.Name)];
                button.Image = Image.FromFile(buttonImages[Convert.ToInt32(button.Name)]);
                _secondCardName = button.Name;

                // if the first card and the second card are equal.
                if (_firstCardName == _secondCardName)
                {
                    return;
                }

                // cards show a second.
                _cardShowTimerCounter = 1;
                cardShowTimer.Start();

                // all buttons (cards) enabled closed.
                for (int i = 0; i < buttonArray.Length; i++)
                {
                    buttonArray[i].Enabled = false;
                }

                // if the matching is correct.
                if (_firstCardImagePath == _secondCardImagePath)
                {
                    // knowned card information.
                    _knownedCard++;
                    knownedCards[knownedCardsIndex] = _firstCardName;
                    knownedCardsIndex++;
                    knownedCards[knownedCardsIndex] = _secondCardName;
                    knownedCardsIndex++;

                    // The correctly buttons (cards) enabled closed.
                    buttonArray[Convert.ToInt32(_firstCardName)].Enabled = false; ;
                    buttonArray[Convert.ToInt32(_secondCardName)].Enabled = false;

                    // if the current player is player 1. 
                    if (nextPlayerLabel.Text == player1NameLabel.Text)
                    {
                        _player1point += 10;
                        player1ScoreLabel.Text = _player1point.ToString();
                    }
                    else // if the current player is player 2.
                    {
                        _player2point += 10;
                        player2ScoreLabel.Text = _player2point.ToString();
                    }

                    // if all cards is knowned.
                    if (_knownedCard == 6)
                    {
                        GameOver();
                    }

                }
                else // if the matching is not correct.
                {
                    NextPlayer();
                }

                // reset to card information.
                _opennedCard = 0;
                _firstCardName = "";
                _secondCardName = "";
                _firstCardImagePath = "";
                _secondCardImagePath = "";

            }

        }

        /// <summary>
        /// Shuffle the cards method.
        /// </summary>
        private void ShuffleTheCards()
        {
            // this integer array contains added card indexs.
            int[] addedIndex = new int[12];
            // this integer variable contains added index array index. 
            int index = -1;
            // new random object.
            Random r = new Random();
            //this integer variable contains random number.
            int random;

            // check to all buttons (cards).
            for (int i = 0; i < buttonImages.Length; i++)
            {
                index++;

                // if currrent card is zeroth card.
                if (i == 0)
                {
                    random = r.Next(0, cardImages.Length);
                    buttonImages[i] = cardImages[random];
                    addedIndex[index] = random;
                }
                else // if current card is not zeroth card.
                {

                    random = r.Next(0, cardImages.Length);

                    // chect to current card previous cards.
                    for (int k = cardImages.Length - 1; k >= 0; k--)
                    {
                        // if there was previous. retry.
                        if (random == addedIndex[k])
                        {
                            random = r.Next(0, cardImages.Length);
                            k = cardImages.Length - 1;
                        }
                    }

                    buttonImages[i] = cardImages[random];
                    addedIndex[index] = random;
                }
            }

        }

        /// <summary>
        /// Add to button images method.
        /// </summary>
        private void AddToButtonImages()
        {
            // all buttons (cards) match to images.
            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Image = Image.FromFile(buttonImages[i]);
            }

        }

        /// <summary>
        /// All card close method.
        /// </summary>
        public void AllCardsClose()
        {
            // this string variable contains card cclosed image path.
            string cardClosedImagePath = @"C:\Users\muham\source\repos\Picture_Matching_Game\Picture_Matching_Game\Pictures\kapaliKart.png";

            // this bolean variable contains "card is knowned?".
            bool ctrl;

            // check to all buttons (cards).
            for (int i = 0; i < buttonArray.Length; i++)
            {
                ctrl = false;
                for (int j = 0; j < knownedCards.Length; j++)
                {
                    // if the card is knowned.
                    if (buttonArray[i].Name == knownedCards[j])
                    {
                        ctrl = true;
                    }
                }

                // if card is not knowned.
                if (ctrl == false)
                {
                    buttonArray[i].Image = Image.FromFile(cardClosedImagePath);
                    buttonArray[i].Enabled = true;
                }
            }

        }

        /// <summary>
        /// Next player method.
        /// </summary>
        private void NextPlayer()
        {
            // round time informaiton.
            _roundTimerCounter = 10;
            timeLabel.Text = _roundTimerCounter.ToString();
            roundTimer.Start();

            // if current player is player 2. next player is player 1.
            if (nextPlayerLabel.Text == player2NameLabel.Text)
            {
                nextPlayerLabel.Text = player1NameLabel.Text;
            }
            else // if current player is player 1. next player is player 2.
            {
                nextPlayerLabel.Text = player2NameLabel.Text;
            }
        }

        /// <summary>
        /// Game over method.
        /// </summary>
        private void GameOver()
        {
            // all timer is stoped.
            cardShowTimer.Stop();
            roundTimer.Stop();

            // if winner is player 1.
            if (_player1point > _player2point)
            {
                MessageBox.Show(player1NameLabel.Text + " Kazandı.");

                //player 1 write to database
                File.AppendAllText(scoreBoardTxtPath, "\n" + player1NameLabel.Text + "#" + _player1point.ToString(), Encoding.UTF8);

            }
            else if (_player1point < _player2point) // if winner is player 2.
            {
                MessageBox.Show(player2NameLabel.Text + " Kazandı.");

                //player 2 write to database
                File.AppendAllText(scoreBoardTxtPath, "\n" + player2NameLabel.Text + "#" + _player2point.ToString(), Encoding.UTF8);

            }
            else // if draw.
            {
                MessageBox.Show("Berabere :)");

                // player 1 and player 2 write to database. 
                File.AppendAllText(scoreBoardTxtPath, "\n" + player1NameLabel.Text + "#" + _player1point.ToString(), Encoding.UTF8);
                File.AppendAllText(scoreBoardTxtPath, "\n" + player2NameLabel.Text + "#" + _player2point.ToString(), Encoding.UTF8);

            }

        }

        #endregion

        /// <summary>
        /// Game page load method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GamePage_Load(object sender, EventArgs e)
        {

            // call to methods.
            CreateButtons();
            ShuffleTheCards();
            AddToButtonImages();

            // all timers is started.
            cardShowTimer.Start();
            _roundTimerCounter = 13;
            timeLabel.Text = _roundTimerCounter.ToString();
            roundTimer.Start();

            // player information.
            player1NameLabel.Text = GameInformationsPage.player1Name;
            player2NameLabel.Text = GameInformationsPage.player2Name;

            // next player is player 1.
            nextPlayerLabel.Text = player1NameLabel.Text;

        }

        #region Timer events

        /// <summary>
        /// Card show timer tick event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cardShowTimer_Tick(object sender, EventArgs e)
        {
            _cardShowTimerCounter--;

            // if time is out. all card closed.
            if (_cardShowTimerCounter == 0)
            {

                cardShowTimer.Stop();

                AllCardsClose();

            }

        }

        /// <summary>
        /// Round timer tick event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundTimer_Tick(object sender, EventArgs e)
        {
            _roundTimerCounter--;
            timeLabel.Text = _roundTimerCounter.ToString();

            // time is out. next player.
            if (_roundTimerCounter == 0)
            {
                NextPlayer();
            }

        }

        #endregion

        /// <summary>
        /// Quit button method. Go to Welcome page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitButton_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Hide();
        }

    }
}
