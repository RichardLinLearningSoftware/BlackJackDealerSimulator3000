using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace BlackJackDealerSimulator3000
{
    partial class BlackJackWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTitle = new Label();
            StartButton = new Button();
            ExitButton = new Button();
            MenuButton = new Button();
            Deck = new Button();
            choosePlayer1 = new Button();
            choosePlayer2 = new Button();
            choosePlayer3 = new Button();
            choosePlayer4 = new Button();
            choosePlayer5 = new Button();
            SuspendLayout();
            // 
            // MainTitle
            // 
            MainTitle.Anchor = AnchorStyles.None;
            MainTitle.AutoSize = true;
            MainTitle.Font = new Font("Segoe UI", 50F);
            MainTitle.ForeColor = Color.White;
            MainTitle.Location = new Point(130, 12);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new Size(891, 133);
            MainTitle.TabIndex = 0;
            MainTitle.Text = "BlackJackSimulator";
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.White;
            StartButton.Font = new Font("Segoe UI", 12F);
            StartButton.Location = new Point(12, 76);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(112, 66);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.White;
            ExitButton.Font = new Font("Segoe UI", 12F);
            ExitButton.Location = new Point(12, 135);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 66);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.White;
            MenuButton.Font = new Font("Segoe UI", 12F);
            MenuButton.Location = new Point(12, 12);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(112, 66);
            MenuButton.TabIndex = 1;
            MenuButton.Text = "Menu";
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // Deck
            // 
            Deck.Location = new Point(12, 207);
            Deck.Name = "Deck";
            Deck.Size = new Size(141, 194);
            Deck.TabIndex = 2;
            Deck.Text = "Deck";
            Deck.UseVisualStyleBackColor = true;
            Deck.Click += ShuffleDeck;
            // 
            // choosePlayer1
            // 
            choosePlayer1.BackColor = Color.White;
            choosePlayer1.Font = new Font("Segoe UI", 12F);
            choosePlayer1.Location = new Point(635, 225);
            choosePlayer1.Name = "choosePlayer1";
            choosePlayer1.Size = new Size(65, 66);
            choosePlayer1.TabIndex = 3;
            choosePlayer1.Text = "1";
            choosePlayer1.UseVisualStyleBackColor = false;
            // 
            // choosePlayer2
            // 
            choosePlayer2.BackColor = Color.White;
            choosePlayer2.Font = new Font("Segoe UI", 12F);
            choosePlayer2.Location = new Point(706, 225);
            choosePlayer2.Name = "choosePlayer2";
            choosePlayer2.Size = new Size(65, 66);
            choosePlayer2.TabIndex = 4;
            choosePlayer2.Text = "2";
            choosePlayer2.UseVisualStyleBackColor = false;
            // 
            // choosePlayer3
            // 
            choosePlayer3.BackColor = Color.White;
            choosePlayer3.Font = new Font("Segoe UI", 12F);
            choosePlayer3.Location = new Point(777, 225);
            choosePlayer3.Name = "choosePlayer3";
            choosePlayer3.Size = new Size(65, 66);
            choosePlayer3.TabIndex = 5;
            choosePlayer3.Text = "3";
            choosePlayer3.UseVisualStyleBackColor = false;
            // 
            // choosePlayer4
            // 
            choosePlayer4.BackColor = Color.White;
            choosePlayer4.Font = new Font("Segoe UI", 12F);
            choosePlayer4.Location = new Point(848, 225);
            choosePlayer4.Name = "choosePlayer4";
            choosePlayer4.Size = new Size(65, 66);
            choosePlayer4.TabIndex = 6;
            choosePlayer4.Text = "4";
            choosePlayer4.UseVisualStyleBackColor = false;
            // 
            // choosePlayer5
            // 
            choosePlayer5.BackColor = Color.White;
            choosePlayer5.Font = new Font("Segoe UI", 12F);
            choosePlayer5.Location = new Point(919, 225);
            choosePlayer5.Name = "choosePlayer5";
            choosePlayer5.Size = new Size(65, 66);
            choosePlayer5.TabIndex = 7;
            choosePlayer5.Text = "5";
            choosePlayer5.UseVisualStyleBackColor = false;
            // 
            // BlackJackWindow
            // 
            AutoSize = true;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1382, 516);
            Controls.Add(choosePlayer5);
            Controls.Add(choosePlayer4);
            Controls.Add(choosePlayer3);
            Controls.Add(choosePlayer2);
            Controls.Add(choosePlayer1);
            Controls.Add(Deck);
            Controls.Add(MenuButton);
            Controls.Add(ExitButton);
            Controls.Add(StartButton);
            Controls.Add(MainTitle);
            Name = "BlackJackWindow";
            WindowState = FormWindowState.Maximized;
            Load += BlackJackWindow_Load;
            ResumeLayout(false);
            PerformLayout();
            // 
            // MenuButton
            // 
        }
        #endregion
        private Label MainTitle;
        private Button StartButton;
        private Button ExitButton;
        private Button MenuButton;
        private Button Deck;
        private Button choosePlayer1;
        private Button choosePlayer2;
        private Button choosePlayer3;
        private Button choosePlayer4;
        private Button choosePlayer5;
    }
}
