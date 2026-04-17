using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BlackJackDealerSimulator3000.Classes
{
    internal class Hand
    {
        ArrayList hand = new ArrayList();

        public void AddCard( Card card, bool flipCard = false)
        {
            if (flipCard)
            {
                card.Flip();
            }
            hand.Add(card);
        }
    }
}
