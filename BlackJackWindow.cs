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
        }
        //Starting button
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Start screen elements
            MainTitle.Hide();
            ExitButton.Hide();
            StartButton.Hide();

            //Menu stuff
            MenuButton.Show();
            ExitButton.Left = 0 + (ExitButton.Width / 4);
            ExitButton.Top = ExitButton.Height + (ExitButton.Height / 3);
        }
        //Close application button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {        
            if(MenuButton.Text == "Menu")
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
    }
}
