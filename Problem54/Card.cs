using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem54
{
    class Card
    {
        int value;
        int suit;
        public Card(string s)
        {
            this.parse(s.ToCharArray());
        }
        public void parse(char[] s)
        {

            switch (s[0])
            {
                case 'A':
                    value = 14;
                    break;
                case 'K':
                    value = 13;
                    break;
                case 'Q':
                    value = 12;
                    break;
                case 'J':
                    value = 11;
                    break;
                case 'T':
                    value = 10;
                    break;
                default:
                    value = s[0]-48;
                    break;
            }
            switch (s[1])
            {
                
                case 'D':
                    suit = 4;
                    break;
                case 'H':
                    suit = 3;
                    break;
                case 'S':
                    suit = 2;
                    break;
                case 'C':
                    suit = 1;
                    break;
            }
        }
        public static int Compare(Card a, Card b)
        {
            return a.value.CompareTo(b.value);
        }
        public int Suit()
        {
            return suit;
        }
    }
}
