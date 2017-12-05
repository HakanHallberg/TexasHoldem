using System;
using System.Collections.Generic;
using System.Text;
using TexasHoldem.Library.Enums;

namespace TexasHoldem.Library.Structs
{
    public struct Card: IComparable
    {
        public Values Value { get; }
        public Suits Suit { get; }
        public string Output
        {
            get
            {
                var value = (int)Value <= 10 ? ((int)Value).ToString()
                    : Value.ToString().Substring(0, 1);
                return $"{value}\n{(int)Suit}";
            }
        }

        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public int CompareTo(object obj)
        {
            var obj1 = (int)Value;
            var obj2 = (int)((Card)obj).Value;
            return obj1.CompareTo(obj2);
        }

    }

    
}
