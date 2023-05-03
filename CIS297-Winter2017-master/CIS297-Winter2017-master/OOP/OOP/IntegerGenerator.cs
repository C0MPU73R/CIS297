using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class IntegerGenerator : NumberGenerator
	{
		private int _currentNumber;
		public IntegerGenerator(string name, int startingNumber )
		{
			Name = name;
			_currentNumber = startingNumber;
		}
		public override double GetNumber()
		{
			NumberOfNumbersGenerated++;
			return _currentNumber++;
		}
	}
}
