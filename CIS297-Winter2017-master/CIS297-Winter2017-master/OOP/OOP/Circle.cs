using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Circle : IWriter
	{
		public double Radius { get; private set; }
		public Circle( double radius )
		{
			Radius = radius;
		}
		public void Write( )
		{
			Console.WriteLine($"Circumference is : {Math.PI * Radius * 2}");
		}
	}
}
