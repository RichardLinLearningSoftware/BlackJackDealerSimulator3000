using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BlackJackDealerSimulator3000.Classes
{
    internal class Hand
    {
        private String playerName;
        //The player state can be hit or stand
        private String playerState = "none";
        ArrayList hand = new ArrayList();

        public Hand(String playerName)
        {
            this.playerName = playerName;
        }

        public void AddCard( Card card, bool flipCard = false)
        {
            if (flipCard)
            {
                card.Flip();
            }
            hand.Add(card);
        }

        public string StandOrHit()
        {
            Random random = new Random();
            int randomInt = random.Next(0, 2);
            if(randomInt == 0)
            {
                if(playerState == "stand")
                {
                    playerState = "stand";
                    return "I want to Stand again";
                }
                playerState = "stand";
                return "I want to Stand";
            }
            if (playerState == "hit")
            {
                playerState = "hit";
                return "I want to Hit again";
            }
            playerState = "hit";
            return "I want to Hit";
        }

        public void CreatePlayer(Control parent, string text = "empty", int width = 100, int height = 100, int x = 50, int y = 50)
        {
            System.Windows.Forms.Button player = new System.Windows.Forms.Button();

            // Set properties
            player.Text = text;
            player.Location = new System.Drawing.Point(x, y);
            player.Size = new System.Drawing.Size(width, height);
            player.BackColor = Color.White;
            // Add click event
            player.Click += (sender, e) =>
            {
                player.Text = playerName + ": " + StandOrHit();
            };

            // Add button to the form
            parent.Controls.Add(player);
            player.BringToFront();
        }
        internal void CreatePlayer()
        {
            throw new NotImplementedException();
        }
    }
}
