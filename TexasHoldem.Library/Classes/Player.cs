using System;
using System.Collections.Generic;
using System.Text;
using TexasHoldem.Library.Structs;

namespace TexasHoldem.Library.Classes
{
    public class Player
    {        
        private Hand _hand;
        public string Name;
        List<Card> Cards { get { return _hand.Cards; } } 
        List<Card> BestCards { get { return _hand.BestCards; } } 
        List<Card> PlayerCards { get { return _hand.PlayerCards; } }

        public int CardCount { get { return _hand.Cards.Count; } }

        public Player(string name)
        {
            Name = name;
            _hand = new Hand();
        }

        public void RecieveCard (Card card, bool isPlayerCard = false)
        {
            
            _hand.AddCard(card, isPlayerCard);
        }

        public void ClearHand()
        {
            _hand.Clear();
        }
    }
}
