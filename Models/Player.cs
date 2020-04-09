using System;
using System.Collections.Generic;

namespace DojoCards.Models
{
    public class Player
    {

        public string Name;
        private List<Card> _hand;
        private Deck _deckInstance;

        public Player(Deck deckInstance, string name = "Henry")
        {
            Name = name;
            _hand = new List<Card>();
            _deckInstance = deckInstance;
        }

        public void Draw(int num = 1) {
            List<Card> newCards = _deckInstance.Deal(num);
            foreach(Card card in newCards)
            {
                _hand.Add(card);
            }
        }

        public void Display()
        {
            Console.WriteLine($"{Name} is holding {_hand.Count} card(s)");
            foreach(Card card in _hand)
            {
                Console.WriteLine( card.Display() );
            }
        }
        public void discard(int num){
            Console.WriteLine("Remove " + _hand[num].Display());
            _hand.Remove(_hand[num]);
            
            if(_hand[num] == null)
            {
                Console.WriteLine("does not exist");
            }
        }

    }
}