using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class ExponentialGenerator : NumberGenerator
	{
		private double _currentNumber;
		private int _startingNumber;

		public ExponentialGenerator( string name, int startingNumber )
		{
			Name = name;
			_currentNumber = startingNumber;
			_startingNumber = startingNumber;
		}
		public override double GetNumber()
		{
			NumberOfNumbersGenerated++;
			double returnValue = _currentNumber;
			_currentNumber = Math.Pow( _currentNumber, _startingNumber );
			return _currentNumber;
		}
	}
}
