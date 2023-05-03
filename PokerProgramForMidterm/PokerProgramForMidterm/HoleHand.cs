using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProgramForMidterm
{
    public class HoleHand : Hand
    {
        public HoleHand(Deck deck)
        {
            List<Card> Cards = new List<Card>();
             // initial 2 whole cards
            for (int cardNumber = 1; cardNumber <= 2; cardNumber++)
            {
                Cards.Add(deck.PickCard());
            }
        }

    }
}
