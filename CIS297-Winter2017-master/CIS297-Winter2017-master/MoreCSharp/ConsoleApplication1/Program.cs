using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	public class Program
	{
		private static Primes primes;
		static void Main( string[] args )
		{
			primes = new Primes();
			primes.PrimeFound += HandlePrime;
			primes.PrimeFound += CreateBiggerNumber;
			for ( int times = 0; times < 1000; times++ )
			{
				primes.nextNumber();
			}

			Console.ReadKey();
		}

		static void CreateBiggerNumber(object sender, EventArgs args)
		{
			StreamWriter writer = File.AppendText("Primes.txt");
			writer.Write( primes.CurrentNumber * primes.CurrentNumber - 1 );
			writer.Write( Environment.NewLine );
			writer.Close();
		}

		static void HandlePrime( object sender, EventArgs args )
		{
			Console.WriteLine( primes.CurrentNumber );
		}

		public static void generateNumbersAndChangeDelegate()
		{
			Numbers numbers = new Numbers();
			for ( int times = 0; times < 100; times++ )
			{
				Console.WriteLine( numbers.getRandomNumber() );
			}

			numbers.generator = getFixedNumber;

			for ( int times = 0; times < 100; times++ )
			{
				Console.WriteLine( numbers.getRandomNumber() );
			}
		}

		static int getFixedNumber()
		{
			return 42;
		}
	}
}
