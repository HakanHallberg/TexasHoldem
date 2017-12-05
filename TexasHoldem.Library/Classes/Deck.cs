using System;
using System.Collections.Generic;
using System.Text;
using TexasHoldem.Library.Enums;
using TexasHoldem.Library.Structs;

namespace TexasHoldem.Library.Classes
{
    public class Deck
    {
        List<Card> _cards = new List<Card>();
        private void NewDeck()
        {
            this._cards.Clear();
            foreach (Suits suits in Enum.GetValues(typeof(Suits)))
            {
                if (suits.Equals(Suits.Unknown)) continue;
                foreach (Values values in Enum.GetValues(typeof(Values)))
                {
                    var card = new Card(values, suits);
                    _cards.Add(card);
                }
            }
        }

        public void ShuffleDeck(int shuffles)
        {
            NewDeck();
            var rnd = new Random();
            for (int i = 0; i < shuffles; i++)
            {
                List<Card> tmpDeck = new List<Card>();
                while (_cards.Count > 0)
                {
                    var index = rnd.Next(_cards.Count);
                    var card = _cards[index];
                    _cards.RemoveAt(index);
                    tmpDeck.Add(card);
                }
                _cards = tmpDeck;
            }       
        }
        
        public void DrawCard()
        {
            var card = _cards[0];
            _cards.Remove(card);
            return;
        }
        

    }

    
}
