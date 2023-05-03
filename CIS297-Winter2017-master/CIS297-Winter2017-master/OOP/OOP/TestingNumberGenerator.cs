using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class TestingNumberGenerator : INumberGenerator
	{
		private List<int> _valuesToGenerate;
		private int numberOfNumbersGenerated;

		public TestingNumberGenerator(List<int> valuesToGenerate)
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
