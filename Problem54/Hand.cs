using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem54
{
    class Hand
    {
        List<Card> cards = new List<Card>();
        public Hand()
        {

        }
        void addCard(Card card)
        {
            cards.Add(card);
        }
        Card getHighCard()
        {
            return null;
        }
        bool isPair()
        {
            return false;
        }
        bool isTwoPair()
        {
            return false;
        }
        bool isThree()
        {
            return false;
        }
        bool isFullHouse()
        {
            return isPair() && isThree();
        }
        bool isFour()
        {
            return false;
        }
        bool isFlush()
        {
            return (cards[0].Suit() == cards[1].Suit() && cards[1].Suit() == cards[2].Suit() && cards[2].Suit() == cards[3].Suit());
        }
        bool isStrait()
        {
            return false;
        }
        bool isStraitFlush()
        {
            return isFlush() && isStrait();
        }
        bool isRoyalFlush()
        {
            if (this.isFlush())
            {
                return (cards.Contains(new Card("T1")) &&
                cards.Contains(new Card("J1")) &&
                cards.Contains(new Card("Q1")) &&
                cards.Contains(new Card("K1")) &&
                cards.Contains(new Card("A1")));
            }
            return false;
        }
        public static bool operator <(Hand hand1, Hand hand2)
        {

            return Comparison(hand1, hand2) < 0;

        }

        public static bool operator >(Hand hand1, Hand hand2)
        {

            return Comparison(hand1, hand2) > 0;

        }

        public static bool operator ==(Hand hand1, Hand hand2)
        {

            return Comparison(hand1, hand2) == 0;

        }

        public static bool operator !=(Hand hand1, Hand hand2)
        {

            return Comparison(hand1, hand2) != 0;

        }

        public override bool Equals(object obj)
        {

            if (!(obj is Hand)) return false;

            return this == (Hand)obj;

        }

        public static bool operator <=(Hand hand1, Hand hand2)
        {

            return Comparison(hand1, hand2) <= 0;

        }

        public static bool operator >=(Hand hand1, Hand hand2)
        {

            return Comparison(hand1, hand2) >= 0;

        }

        public static int Comparison(Hand hand1, Hand hand2)
        {

            if (1 < 2)

                return -1;

            else if (1 == 1)

                return 0;

            else if (2 > 1)

                return 1;

            return 0;

        }
    }
}
