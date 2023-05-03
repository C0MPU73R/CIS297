using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Examples
{
	public enum DaysOfTheWeek { Sunday = 10, Monday = 20, Tuesday = 42, Wednesday, Thursday, Friday, Saturday };
	class Program
	{
		static bool _debug = false;
		static void Main( string[] args )
		{
			
			// don't close the program when running in debug
			Console.ReadLine();
		}

		static string PrintDayOfWeek( DaysOfTheWeek day )
		{
			switch( day )
			{
				case DaysOfTheWeek.Sunday:
					return "Sunday";
				default:
					return "Not a day???";
			}
		}

		static void Arrays()
		{
			string[] names = new string[ 2 ] { "Michael", "Mitchell" };

			for ( int index = 0; index < names.Length; index++ )
			{
				Console.WriteLine( names[ index ] );
			}

			foreach ( string name in names )
			{
				Console.WriteLine( name );
			}
		}

		static void CheckForArguments( string[] args )
		{
			if ( args.Length > 0 && args[ 0 ] == "-debug" )
			{
				_debug = true;
			}
			for ( int index = 0; index < args.Length; index++ )
			{
				Console.WriteLine( $"Argument #{index}: {args[ index ]}" );
			}
		}

		static void LoopControl()
		{
			for ( int x = 0; x < 100; x++ )
			{
				if ( x == 42 )
				{
					break;
				}
				if ( x % 3 == 0 )
				{
					continue;
				}

				Console.WriteLine( x );

			}
		}
		static void IntDivisonAndTernay()
		{
			int first = 10;
			int second = 25;
			// integer division, no decimal
			float third = second / first;

			// = expression ? value if true : value if false
			int largerNumber = first > second ? first : second;
			// shorthand for this
			if ( first > second )
			{
				largerNumber = first;
			}
			else
			{
				largerNumber = second;
			}

			Console.WriteLine( $"First: {first} - Second: { second } - Third: {third}" );
		}
		static void GuessNumber()
		{
			Random random = new Random();
			Console.WriteLine( "What number would you like to guess up to?" );
			int maxNumber = Convert.ToInt32( Console.ReadLine() );
			if ( _debug )
			{
				Console.WriteLine( $"Max number: {maxNumber}" );
			}
			int magicNumber = random.Next( 1, maxNumber );
			int usersGuess = 0;
			int numberOfGuess = 0;
			while ( usersGuess != magicNumber )
			{
				Console.WriteLine( $"Guess a number 1-{maxNumber}" );
				usersGuess = Convert.ToInt32( Console.ReadLine() );
				numberOfGuess++;

				if ( usersGuess > magicNumber )
				{
					Console.WriteLine( "Too high, guess again!" );
				}
				else if ( usersGuess < magicNumber )
				{
					Console.WriteLine( "Too low, guess again!" );
				}
				else
				{
					Console.WriteLine( $"You guessed it in {numberOfGuess} guesses!\nThe max number was {maxNumber}" );
					// same as
					//Console.WriteLine( "You guessed it in " + numberOfGuess + " guesses!\nThe max number was " + maxNumber );
				}
			}
		}
	}
}
