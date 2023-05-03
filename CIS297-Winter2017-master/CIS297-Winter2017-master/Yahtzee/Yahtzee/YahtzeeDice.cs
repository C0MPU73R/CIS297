using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
	public class YahtzeeDice
	{
		private List<int> dice;
		private readonly INumberGenerator _numberGenerator;

		public delegate void ChangeHandler( YahtzeeDice dice );
		public event ChangeHandler Changed;

		public int RollCount { get; private set; }
		public bool RollDie1 { get; set; } = true;
		public bool RollDie2 { get; set; } = true;
		public bool RollDie3 { get; set; } = true;
		public bool RollDie4 { get; set; } = true;
		public bool RollDie5 { get; set; } = true;

		public YahtzeeDice(INumberGenerator numberGenerator )
		{
			_numberGenerator = numberGenerator;
			dice = new List<int> { 0, 0, 0, 0, 0 };
			RollCount = 0;
		}

		public int this[int i] => dice[ i ];

		public void roll()
		{
			RollCount++;
			if ( RollCount <= 3 )
			{
				bool[] shouldRoll = new bool[] { RollDie1, RollDie2, RollDie3, RollDie4, RollDie5 };
				for ( int index = 0; index < dice.Count; index++ )
				{
					if ( shouldRoll[ index ] )
					{
						dice[ index ] = _numberGenerator.Next( 1, 7 );
					}
				}
			}
			Changed?.Invoke( this );
		}

		private int SumOfDice => dice[ 0 ] + dice[ 1 ] + dice[ 2 ] + dice[ 3 ] + dice[ 4 ];

		public YahtzeeScoreCard getPossibleScores()
		{
			YahtzeeScoreCard scores = new YahtzeeScoreCard();

			int[] upperScores = new int[6];
			List<int> numberOfTimesEachDieWasRolled = new List<int> { 0, 0, 0, 0, 0, 0 };

			foreach ( int die in dice )
			{
				upperScores[ die-1 ] += die;
				numberOfTimesEachDieWasRolled[ die - 1 ]++;
			}

			scores.Ones = upperScores[ 0 ];
			scores.Twos = upperScores[ 1 ];
			scores.Threes = upperScores[ 2 ];
			scores.Fours = upperScores[ 3 ];
			scores.Fives = upperScores[ 4 ];
			scores.Sixes = upperScores[ 5 ];

			if ( numberOfTimesEachDieWasRolled.Contains(3) )
			{
				scores.ThreeOfAKind = SumOfDice;
			}

			if( numberOfTimesEachDieWasRolled.Contains(4) )
			{
				scores.FourOfAKind = SumOfDice;
				scores.ThreeOfAKind = SumOfDice;
			}

			if ( numberOfTimesEachDieWasRolled.Contains(2) && numberOfTimesEachDieWasRolled.Contains(3) )
			{
				scores.FullHouse = YahtzeeScoreCard.FULL_HOUSE_SCORE;
			}

			if ( ( dice.Contains(1) && dice.Contains(2) && dice.Contains(3) && dice.Contains(4) )
				|| ( dice.Contains( 2 ) && dice.Contains( 3 ) && dice.Contains( 4 ) && dice.Contains( 5 ) )
				|| ( dice.Contains( 3 ) && dice.Contains(4 ) && dice.Contains( 5) && dice.Contains( 6 ) ) )
			{
				scores.SmallStraight = YahtzeeScoreCard.SMALL_STRAIGHT_SCORE;
			}

			if ( ( dice.Contains( 1 ) && dice.Contains( 2 ) && dice.Contains( 3 ) && dice.Contains( 4 ) && dice.Contains( 5 ) )
				|| ( dice.Contains( 2 ) && dice.Contains( 3 ) && dice.Contains( 4 ) && dice.Contains( 5 ) && dice.Contains( 6 ) ) )
			{
				scores.LargeStraight = YahtzeeScoreCard.LARGE_STRAIGHT_SCORE;
			}

			if( numberOfTimesEachDieWasRolled.Contains(5) )
			{
				scores.Yahtzee = YahtzeeScoreCard.YAHTZEE_SCORE;
				scores.FourOfAKind = SumOfDice;
				scores.ThreeOfAKind = SumOfDice;
			}

			scores.Chance = SumOfDice;

			return scores;
		}
	}
}
