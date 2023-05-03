using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
	public class RandomNumberGenerator : INumberGenerator
	{
		private Random random;

		public RandomNumberGenerator()
		{
			random = new Random();
		}

		public int Next( int minValue, int maxValue )
		{
			return random.Next( minValue, maxValue );
		}
	}
}
