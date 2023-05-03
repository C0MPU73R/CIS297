using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestRollTakes5NumbersFromGenerator()
		{
			List<int> values = new List<int> { 1, 1, 1, 2, 2 };
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( values );
			YahtzeeDice dice = new YahtzeeDice( numberGenerator );
			dice.roll();
			
			for ( int index = 0; index < values.Count; index++ )
			{
				Assert.AreEqual( values[ index ], dice[ index ] );
			}
		}

		[TestMethod]
		public void TestYahtzee()
		{
			List<int> values = new List<int> { 1, 1, 1, 1, 1 };
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( values );
			YahtzeeDice dice = new YahtzeeDice( numberGenerator );
			dice.roll();

			YahtzeeScoreCard scores = dice.getPossibleScores();

			Assert.AreEqual( YahtzeeScoreCard.YAHTZEE_SCORE, scores.Yahtzee );
		}

		[TestMethod]
		public void TestFullHouse()
		{
			List<int> values = new List<int> { 1, 1, 1, 2, 2 };
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( values );
			YahtzeeDice dice = new YahtzeeDice( numberGenerator );
			dice.roll();

			YahtzeeScoreCard scores = dice.getPossibleScores();

			Assert.AreEqual( YahtzeeScoreCard.FULL_HOUSE_SCORE, scores.FullHouse );
		}

		[TestMethod]
		public void TestFourOfAKind()
		{
			List<int> values = new List<int> { 1, 1, 1, 1, 2 };
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( values );
			YahtzeeDice dice = new YahtzeeDice( numberGenerator );
			dice.roll();

			YahtzeeScoreCard scores = dice.getPossibleScores();

			Assert.AreEqual( 6, scores.FourOfAKind );
		}

		[TestMethod]
		public void TestThreeOfAKind()
		{
			List<int> values = new List<int> { 1, 1, 1, 2, 3 };
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( values );
			YahtzeeDice dice = new YahtzeeDice( numberGenerator );
			dice.roll();

			YahtzeeScoreCard scores = dice.getPossibleScores();

			Assert.AreEqual( 8, scores.ThreeOfAKind );
		}

		[TestMethod]
		public void TestSmallStraight()
		{
			List<int> values = new List<int> { 1, 2, 3, 4, 1 };
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( values );
			YahtzeeDice dice = new YahtzeeDice( numberGenerator );
			dice.roll();

			YahtzeeScoreCard scores = dice.getPossibleScores();

			Assert.AreEqual( YahtzeeScoreCard.SMALL_STRAIGHT_SCORE, scores.SmallStraight );
		}

		[TestMethod]
		public void TestLargeStraight()
		{
			List<int> values = new List<int> { 1, 2, 3, 4, 5 };
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( values );
			YahtzeeDice dice = new YahtzeeDice( numberGenerator );
			dice.roll();

			YahtzeeScoreCard scores = dice.getPossibleScores();

			Assert.AreEqual( YahtzeeScoreCard.LARGE_STRAIGHT_SCORE, scores.LargeStraight );
		}
	}
}
