using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPokerGamev2
{
    class PokerCard : IComparable<PokerCard>
    {
        public enum Suit { Clubs, Diamonds, Hearts, Spades};
        public enum Face {Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace};

        public Suit suit { get; set; }
        public Face face { get; set; }
        public PokerCard()
        {
            //not sure if needed
        }

        public int CompareTo(PokerCard other)
        {

            // if this value is greater than the other value, return something to let us know such as 1
            //if vice versa, return something like -1
            //if they happen to be equal values, return 0
            //this is based soley on the face of the cards, we are comparing the actual numerical values, such as a Two vs a Three, well a three is going to have a greater value
            //due to the face that we are only looking at value comparisons

            //EDIT: My mistake, ignore most of the comments above, the system's compare to method acutally does all the for us, according to one of microsoft's pages,
            //explcitly https://msdn.microsoft.com/en-us/library/43hc6wht(v=vs.110).aspx , but my assumption was still partially correct, greater than will return 1, less than will retunrn -1,
            //could not find something for straight up equal to, will update this later.
            //TIMESTAMP : 03/17/17 : 5 : 20 : 10 PM
            return face.CompareTo(other.face);



        }
    }
}
