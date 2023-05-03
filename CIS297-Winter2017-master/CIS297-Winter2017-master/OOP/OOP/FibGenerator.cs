using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class FibGenerator : NumberGenerator
	{
		private double _nth = 1;
		private double _nthMinusOne = 1;
		private double _nthMinusTwo = 1;

		public FibGenerator(string name)
		{
			Name = name;
		}

		public override double GetNumber()
		{
			NumberOfNumbersGenerated++;
			if ( NumberOfNumbersGenerated == 1 || NumberOfNumbersGenerated  == 2 )
			{
				return 1;
			}
			_nth = _nthMinusOne + _nthMinusTwo;
			_nthMinusTwo = _nthMinusOne;
			_nthMinusOne = _nth;

			return _nth;
		}
	}
}
