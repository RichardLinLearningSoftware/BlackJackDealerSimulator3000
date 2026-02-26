using System.Diagnostics;

namespace BlackJackDealerSimulator3000
{
    public partial class BlackJackWindow : Form
    {
        public BlackJackWindow()
        {
            InitializeComponent();
        }

        //Loads the window for the whole game.
        private void BlackJackWindow_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Loaded");
        }

        //Test
        private void Test_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked");
        }
    }
}
