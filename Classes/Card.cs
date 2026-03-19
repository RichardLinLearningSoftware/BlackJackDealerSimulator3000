using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackDealerSimulator3000.Classes
{   
    public enum Rank
    {
        ACE = 1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }

    public enum Suit
    {
        HEARTS,
        CLUBS,
        DIAMONDS,
        SPADES
    }
    internal class Card
    {
        private Rank rank;
        private int value;
        private Suit suit;
        private bool isFacingDown;

        public int Value
        {
            get
            {
                switch (rank)
                {
                    case Rank.TWO:
                        value = 2; break;
                    case Rank.THREE:
                        value = 3; break;
                    case Rank.FOUR:
                        value = 4; break;
                    case Rank.FIVE:
                        value = 5; break;
                    case Rank.SIX:
                        value = 6; break;
                    case Rank.SEVEN:    
                        value = 7; break;
                    case Rank.EIGHT:
                        value = 8; break;
                    case Rank.NINE:
                        value = 9; break;
                    case Rank.TEN:
                        value = 10; break;

                    case Rank.JACK:
                    case Rank.QUEEN:
                    case Rank.KING:
                        value = 10; break;   

                }
                return value; 
            }
        }

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }
        public void Flip()
        {
            if (isFacingDown)
            {
                isFacingDown = false;
            }
            else
            {
                isFacingDown = true;
            }
        }

        public override string ToString()
        {
            return rank.ToString() + " of " + suit.ToString();
        }
    }
}
