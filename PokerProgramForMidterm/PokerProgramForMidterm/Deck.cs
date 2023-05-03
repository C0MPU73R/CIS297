using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PokerProgramForMidterm.Card;

namespace PokerProgramForMidterm
{
    public class Deck //used with permission from Eric Charnesky
    {
        public int CardsRemaining => _cards.Count; //holds our current number of cards remaining
        private Stack<Card> _cards;
        private List<Card> newDeck;

        public Deck(INumberGenerator numberGenerator) //create and shuffle
        {
            _cards = new Stack<Card>(52);
           newDeck = new List<Card>();
            for (int cardNumber = 0; cardNumber < 52; cardNumber++)
            {
                newDeck.Add(new Card
                {
                    suit = (Suit)(cardNumber / 13), //adding each card process
                    face = (Face)(cardNumber % 13 + 2)
                });
            }
            while (newDeck.Count != 0) //shuffling process
            {
                int randomIndex = numberGenerator.Next(0, newDeck.Count);
                _cards.Push(newDeck[randomIndex]);// pushing what is on newDeck at a radom index on to our stack of cards. 
                newDeck.RemoveAt(randomIndex); // then we remove that card we just pushed on our stack, most likely so we dont push it on again by chance
            }
            
        }
        public List<Card> getDeck()
        {
            return newDeck;
        }

        public Card PickCard() //picks card on top of stack then pops it off
        {
            if (_cards.Count == 0)
            {
                throw new IndexOutOfRangeException("No cards left!");
            }
            return _cards.Pop();
        }
    }
}
