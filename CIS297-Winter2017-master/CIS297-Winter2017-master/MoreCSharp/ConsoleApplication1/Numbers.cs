using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	public class Numbers
	{
		public delegate int NumberGenerator();

		private Random random;
		public NumberGenerator generator;
		public Numbers()
		{
			random = new Random();
			generator = getNumber;
		}

		private int getNumber()
		{
			return random.Next( 1, 100 );
		}

		public int getRandomNumber()
		{
			if ( generator != null )
			{
				return generator();
			}
			else
			{
				return 0;
			}
		}
	}
}
