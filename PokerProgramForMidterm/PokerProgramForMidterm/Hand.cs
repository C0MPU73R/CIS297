using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PokerProgramForMidterm.Card;

namespace PokerProgramForMidterm
{
    public class Hand : IComparable<Hand>//used with permission from Eric Charnesky
    {
        public enum HandRank { HighCard = 0, Pair = 1, TwoPair = 2, ThreeOfAKind = 3, Straight = 4, Flush = 5, FullHouse = 6, FourOfAKind = 7, StraightFlush = 8 };
        public List<Card> Cards { get; set; }

        public Hand()
        {
            Cards = new List<Card>(); //new list of type card, for cards.......
        }




        public Hand(Deck deck) //creates your hand and takes five cards (as long as there are cards left)
        {
            Cards = new List<Card>();
            for (int cardNumber = 1; cardNumber <= 5; cardNumber++)
            {
                Cards.Add(deck.PickCard());
            }
        }
        
        

        private List<int> GetFaceCounts()
        {
            List<int> faceCount = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (Card card in Cards)
            {
                faceCount[(int)card.face]++;
            }

            return faceCount;
        }

        public int CompareTo(Hand other)
        {
            if (GetHandRank() > other.GetHandRank())
            {
                return 1;
            }
            else if (GetHandRank() < other.GetHandRank())
            {
                return -1;
            }
            else
            {
                switch (GetHandRank())
                {
                    case HandRank.StraightFlush:
                    case HandRank.Flush:
                    case HandRank.Straight:
                    case HandRank.HighCard:
                        {
                            return compareHighestCards(Cards, other.Cards);
                        }
                    case HandRank.FourOfAKind:
                        {
                            return CheckForHighestCardByFaceCount(other, 4);
                        }
                    case HandRank.ThreeOfAKind:
                    case HandRank.FullHouse:
                        {
                            return CheckForHighestCardByFaceCount(other, 3);
                        }
                    case HandRank.TwoPair:
                    case HandRank.Pair:
                        {
                            return CheckForHighestCardByFaceCount(other, 2);
                        }
                    default:
                        return compareHighestCards(Cards, other.Cards);
                }
            }
        }

        private int CheckForHighestCardByFaceCount(Hand other, int faceCount)
        {
            List<int> myFaceCount = GetFaceCounts();
            List<int> theirFaceCount = other.GetFaceCounts();

            for (int index = myFaceCount.Count - 1; index >= 0; index--)
            {
                if ((myFaceCount[index] == faceCount || theirFaceCount[index] == faceCount) && myFaceCount[index] != theirFaceCount[index])
                {
                    return myFaceCount[index].CompareTo(theirFaceCount[index]);
                }
            }
            return compareHighestCards(Cards, other.Cards);
        }

        public HandRank GetHandRank()
        {
            if (HasStraightFlush())
            {
                return HandRank.StraightFlush;
            }
            if (HasFourOfAKind())
            {
                return HandRank.FourOfAKind;
            }
            if (HasFullHouse())
            {
                return HandRank.FullHouse;
            }
            if (HasFlush())
            {
                return HandRank.Flush;
            }
            if (HasStraight())
            {
                return HandRank.Straight;
            }
            if (HasThreeOfAKind())
            {
                return HandRank.ThreeOfAKind;
            }
            if (HasTwoPair())
            {
                return HandRank.TwoPair;
            }
            if (HasPair())
            {
                return HandRank.Pair;
            }
            return HandRank.HighCard;
        }

        public bool HasPair()
        {
            List<int> faceCount = GetFaceCounts();
            bool hasPair = false;
            for (int index = 0; index < faceCount.Count; index++)
            {
                if (faceCount[index] == 2)
                {
                    hasPair = true;
                }
            }
            return hasPair;
        }

        public bool HasTwoPair()
        {
            List<int> faceCount = GetFaceCounts();
            int pairCount = 0;
            for (int index = 0; index < faceCount.Count; index++)
            {
                if (faceCount[index] == 2)
                {
                    pairCount++;
                }
            }
            return pairCount == 2;
        }

        public bool HasThreeOfAKind()
        {
            List<int> faceCount = GetFaceCounts();
            bool hasThreeOfAKind = false;
            for (int index = 0; index < faceCount.Count; index++)
            {
                if (faceCount[index] == 3)
                {
                    hasThreeOfAKind = true;
                }
            }
            return hasThreeOfAKind;
        }

        public bool HasFourOfAKind()
        {
            List<int> faceCount = GetFaceCounts();
            bool hasFourOfAKind = false;
            for (int index = 0; index < faceCount.Count; index++)
            {
                if (faceCount[index] == 4)
                {
                    hasFourOfAKind = true;
                }
            }
            return hasFourOfAKind;
        }

        public bool HasFullHouse() => HasThreeOfAKind() && HasPair();

        public bool HasFlush()
        {
            Suit flushSuit = Cards[0].suit;
            for (int index = 1; index < Cards.Count; index++)
            {
                if (flushSuit != Cards[index].suit)
                {
                    return false;
                }
            }
            return true;
        }
        public bool HasStraight()
        {
            Cards.Sort();
            Cards.Reverse();
            for (int index = 0; index < Cards.Count - 1; index++)
            {
                if (!(Cards[index].face - 1 == Cards[index + 1].face))
                {
                    return false;
                }
            }
            return true;
        }

        public bool HasStraightFlush() => HasStraight() && HasFlush();

        public int compareHighestCards(List<Card> mine, List<Card> theirs)
        {
            mine.Sort();
            theirs.Sort();
            mine.Reverse();
            theirs.Reverse();

            for (int index = 0; index < mine.Count; index++)
            {
                if (!(mine[index].face == theirs[index].face))
                {
                    return mine[index].CompareTo(theirs[index]);
                }
            }

            return 0;
        }
    }
}
