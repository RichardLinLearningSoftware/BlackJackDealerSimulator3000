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
            SuspendLayout();
            // 
            // MainTitle
            // 
            MainTitle.Anchor = AnchorStyles.None;
            MainTitle.AutoSize = true;
            MainTitle.Font = new Font("Segoe UI", 50F);
            MainTitle.ForeColor = Color.White;
            MainTitle.Location = new Point(250, 50);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new Size(891, 133);
            MainTitle.TabIndex = 0;
            MainTitle.Text = "BlackJackSimulator";
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.White;
            StartButton.Font = new Font("Segoe UI", 12F);
            StartButton.Location = new Point(648, 257);
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
            ExitButton.Location = new Point(648, 329);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 66);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // BlackJackWindow
            // 
            AutoSize = true;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1382, 516);
            Controls.Add(ExitButton);
            Controls.Add(StartButton);
            Controls.Add(MainTitle);
            Name = "BlackJackWindow";
            WindowState = FormWindowState.Maximized;
            Load += BlackJackWindow_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label MainTitle;
        private Button StartButton;
        private Button ExitButton;
    }
}
