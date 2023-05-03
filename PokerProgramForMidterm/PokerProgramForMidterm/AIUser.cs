using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProgramForMidterm
{
    class AIUser : User
    {


        private List<Card> aisCommunityCards;
        public void addCommunityCards(List<Card> cards) //ais hole cards
        {
            aisCommunityCards = cards;

        }


        private Hand aisHand;
        public AIUser(HoleHand hand) : base(hand)
        {
            aisHand = hand; // might need to adjust this since we dont want ai knowing users hand..?
        }


        public void Bet()
        {

        }
        public void Raise()
        {

        }
        public void Check()
        {

        }
        public void Fold()
        {

        }
        public void Leave()
        {

        }






    }
}
