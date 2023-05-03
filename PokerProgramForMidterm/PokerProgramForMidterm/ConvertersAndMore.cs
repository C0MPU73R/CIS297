using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProgramForMidterm
{
 
        class ConvertersAndMore
        {
        public int[] amountOfEachCard;

        private cardAttributes[] TWO;
            private cardAttributes[] THREE;
            private cardAttributes[] FOUR;
            private cardAttributes[] FIVE;
            private cardAttributes[] SIX;
            private cardAttributes[] SEVEN;
            private cardAttributes[] EIGHT;
            private cardAttributes[] NINE;
            private cardAttributes[] TEN;
            private cardAttributes[] JACK;
            private cardAttributes[] QUEEN;
            private cardAttributes[] KING;
            private cardAttributes[] ACE;

            public void initializeAllCardAttributes()
            {
                TWO = new cardAttributes[4];
                THREE = new cardAttributes[4];
                FOUR = new cardAttributes[4];
                FIVE = new cardAttributes[4];
                SIX = new cardAttributes[4];
                SEVEN = new cardAttributes[4];
                EIGHT = new cardAttributes[4];
                NINE = new cardAttributes[4];
                TEN = new cardAttributes[4];
                JACK = new cardAttributes[4];
                QUEEN = new cardAttributes[4];
                KING = new cardAttributes[4];
                ACE = new cardAttributes[4];

            for (int index = 0; index < 4; index++)
            {
                //where 0 = clubs, 1 = diamonds, 2 = hearts, 3 = spades
                TWO[index].faceVal = 2;
                TWO[index].suitVal = index;
                THREE[index].faceVal = 3;
                THREE[index].suitVal = index;

                FOUR[index].faceVal = 4;
                FOUR[index].suitVal = index;

                FIVE[index].faceVal = 5;
                FIVE[index].suitVal = index;

                SIX[index].faceVal = 6;
                SIX[index].suitVal = index;

                SEVEN[index].faceVal = 7;
                SEVEN[index].suitVal = index;

                EIGHT[index].faceVal = 8;
                EIGHT[index].suitVal = index;

                NINE[index].faceVal = 9;
                NINE[index].suitVal = index;

                TEN[index].faceVal = 10;
                TEN[index].suitVal = index;

                JACK[index].faceVal = 11;
                JACK[index].suitVal = index;

                QUEEN[index].faceVal = 12;
                QUEEN[index].suitVal = index;

                KING[index].faceVal = 13;
                KING[index].suitVal = index;

                ACE[index].faceVal = 14;
                ACE[index].suitVal = index;

            }
        }



            
          
            public List<int> listToHoldFacesAsInts;
            public List<int> listToHoldSuitsAsInts;

            public List<int> convertCardListFacesToInts(List<Card> loc)
            {
                listToHoldFacesAsInts = new List<int>();
                for (int index = 0; index < loc.Count; index++)
                {
                    listToHoldFacesAsInts.Add((int)loc[index].face);
                }
                return listToHoldFacesAsInts;
            }

            public List<int> convertCardListSuitsToInts(List<Card> loc)
            {
                listToHoldSuitsAsInts = new List<int>();
                for (int index = 0; index < loc.Count; index++)
                {
                    listToHoldSuitsAsInts.Add((int)loc[index].suit);
                }
                return listToHoldSuitsAsInts;
            }



            public List<cardAttributes> convertListOfCardsToStructEquivalent(List<Card> loc)
            {
                cardAttributes converted;



                List<cardAttributes> cd;
                cd = new List<cardAttributes>();
                for (int index = 0; index < loc.Count; index++)
                {
                    converted = new cardAttributes();

                    converted.faceVal = (int)loc[index].face;
                    converted.suitVal = (int)loc[index].suit;
                    cd.Add(converted);

                }

                return cd;
            }




        public void readEachAmount(List<Card> loc)
        {
            amountOfEachCard = new int[13]; //card faces 2 - 14, 2-ace, so face 2 cards are in spot 0
            for (int i = 0; i < 14; i++)
            {
                amountOfEachCard[i] = 0;
            }

            for (int index = 0; index < loc.Count; index++)
            {
                if ((int)loc[index].face == 2) //if we get a two
                {
                    amountOfEachCard[0]++;
                }
                else if ((int)loc[index].face == 3)
                {
                    amountOfEachCard[1]++;

                }
                else if ((int)loc[index].face == 4)
                {
                    amountOfEachCard[2]++;

                }
                else if ((int)loc[index].face == 5)
                {
                    amountOfEachCard[3]++;

                }
                else if ((int)loc[index].face == 6)
                {
                    amountOfEachCard[4]++;

                }
                else if ((int)loc[index].face == 7)
                {
                    amountOfEachCard[5]++;

                }

                else if ((int)loc[index].face == 8)
                {
                    amountOfEachCard[6]++;

                }
                else if ((int)loc[index].face == 9)
                {
                    amountOfEachCard[7]++;

                }

                else if ((int)loc[index].face == 10)
                {
                    amountOfEachCard[8]++;

                }
                else if ((int)loc[index].face == 11)
                {
                    amountOfEachCard[9]++;

                }
                else if ((int)loc[index].face == 12)
                {
                    amountOfEachCard[10]++;

                }
                else if ((int)loc[index].face == 13)
                {
                    amountOfEachCard[11]++;

                }
                else if ((int)loc[index].face == 14)
                {
                    amountOfEachCard[12]++;

                }
            }
        }






        public bool checkForPair(List<Card> loc)
            {
                bool pair = false;
                for (int index = 1; index < loc.Count; index++)
                {
                    if (loc.ElementAt(0).face == loc.ElementAt(index).face)
                    {
                        pair = true;

                    }
                }
                return pair;
            }

            public bool checkFor2Pair(List<Card> loc)
            {
                bool haveTwoOfAKind = false;
                for (int index = 0; index < loc.Count; index++)
                {
                    if (amountOfEachCard[index] >= 2)
                    {
                        haveTwoOfAKind = true;
                    }
                }

                return haveTwoOfAKind;
            }

            public bool checkForThreeOfAKind(List<Card> loc)
            {
                bool haveTwoOfAKind = false;
                for (int index = 0; index < loc.Count; index++)
                {
                    if (amountOfEachCard[index] >= 2)
                    {
                        haveTwoOfAKind = true;
                    }
                }

                return haveTwoOfAKind;
            }

            public bool checkForFourOfAKind(List<Card> loc)
            {
                bool haveFourOfAKind = false;
                for (int index = 0; index < loc.Count; index++)
                {
                    if (amountOfEachCard[index] >= 4)
                    {
                        haveFourOfAKind = true;
                    }
                }

                return haveFourOfAKind;
            }

            public bool checkForHighCard(List<Card> loc)
            {
                //todo
                return false;
            }
            public bool checkForStraight(List<int> loi)
            {
                bool haveLargeStraight = false;
                if (loi.Contains(2) && loi.Contains(3) && loi.Contains(4) && loi.Contains(5) && loi.Contains(6))
                {
                    haveLargeStraight = true; //if have a 2,3,4,5,6
                }
                else if (loi.Contains(3) && loi.Contains(4) && loi.Contains(5) && loi.Contains(6) && loi.Contains(7))
                {
                    haveLargeStraight = true; //if have a 3,4,5,6,7

                }
                else if (loi.Contains(4) && loi.Contains(5) && loi.Contains(6) && loi.Contains(7) && loi.Contains(8))
                {
                    haveLargeStraight = true; //if have a 4,5,6,7,8

                }

                else if (loi.Contains(5) && loi.Contains(6) && loi.Contains(7) && loi.Contains(8) && loi.Contains(9))
                {
                    haveLargeStraight = true; //if have a 5,6,7,8,9

                }

                else if (loi.Contains(6) && loi.Contains(7) && loi.Contains(8) && loi.Contains(9) && loi.Contains(10))
                {
                    haveLargeStraight = true; //if have a 6,7,8,9,10

                }
                else if (loi.Contains(7) && loi.Contains(8) && loi.Contains(9) && loi.Contains(10) && loi.Contains(11))
                {
                    haveLargeStraight = true; //if have a 7,8,9,10,11

                }


                else if (loi.Contains(8) && loi.Contains(9) && loi.Contains(10) && loi.Contains(11) && loi.Contains(12))
                {
                    haveLargeStraight = true; //if have a 8,9,10,11,12

                }
                else if (loi.Contains(9) && loi.Contains(10) && loi.Contains(11) && loi.Contains(12) && loi.Contains(13))
                {
                    haveLargeStraight = true; //if have a 9,10,11,12,13

                }
                else if (loi.Contains(10) && loi.Contains(11) && loi.Contains(12) && loi.Contains(13) && loi.Contains(14))
                {
                    haveLargeStraight = true; //if have a 10,11,12,13,14

                }

                return haveLargeStraight;
            }

            public bool checkForFullHouse(List<Card> loc)
            {
                bool haveFullHouse1 = false;
                bool haveFullHouse2 = false;
                bool fullHouseTotal = false;
                for (int index = 0; index < loc.Count; index++)
                {
                    if (amountOfEachCard[index] == 2)
                    {
                        haveFullHouse1 = true;
                    }
                    if (amountOfEachCard[index] == 3)
                    {
                        haveFullHouse2 = true;
                    }
                }

                if (haveFullHouse1 == true && haveFullHouse2 == true)
                {
                    fullHouseTotal = true;
                }

                return fullHouseTotal;
            }

            public bool checkForStraightFlush(List<cardAttributes> loca)
            {
                //same as straight but all suits same
                bool haveStraightFlush = false;

                if (loca.Contains(TWO[0]) && loca.Contains(THREE[0]) && loca.Contains(FOUR[0]) && loca.Contains(FIVE[0]) && loca.Contains(SIX[0]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(TWO[1]) && loca.Contains(THREE[1]) && loca.Contains(FOUR[1]) && loca.Contains(FIVE[1]) && loca.Contains(SIX[1]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(TWO[2]) && loca.Contains(THREE[2]) && loca.Contains(FOUR[2]) && loca.Contains(FIVE[2]) && loca.Contains(SIX[2]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(TWO[3]) && loca.Contains(THREE[3]) && loca.Contains(FOUR[3]) && loca.Contains(FIVE[3]) && loca.Contains(SIX[3]))

                {
                    haveStraightFlush = true;
                }


                if (loca.Contains(THREE[0]) && loca.Contains(FOUR[0]) && loca.Contains(FIVE[0]) && loca.Contains(SIX[0]) && loca.Contains(SEVEN[0]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(THREE[1]) && loca.Contains(FOUR[1]) && loca.Contains(FIVE[1]) && loca.Contains(SIX[1]) && loca.Contains(SEVEN[1]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(THREE[2]) && loca.Contains(FOUR[2]) && loca.Contains(FIVE[2]) && loca.Contains(SIX[2]) && loca.Contains(SEVEN[2]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(THREE[3]) && loca.Contains(FOUR[3]) && loca.Contains(FIVE[3]) && loca.Contains(SIX[3]) && loca.Contains(SEVEN[3]))

                {
                    haveStraightFlush = true;
                }




                if (loca.Contains(FOUR[0]) && loca.Contains(FIVE[0]) && loca.Contains(SIX[0]) && loca.Contains(SEVEN[0]) && loca.Contains(EIGHT[0]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(FOUR[1]) && loca.Contains(FIVE[1]) && loca.Contains(SIX[1]) && loca.Contains(SEVEN[1]) && loca.Contains(EIGHT[1]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(FOUR[2]) && loca.Contains(FIVE[2]) && loca.Contains(SIX[2]) && loca.Contains(SEVEN[2]) && loca.Contains(EIGHT[2]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(FOUR[3]) && loca.Contains(FIVE[3]) && loca.Contains(SIX[3]) && loca.Contains(SEVEN[3]) && loca.Contains(EIGHT[3]))

                {
                    haveStraightFlush = true;
                }

                if (loca.Contains(FIVE[0]) && loca.Contains(SIX[0]) && loca.Contains(SEVEN[0]) && loca.Contains(EIGHT[0]) && loca.Contains(NINE[0]))

                {
                    haveStraightFlush = true;
                }

                else if (loca.Contains(FIVE[1]) && loca.Contains(SIX[1]) && loca.Contains(SEVEN[1]) && loca.Contains(EIGHT[1]) && loca.Contains(NINE[1]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(FIVE[2]) && loca.Contains(SIX[2]) && loca.Contains(SEVEN[2]) && loca.Contains(EIGHT[2]) && loca.Contains(NINE[2]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(FIVE[3]) && loca.Contains(SIX[3]) && loca.Contains(SEVEN[3]) && loca.Contains(EIGHT[3]) && loca.Contains(NINE[3]))

                {
                    haveStraightFlush = true;
                }


                if (loca.Contains(SIX[0]) && loca.Contains(SEVEN[0]) && loca.Contains(EIGHT[0]) && loca.Contains(NINE[0]) && loca.Contains(TEN[0]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(SIX[1]) && loca.Contains(SEVEN[1]) && loca.Contains(EIGHT[1]) && loca.Contains(NINE[1]) && loca.Contains(TEN[1]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(SIX[2]) && loca.Contains(SEVEN[2]) && loca.Contains(EIGHT[2]) && loca.Contains(NINE[2]) && loca.Contains(TEN[2]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(SIX[3]) && loca.Contains(SEVEN[3]) && loca.Contains(EIGHT[3]) && loca.Contains(NINE[3]) && loca.Contains(TEN[3]))

                {
                    haveStraightFlush = true;
                }


                if (loca.Contains(SEVEN[0]) && loca.Contains(EIGHT[0]) && loca.Contains(NINE[0]) && loca.Contains(TEN[0]) && loca.Contains(JACK[0]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(SEVEN[1]) && loca.Contains(EIGHT[1]) && loca.Contains(NINE[1]) && loca.Contains(TEN[1]) && loca.Contains(JACK[1]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(SEVEN[2]) && loca.Contains(EIGHT[2]) && loca.Contains(NINE[2]) && loca.Contains(TEN[2]) && loca.Contains(JACK[2]))

                {
                    haveStraightFlush = true; 
                }
                else if (loca.Contains(SEVEN[3]) && loca.Contains(EIGHT[3]) && loca.Contains(NINE[3]) && loca.Contains(TEN[3]) && loca.Contains(JACK[3]))

                {
                    haveStraightFlush = true; 
                }

                if (loca.Contains(EIGHT[0]) && loca.Contains(NINE[0]) && loca.Contains(TEN[0]) && loca.Contains(JACK[0]) && loca.Contains(QUEEN[0]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(EIGHT[1]) && loca.Contains(NINE[1]) && loca.Contains(TEN[1]) && loca.Contains(JACK[1]) && loca.Contains(QUEEN[1]))

                {
                    haveStraightFlush = true;
                }

                else if (loca.Contains(EIGHT[2]) && loca.Contains(NINE[2]) && loca.Contains(TEN[2]) && loca.Contains(JACK[2]) && loca.Contains(QUEEN[2]))

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(EIGHT[3]) && loca.Contains(NINE[3]) && loca.Contains(TEN[3]) && loca.Contains(JACK[3]) && loca.Contains(QUEEN[3]))

                {
                    haveStraightFlush = true;
                }


                if (loca.Contains(NINE[0]) && loca.Contains(TEN[0]) && loca.Contains(JACK[0]) && loca.Contains(QUEEN[0]) && loca.Contains(KING[0]))

                {
                    haveStraightFlush = true;
                }

                else if (loca.Contains(NINE[1]) && loca.Contains(TEN[1]) && loca.Contains(JACK[1]) && loca.Contains(QUEEN[1]) && loca.Contains(KING[1])) 

                {
                    haveStraightFlush = true;
                }
                else if (loca.Contains(NINE[2]) && loca.Contains(TEN[2]) && loca.Contains(JACK[2]) && loca.Contains(QUEEN[2]) && loca.Contains(KING[2])) 

                {
                    haveStraightFlush = true;
                }


                else if (loca.Contains(NINE[3]) && loca.Contains(TEN[3]) && loca.Contains(JACK[3]) && loca.Contains(QUEEN[3]) && loca.Contains(KING[3])) 
                {
                    haveStraightFlush = true;
                }

                return haveStraightFlush;
            }


            public bool checkForRoyalFlush(List<int> loi, List<cardAttributes> loca)

            {
                bool haveRoyalFlush = false;
                if (loi.Contains(10) && loi.Contains(11) && loi.Contains(12) && loi.Contains(13) && loi.Contains(14))
                {
                    if (loca.Contains(TEN[0]) && loca.Contains(JACK[0]) && loca.Contains(QUEEN[0]) && loca.Contains(KING[0]) && loca.Contains(ACE[0])) 

                    {
                        haveRoyalFlush = true; 
                    }

                    else if (loca.Contains(TEN[1]) && loca.Contains(JACK[1]) && loca.Contains(QUEEN[1]) && loca.Contains(KING[1]) && loca.Contains(ACE[1]))

                    {
                        haveRoyalFlush = true; 
                    }
                    else if (loca.Contains(TEN[2]) && loca.Contains(JACK[2]) && loca.Contains(QUEEN[2]) && loca.Contains(KING[2]) && loca.Contains(ACE[2]))

                    {
                        haveRoyalFlush = true; 
                    }

                    else if (loca.Contains(TEN[3]) && loca.Contains(JACK[3]) && loca.Contains(QUEEN[3]) && loca.Contains(KING[3]) && loca.Contains(ACE[3]))

                    {
                        haveRoyalFlush = true; 
                    }

                }

                return haveRoyalFlush;

            }

            public bool checkForFlush(List<Card> loc)
            {
                //normal flush
                //have 5 five cards same suit
                int flushCount = 0;
                bool haveFlush = false;
                for (int index = 1; index < loc.Count; index++)
                {
                    if (loc[0].suit == loc[index].suit)
                    {
                        flushCount++;
                    }


                }
                if (flushCount >= 5)
                {
                    haveFlush = true;
                }

                return haveFlush;
            }


        }
    }


