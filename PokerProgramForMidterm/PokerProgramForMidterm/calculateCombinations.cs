using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProgramForMidterm
{

    class calculateCombinations
    {
        List<Card> RemainingCards;
        List<Card> HoleCards;
        private List<Card> comboOfHoleCards;
        List<List<Card>> ProspectiveCombo;
        private List<Card> ALL7;
        private List<List<Card>> ListOfListsForA7;
        public int[] amountOfEachCard;
        public List<int> listToHoldFacesAsInts;
        public List<int> listToHoldSuitsAsInts;

        public calculateCombinations(List<Card> communityCards, HoleHand hhand) //pass in community cards and their hold cards, whether it be the ai's or users
        {//community cards and someone's hole hand is all we need to perform the calculation

            RemainingCards = new List<Card>(); //...has not been filled yet for some reason? Should intially contain ALL 52 cards, then take out ones not needed....


            for (int index = 0; index < 5; index++)
            {
                RemainingCards.Remove(communityCards[index]); // - 5
            }


            for (int index = 0; index < 2; index++)
            {
                HoleCards.Add(hhand.Cards[index]);
                RemainingCards.Remove(hhand.Cards[index]); // - 2

            }


            //should have the 45 cards
            for (int index = 0; index < 44; index++)
            {

                for (int index2 = index + 1; index2 < 45; index++)
                {
                    comboOfHoleCards = new List<Card>();

                    comboOfHoleCards.Add(RemainingCards[index]);
                    comboOfHoleCards.Add(RemainingCards[index2]);
                    ProspectiveCombo.Add(comboOfHoleCards); //list of lists which have 2 items

                }
            }

            //now with each prospective combo of 2 hole cards they might have
            //from the deck, need to do every combination they can have
            //with the community cards and then find which is the best


            for (int index = 0; index < ProspectiveCombo.Count; index++)
            {
                ALL7 = new List<Card>();
                for (int index2 = 0; index2 < communityCards.Count; index2++)
                {
                    ALL7.Add(communityCards[index2]); //get all 5 community cards in list

                }
                for (int j = 0; j < 2; j++)
                {
                    ALL7.Add(ProspectiveCombo[index][j]);
                }
                ListOfListsForA7.Add(ALL7);
                //still should be a list of 45 lists but each list has the community cards and hole hand

            }

            ConvertersAndMore c;
            c = new ConvertersAndMore();

            List<List<int>> converted;
            converted = new List<List<int>>(); //converts
            for (int i = 0; i < ListOfListsForA7.Count; i++)
            {

                converted.Add(c.convertCardListFacesToInts(ListOfListsForA7[i]));

            }

            List<List<cardAttributes>> listOfListsOfcardAtts;
            listOfListsOfcardAtts = new List<List<cardAttributes>>();
            for (int a = 0; a < ListOfListsForA7.Count; a++)
            {
                listOfListsOfcardAtts.Add(c.convertListOfCardsToStructEquivalent(ListOfListsForA7[a]));
            }



            List<bool> pair = new List<bool>();
            List<bool> twoPair = new List<bool>();
            List<bool> threeOfAKind = new List<bool>();
            List<bool> fourOfAKind = new List<bool>();
            List<bool> fullHouse = new List<bool>();
            List<bool> flush = new List<bool>();
            List<bool> straight = new List<bool>();
            List<bool> straightFlush = new List<bool>();
            List<bool> royalFlush = new List<bool>();
            //implement
            for (int x = 0; x < ListOfListsForA7.Count; x++)
            {
                pair[x] = c.checkForPair(ListOfListsForA7[x]);
                twoPair[x] = c.checkFor2Pair(ListOfListsForA7[x]);
                threeOfAKind[x] = c.checkForThreeOfAKind(ListOfListsForA7[x]);
                fourOfAKind[x] = c.checkForFourOfAKind(ListOfListsForA7[x]);
                fullHouse[x] = c.checkForFullHouse(ListOfListsForA7[x]);
                flush[x] = c.checkForFlush(ListOfListsForA7[x]);
                straight[x] = c.checkForStraight(converted[x]);
                straightFlush[x] = c.checkForStraightFlush(listOfListsOfcardAtts[x]);
                royalFlush[x] = c.checkForRoyalFlush(converted[x], listOfListsOfcardAtts[x]);
            }
        }

    }



}


