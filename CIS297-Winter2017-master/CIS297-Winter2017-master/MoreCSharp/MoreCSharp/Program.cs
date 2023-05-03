using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MoreCSharp;

namespace MoreCSharp
{
	public class Program
	{
		static void Main( string[] args )
		{
			Triangle first = new Triangle();
			first.setSides( 3, 4, 5 );

			Triangle second = new Triangle();
			second.setSides( 5, 12, 13 );

			Triangle sum = second + first;

			Console.WriteLine( sum[ 0 ] );
			Console.WriteLine( sum[ 1 ] );
			Console.WriteLine( sum[ 2 ] );
			string test = "test";
			Console.WriteLine( test.ReverseMe() );


			List<int> numbers = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 35 };

			List<House> houses = new List<House>
			{

				new House
				{
					StreetNumber = "123 Main St.",
					ZipCode = "48123",
					YearBuilt = 1990
				},

				new House
				{
					StreetNumber = "456 Main St.",
					ZipCode = "48123",
					YearBuilt = 1995
				},
				new House
				{
					StreetNumber = "789 Main St.",
					ZipCode = "48123",
					YearBuilt = 2000
				}
			};

			IEnumerable<House> newHouses =
				from house in houses
				where house.YearBuilt >= 2000
				select house;
			// these are equivalent
			IEnumerable<House> otherNewHouses = houses.Where(
				house => house.YearBuilt >= 2000 );



			// The lambda notation allows us to define a 'method' in line instead of using
			// IEnumerable<int> evenNumbers = numbers.Where( IsEven );
			IEnumerable < int > evenNumbers = numbers.Where( number => number % 2 == 0 );

			foreach ( int number in evenNumbers )
			{
				Console.WriteLine( number );
			}

			Console.ReadKey();
		}

		public static bool IsEven( int number )
		{
			return number % 2 == 0;
		}

		public void FilesAndExceptions()
		{
			WriteLine( "abc" );
			string[] letters = { "a", "b", "c", "d" };
			//Print( 2, "a", "b", "c", "d" );
			//Print( 3, letters );

			string oneBigString = File.ReadAllText( "colors.txt" );
			string[] contents = File.ReadAllLines( "fib.txt" );

			int sum = 0;
			foreach ( string line in contents )
			{
				int result;
				if ( !Int32.TryParse( line, out result ) )
				{
					WriteLine( $"Failed to convert {line}" );
				}
				sum += result;
			}

			WriteLine( sum );

			WriteLine( "Printing one big string" );
			WriteLine( oneBigString );

			WriteLine( "Printing each string from contents" );

			File.WriteAllText( "Classes.txt", string.Format( "CIS297{0}CIS310{0}CIS350{0}CIS375", Environment.NewLine ) );

			FileStream fileStream = File.OpenWrite( "binaryContents.openme" );
			BinaryWriter writer = new BinaryWriter( fileStream );

			try
			{
				writer.Write( 1 );
				writer.Write( 1 );
				writer.Write( 2 );
				writer.Write( 3 );
				writer.Write( 5 );
			}
			catch ( Exception e )
			{
				WriteLine( e.StackTrace );
			}
			finally
			{
				writer.Close();
			}



			FileStream readStream = File.OpenRead( "binaryContents.openme" );
			BinaryReader reader = new BinaryReader( readStream );
			WriteLine( reader.ReadInt32() );
			WriteLine( reader.ReadInt32() );
			WriteLine( reader.ReadInt32() );
			WriteLine( reader.ReadInt32() );
			WriteLine( reader.ReadInt32() );


			Print( 1, contents );


			try
			{
				Triangle triangle = new Triangle();
				triangle.setSides( 3, 4, 5 );
				triangle.setSides( 4, 5, 6 );
			}
			catch ( InvalidOperationException e )
			{
				WriteLine( e.StackTrace );
			}
			catch ( Exception e )
			{
				WriteLine( e.StackTrace );
			}



		}

		public static void Print( int times, params string[] values )
		{
			for ( int time = 0; time < times; time++ )
			{
				foreach ( string value in values )
				{
					WriteLine( value );
				}
			}

		}
	}
}
