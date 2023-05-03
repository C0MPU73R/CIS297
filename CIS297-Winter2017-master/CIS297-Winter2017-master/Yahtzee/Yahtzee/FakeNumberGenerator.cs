using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
	public class FakeNumberGenerator : INumberGenerator
	{
		private List<int> _valuesToGenerate;
		private int numberOfNumbersGenerated;

		public FakeNumberGenerator( List<int> valuesToGenerate )
		{
			_valuesToGenerate = valuesToGenerate;
			numberOfNumbersGenerated = 0;
		}
		public int Next( int minValue, int maxValue )
		{
			return _valuesToGenerate[ numberOfNumbersGenerated++ % _valuesToGenerate.Count ];
		}
	}
}
