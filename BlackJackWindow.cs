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

        private void BlackJackWindow_Load(object sender, EventArgs e)
        {
            //Menu title
            MainTitle.Text = "BlackJack Simulator";
            MainTitle.Left = (this.ClientSize.Width - MainTitle.Width) / 2;
            MainTitle.Top = (this.ClientSize.Height / 2 - MainTitle.Height);

            //start button
            StartButton.Left = (this.ClientSize.Width - StartButton.Width) / 2;
            StartButton.Top = (this.ClientSize.Height + StartButton.Height * 2) / 2;

            //Exit button
            ExitButton.Left = (this.ClientSize.Width - StartButton.Width) / 2;
            ExitButton.Top = (this.ClientSize.Height + StartButton.Height * 5) / 2;

        }

        //Starting button
        private void StartButton_Click(object sender, EventArgs e)
        {
            MainTitle.Hide();
            ExitButton.Hide();
            StartButton.Hide();
        }
        //Close application button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
