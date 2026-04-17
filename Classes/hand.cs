using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BlackJackDealerSimulator3000.Classes
{
    internal class Hand
    {
        private String playerName;
        //The player state can be hit or stand
        private String playerState = "none";
        List<Card> hand = new List<Card>
        {
        };

        private Control parent;
        private Deck mainDeck;

        public Hand(String playerName, Control parentControl, Deck deck)
        {
            this.playerName = playerName;
            parent = parentControl;
            mainDeck = deck;
        }

        public void AddCard( Card card)
        {
            hand.Add(card);
        }

        public string StandOrHit()
        {
            Random random = new Random();
            int randomInt = random.Next(0, 2);
            if (randomInt == 0)
            {
                if (playerState == "stand")
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

        public void CreatePlayer(string text = "empty", int width = 100, int height = 100, int x = 50, int y = 50)
        {
            Button player = new Button();
            //Set properties
            player.Text = text;
            player.Location = new Point(x, y);
            player.Size = new Size(width, height);
            player.BackColor = Color.White;
            player.Click += (sender, e) =>
            {
                if (playerState != "stand")
                {
                    player.Text = playerName + ": " + StandOrHit();
                }
                DisplayCard(hand.Count);
            };
            //Add player to the form
            parent.Controls.Add(player);
            player.BringToFront();
        }

        private static List<Button> createdCard = new List<Button>();
        public void DisplayCard(int totalCards)
        {
            int positionX = (parent.ClientSize.Width - (105 * totalCards)) / 2;
            Button button = new Button();

            foreach (var btn in createdCard)
            {
                parent.Controls.Remove(btn);
                btn.Dispose();
            }
            createdCard.Clear();

            //Set properties
            button.Text = "Give card";
            button.Size = new Size(100, 100);
            button.Location = new Point(positionX, (parent.ClientSize.Height + 300)/2);
            button.BackColor = Color.White;
            button.Click += (sender, e) =>
            {
                if (playerState != "stand")
                {
                    AddCard(mainDeck.removeCard());
                }
                DisplayCard(hand.Count);
            };
            //Displays Give card button
            parent.Controls.Add(button);
            button.BringToFront();
            createdCard.Add(button);

            if (totalCards <= 0) return;
            for (int i = 0; i < totalCards; i++)
            {
                //Set properties
                button.Text = hand[i].ToString();
                button.Size = new Size(100, 170);
                button.Location = new Point(positionX + (i * 105), (parent.ClientSize.Height - 170) / 2);
                button.BackColor = Color.White;

                //Displays cards
                parent.Controls.Add(button);
                button.BringToFront();
                createdCard.Add(button);
            }
        }

        internal void CreatePlayer()
        {
            throw new NotImplementedException();
        }
    }
}
