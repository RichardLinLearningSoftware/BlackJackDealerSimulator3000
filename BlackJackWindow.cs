using System.Diagnostics;
using System.Reflection.Emit;
using BlackJackDealerSimulator3000.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlackJackDealerSimulator3000
{
    //Variables here

    public partial class BlackJackWindow : Form
    {
        public BlackJackWindow()
        {
            InitializeComponent();
        }
        //Created a deck
        Deck mainDeck = new Deck();

        private void BlackJackWindow_Load(object sender, EventArgs e)
        {
            //Title
            MainTitle.Text = "BlackJack Simulator";
            MainTitle.Left = (this.ClientSize.Width - MainTitle.Width) / 2;
            MainTitle.Top = (this.ClientSize.Height / 2 - MainTitle.Height);

            //start button
            StartButton.Left = (this.ClientSize.Width - StartButton.Width) / 2;
            StartButton.Top = (this.ClientSize.Height + StartButton.Height * 2) / 2;

            //Exit button
            ExitButton.Left = (this.ClientSize.Width - StartButton.Width) / 2;
            ExitButton.Top = (this.ClientSize.Height + StartButton.Height * 5) / 2;

            //Menu button
            MenuButton.Left = 0 + (MenuButton.Width / 4);
            MenuButton.Top = 0 + (MenuButton.Height / 4);
            MenuButton.Hide();

            //Deck
            Deck.Left = 0 + (this.ClientSize.Width - Deck.Width - 15);
            Deck.Top = 0 + (this.ClientSize.Height - Deck.Height - 15);
            //Deck.Text = mainDeck.GetCard(0);
            Deck.Text = "Deck";
            Deck.Hide();
            //Deck.Text = "Card deck";

            //Choose player button
            var chooseButtons = new[] { choosePlayer1, choosePlayer2, choosePlayer3, choosePlayer4, choosePlayer5 };

            for (int i = 0; i < chooseButtons.Length; i++)
            {
                var totalPlayer = chooseButtons[i];
                totalPlayer.Hide();
                totalPlayer.Left = this.ClientSize.Width / 2 + (i - 2) * choosePlayer1.Width;
                totalPlayer.Top = (this.ClientSize.Height + choosePlayer1.Height * 2) / 2;
                int playerNumber = i + 1;
                totalPlayer.Click += (sender, e) => choosePlayer_Click(sender, e, playerNumber);
            }
        }

        //Starting button
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Start screen elements
            MainTitle.Text = "Choose how many players will join the table";
            MainTitle.Left = (this.ClientSize.Width - MainTitle.Width) / 2;
            ExitButton.Hide();
            StartButton.Hide();

            //Menu stuff
            MenuButton.Show();
            ExitButton.Left = 0 + (ExitButton.Width / 4);
            ExitButton.Top = ExitButton.Height + (ExitButton.Height / 3);

            //Choose players buttons
            var chooseButtons = new[] { choosePlayer1, choosePlayer2, choosePlayer3, choosePlayer4, choosePlayer5 };
            for (int i = 0; i < chooseButtons.Length; i++)
            {
                var totalPlayer = chooseButtons[i];
                totalPlayer.Show();
            }
        }
        //Close application button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (MenuButton.Text == "Menu")
            {
                MenuButton.Text = "Close";
                ExitButton.Show();
            }
            else
            {
                MenuButton.Text = "Menu";
                ExitButton.Hide();
            }
        }

        private void ShuffleDeck(object sender, EventArgs e)
        {
            mainDeck.Shuffle();
            //Deck.Text = mainDeck.GetCard(0);
        }

        private void choosePlayer_Click(object sender, EventArgs e, int totalPlayers)
        {
            System.Diagnostics.Debug.WriteLine(totalPlayers);
        }
    }
}
