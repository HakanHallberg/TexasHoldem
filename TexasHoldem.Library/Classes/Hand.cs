using System;
using System.Collections.Generic;
using System.Text;
using TexasHoldem.Library.Structs;

namespace TexasHoldem.Library.Classes
{
    class Hand
    {
        public List<Card> Cards { get; } = new List<Card>();
        public List<Card> BestCards { get; } = new List<Card>();
        public List<Card> PlayerCards { get; } = new List<Card>();

        public void Clear()
        {
            this.Cards.Clear();
            this.BestCards.Clear();
            this.PlayerCards.Clear();
        }

        public void AddCard(Card card, bool isPlayerCard)
        {
            if (isPlayerCard = true || PlayerCards.Count < 2)
            {
                PlayerCards.Add(card);
                Cards.Add(card);
            }
        }
    }
}
