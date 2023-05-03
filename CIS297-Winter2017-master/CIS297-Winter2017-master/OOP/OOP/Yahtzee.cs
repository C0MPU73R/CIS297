using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Yahtzee
	{
		public int onesScore { get; set; }
		public int twosScore { get; set; }

		private List<int> dice;

		private INumberGenerator random;
		private static readonly int NUMBER_OF_DICE = 5;

		public Yahtzee(INumberGenerator numberGenerator)
		{
			dice = new List<int>();
			random = numberGenerator;
		}

		public void roll()
		{
			dice.Clear();
			for ( int index = 0; index < NUMBER_OF_DICE; index++ )
			{
				dice.Add(random.Next( 1, 7 ));
			}
		}

		public bool checkForYahtzee()
		{
			return dice[ 0 ] == dice[ 1 ] && dice[ 1 ] == dice[ 2 ];
		}

		public bool checkForLargeStraight()
		{
			return dice.Contains( 1 ) && dice.Contains( 2 ) && dice.Contains( 3 ) 
				&& dice.Contains( 4 ) && dice.Contains( 5 );
		}
	}
}
