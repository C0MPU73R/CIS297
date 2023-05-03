using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Program
	{
		static void Main( string[] args )
		{







            Generators();
		//	RandomWrapper random = new RandomWrapper();
		//	Yahtzee myGame = new Yahtzee( random );

		Console.ReadKey();
		}

		static void Writer()
		{
			Employee dan = new Employee( "Dan V.", 100000.0 );
			Circle smallCirlce = new Circle( 5 );

			IWriter[] writers = new IWriter[ 2 ];
			writers[ 0 ] = dan;
			writers[ 1 ] = smallCirlce;

			for ( int index = 0; index < writers.Length; index++ )
			{
				writers[ index ].Write();
			}
		}

		static void Generators()
		{
			//IntegerGenerator intGenerator = new IntegerGenerator( "Whole Numbers", 100 );
			//for ( int count = 0; count < 100; count++ )
			//{
				//Console.WriteLine( intGenerator.GetNumber() );
			//}

			ExponentialGenerator expGenerator = new ExponentialGenerator( "Exponential Numbers", 2 );
			for ( int count = 0; count < 100; count++ )
			{
				Console.WriteLine( expGenerator.GetNumber() );
			}

			//FibGenerator fibGenerator = new FibGenerator( "Fibbonocci Numbers" );
			//for ( int count = 0; count < 100; count++ )
			//{
			//	Console.WriteLine( fibGenerator.GetNumber() );
			//}
		}

		static void PrintEmployees()
		{
			Employee dan = new Employee( "Dan V.", 100000.0 );
			PrintEmployee( dan );
			Employee eddie = new Employee( "Eddie U.", 1000000 );
			PrintEmployee( eddie );
			Employee eric = new Employee( "", 50000 );
			PrintEmployee( eric );

			Manager afeefeh = new Manager( "Afeefeh", Double.MaxValue );
			afeefeh.AddEmployeeToManage( dan );
			afeefeh.AddEmployeeToManage( eddie );
			afeefeh.AddEmployeeToManage( eric );

			PrintEmployee( afeefeh );
		}

		static void PrintObjectTypes()
		{
			object[] items = new object[ 3 ];
			items[ 0 ] = new Employee("Dan", 1000000);
			items[ 1 ] = 10;
			items[ 2 ] = "test";

			for ( int index = 0; index < items.Length; index++ )
			{
				PrintEmployee( items[ index ] );
			}
		}

		static void PrintEmployee( object obj )
		{
			// this one crashes if it can't cast
			// Employee employee = (Employee)obj; 

			// this equals null if it can't cast
			Employee employee = obj as Employee;
			PrintEmployee( employee );
		}

		static void PrintEmployee( Employee employee )
		{
			if ( employee != null )
			{
				Console.WriteLine( $"Type: {employee.GetType().ToString()} - {employee.ToString()}" );
			}
		}
	}
}
