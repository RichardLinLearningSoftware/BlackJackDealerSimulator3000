using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BlackJackDealerSimulator3000.Classes
{
    internal class Hand
    {
        private String playerName;
        ArrayList hand = new ArrayList();

        public void AddCard( Card card, bool flipCard = false)
        {
            if (flipCard)
            {
                card.Flip();
            }
            hand.Add(card);
        }
        public Hand(String playerName)
        {
            this.playerName = playerName;
        }

        public string StandOrHit()
        {
            Random random = new Random();
            int randomInt = random.Next(0, 2);
            if(randomInt == 0)
            {
                return "I want to Stand";
            }
            return "I want to Hit";
        }
    }
}
