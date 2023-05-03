using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
	class Program
	{
		static void Main( string[] args )
		{
			Food burger = new Food( "Hambuger", 390 );
			Food fries = new Food( "Large Fries", 480 );
			CalorieFreeToppings mustard = new CalorieFreeToppings( "Mustard" );

			Console.WriteLine( burger );
			Console.WriteLine( fries );

			Food combo = burger + fries;

			Console.WriteLine( burger );
			Console.WriteLine( fries );
			Console.WriteLine( combo );


			Console.WriteLine( burger == fries );
			Console.WriteLine( burger == combo );

			Food biggerBurger = new Food( "Hambuger", 870 );
			Console.WriteLine( burger == biggerBurger );

			Console.WriteLine( burger.GetType() == typeof( Food ) );
			Console.WriteLine( burger.GetType().Name == nameof( Food) );

			Console.WriteLine( burger.Equals(mustard ));

			Console.WriteLine( burger.Equals( null ) );
			Console.ReadKey();
		}
	}
}
