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
            testButton = new Button();
            SuspendLayout();
            // 
            // testButton
            // 
            testButton.BackColor = Color.Transparent;
            testButton.Location = new Point(192, 127);
            testButton.Name = "testButton";
            testButton.Size = new Size(197, 63);
            testButton.TabIndex = 0;
            testButton.Text = "click me";
            testButton.UseVisualStyleBackColor = false;
            testButton.Click += Test_Click;
            // 
            // BlackJackWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1220, 450);
            Controls.Add(testButton);
            Name = "BlackJackWindow";
            Tag = "";
            Text = "BlackJack Dealer 3000";
            WindowState = FormWindowState.Maximized;
            Load += BlackJackWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button testButton;
    }
}
