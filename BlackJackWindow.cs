using System.Diagnostics;
using BlackJackDealerSimulator3000.Classes;

namespace BlackJackDealerSimulator3000
{
    public partial class BlackJackWindow : Form
    {
        public BlackJackWindow()
        {
            InitializeComponent();
        }

        Card card1 = new Card(Rank.ACE, Suit.SPADES);
        Card card2 = new Card(Rank.TWO, Suit.SPADES);
    }
}
