using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class RandomWrapper : INumberGenerator
	{
		private Random random;

		public RandomWrapper()
		{
			random = new Random();
		}

		public int Next( int minValue, int maxValue )
		{
			return random.Next( minValue, maxValue );
		}
	}
}
