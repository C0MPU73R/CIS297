using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	public class Primes
	{
		private Random random;
		public int CurrentNumber;

		public event EventHandler PrimeFound;

		public Primes()
		{
			random = new Random();
		}

		public void nextNumber()
		{
			CurrentNumber = random.Next( 1, 1000 );
			if ( IsPrime(CurrentNumber) )
			{
				PrimeFound?.Invoke( this, EventArgs.Empty );
			}
		}

		public static bool IsPrime( int number )
		{
			if ( number <= 1)
			{
				return false;
			}
			for ( int divisor = 2; divisor <= Math.Sqrt(number); divisor++ )
			{
				if( number % divisor == 0)
				{
					return false;
				}
			}
			return true;
		}


	}
}
