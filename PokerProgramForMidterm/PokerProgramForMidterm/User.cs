using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProgramForMidterm
{
    public class User
    {




        private List<Card> usersCommunityCards;
        public void addCommunityCards(List<Card> cards)
        {
            usersCommunityCards = cards;

        }
        public void createUsersHand()
        {
            // need to create their hand of 5 of 7 cards total,
            //so this is constantly changing if even kept...
            //lets say we "have" seven but only can apply 5 or less
        }

        private HoleHand usersHoleHand;
        public HoleHand getUsersHoleHand()
        {
            return usersHoleHand;
        }

        public User(HoleHand hand)
        {
            usersHoleHand = hand;
            

        }
        

    }

}
