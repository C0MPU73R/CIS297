using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MidtermPokerGamev2.PokerCard;

namespace MidtermPokerGamev2
{
    class PokerDeck
    {

        public List<PokerCard> deckInListForm;
        public int CardsRemaining => deckInListForm.Count; // how many cards we have remaining in our deckList, since it decreases per card shifted into our stack
        private Stack<PokerCard> deckStack;
        public PokerDeck(IRandomNumberGenerator RandomNumber)
        {
           
            deckStack = new Stack<PokerCard>(52); // can  set size
            
            deckInListForm = new List<PokerCard>(); //generate deck in list form
            //add 52 cards to the deck

            for (int index = 0; index < 52; index++)
            {

                //add 4 different suits of each card...... 52 / 4 = 13, so we gonna have 13 sets of 4 per suit
                deckInListForm.Add(new PokerCard
                {
                    suit = (Suit)(index / 13),//0 / 13
                                              //1 / 13
                                              //2 / 13
                                              //3 / 13
                                              //4  /13
                                              //5  /13
                                              //6 / 13
                                              //7  /13
                                              //8 / 13
                                              //9 / 13
                                              //10 / 13
                                              //11/ 13
                                              //12/ 13

                    //13 CARDS WITH SUIT 0 AKA CLUBS
                    //AND SO ON,

                    //Try/Attempt faces
                    //MODULUS 13, TO GET ALL FACES, BUT START AT 2 BECAUSE CARD VALUES START AT 2, THERE ARE NO 0 CARDS OR 1 CARDS
                    face = (Face)(index / 13 + 2)

                }
            );
            }

            while(deckInListForm.Count != 0) //shuffle
            {
                int randomIndexNumberGenerated = RandomNumber.Next(0, deckInListForm.Count()); // 0 to however many left

                deckStack.Push(deckInListForm[randomIndexNumberGenerated]); // give our stack the card at that random index
                deckInListForm.RemoveAt(randomIndexNumberGenerated); // then remove the card at the random index that we added to our stack, so we don't have to worry about duplicates


            }




        }
    }
}
