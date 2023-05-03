using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public abstract class NumberGenerator
	{
		public NumberGenerator()
		{
			NumberOfNumbersGenerated = 0;
		}
		public abstract double GetNumber();
		public string Name { get; set; }
		public int NumberOfNumbersGenerated { get; set; }
	}
}
