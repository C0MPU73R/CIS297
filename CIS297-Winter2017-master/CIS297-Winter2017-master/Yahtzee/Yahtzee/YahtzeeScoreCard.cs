using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
	public class YahtzeeScoreCard
	{
		public static int FULL_HOUSE_SCORE = 25;
		public static int SMALL_STRAIGHT_SCORE = 30;
		public static int LARGE_STRAIGHT_SCORE = 40;
		public static int YAHTZEE_SCORE = 50;
		public static int UPPER_BONUS = 35;

		public int Ones { get; set; } = 0;
		public int Twos { get; set; } = 0;
		public int Threes { get; set; } = 0;
		public int Fours { get; set; } = 0;
		public int Fives { get; set; } = 0;
		public int Sixes { get; set; } = 0;
		public int Bonus => Ones + Twos + Threes + Fours + Fives + Sixes >= 63 ? UPPER_BONUS : 0;
		public int ThreeOfAKind { get; set; } = 0;
		public int FourOfAKind { get; set; } = 0;
		public int FullHouse { get; set; } = 0;
		public int SmallStraight { get; set; } = 0;
		public int LargeStraight { get; set; } = 0;
		public int Yahtzee { get; set; } = 0;
		public int Chance { get; set; } = 0;
		public int UpperTotal => Ones + Twos + Threes + Fours + Fives + Sixes + Bonus;
		public int LowerTotal => ThreeOfAKind + FourOfAKind + FullHouse + SmallStraight + LargeStraight + Yahtzee + Chance;
		public int GrandTotal => UpperTotal + LowerTotal;
	}
}
