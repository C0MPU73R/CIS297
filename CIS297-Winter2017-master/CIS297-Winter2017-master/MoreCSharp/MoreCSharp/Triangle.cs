using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharp
{
	public class Triangle
	{
		private int side1;
		private int side2;
		private double hypotenuse;



		public Triangle()
		{
			side1 = 0;
			side2 = 0;
			hypotenuse = 0;
		}

		public double SumOfSides => side1 + side2 + hypotenuse;

		public double this[int index]
		{
			get
			{
				if ( index == 0 )
				{
					return side1;
				}
				else if ( index == 1 )
				{
					return side2;
				}
				else if ( index == 2 )
				{
					return hypotenuse;
				}
				else
				{
					throw new IndexOutOfRangeException();
				}
			}
		}

		public void setSides( int one, int two, double three)
		{
			side1 = one;
			side2 = two;

			if ( !(Math.Sqrt(one * one + two * two) == three ) )
			{
				throw new InvalidOperationException( "The hypotenuse must each sqrt(side1^2 + side2^2)" );
			}

			hypotenuse = three;
		}

		public static Triangle operator+(Triangle t1, Triangle t2)
		{
			Triangle newTriangle = new Triangle();
			int newSide1 = t1.side1 + t2.side1;
			int newSide2 = t1.side2 + t2.side2;
			newTriangle.setSides( newSide1, newSide2, Math.Sqrt(newSide1 * newSide1 + newSide2 * newSide2 ));
			return newTriangle;
		}
	}
}
