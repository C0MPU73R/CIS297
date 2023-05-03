using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestEmployeeConstructorDefaultName()
		{
			Employee testEmployee = new Employee( "", 100000 );
			Assert.AreEqual( "Not Assigned", testEmployee.Name );
			Assert.AreEqual( 100000, testEmployee.AnnualSalary );
		}

		[TestMethod]
		public void TestEmployeeConstructor()
		{
			Employee testEmployee = new Employee( "Eric", 100000 );
			Assert.AreEqual( "Eric", testEmployee.Name );
			Assert.AreEqual( 100000, testEmployee.AnnualSalary );
		}

		[TestMethod]
		public void TestFibGenerator()
		{
			FibGenerator fibGenerator = new FibGenerator( "Fib Generator" );
			Assert.AreEqual( 1, fibGenerator.GetNumber() );
			Assert.AreEqual( 1, fibGenerator.GetNumber() );
			Assert.AreEqual( 2, fibGenerator.GetNumber() );
			Assert.AreEqual( 3, fibGenerator.GetNumber() );
			Assert.AreEqual( 5, fibGenerator.GetNumber() );
			Assert.AreEqual( 8, fibGenerator.GetNumber() );
			Assert.AreEqual( 13, fibGenerator.GetNumber() );
		}

		[TestMethod]
		public void TestYahtzeeRollingYahtzee()
		{
			TestingNumberGenerator random = new TestingNumberGenerator(
				new List<int>
				{
					1,1,1,1,1
				} );
			Yahtzee testYahtzee = new Yahtzee( random );
			testYahtzee.roll();
			Assert.IsTrue( testYahtzee.checkForYahtzee() );
		}
		[TestMethod]
		public void TestYahtzeeRollingNotAYahtzee()
		{
			TestingNumberGenerator random = new TestingNumberGenerator(
				new List<int>
				{
					1,2,3,4,5
				} );
			Yahtzee testYahtzee = new Yahtzee( random );
			testYahtzee.roll();
			Assert.IsFalse( testYahtzee.checkForYahtzee() );
		}

		[TestMethod]
		public void TestYahtzeeRollingLargeStraight()
		{
			TestingNumberGenerator random = new TestingNumberGenerator(
				new List<int>
				{
					1,2,3,4,5
				} );
			Yahtzee testYahtzee = new Yahtzee( random );
			testYahtzee.roll();
			Assert.IsTrue( testYahtzee.checkForLargeStraight() );
		}
	}
}
