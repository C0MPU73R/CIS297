using System;
using System.Collections.Generic;

namespace Bingo
{
	class Program
	{
		static int[,] board;
		static List<int> numbersPicked;
		static void Main( string[] args )
		{
			board = new int[ 5, 5 ];
			numbersPicked = new List<int>();
			Random random = new Random();
			for ( int row = 0; row < board.GetLength( 0 ); row++ )
			{
				for ( int col = 0; col < board.GetLength( 1 ); col++ )
				{
					board[ row, col ] = random.Next( 1, 75 );
				}
			}
			Print();
			while ( !GameOver() )
			{
				int numberPicked;
				Int32.TryParse( Console.ReadLine(), out numberPicked );
				if ( numberPicked == 0 )
				{
					Console.WriteLine( "Please enter a number" );
				}
				else
				{
					numbersPicked.Add( numberPicked );
				}
			}
		}

		private static bool HasDiagonalDownBingo()
		{
			for ( int row = 0; row < board.GetLength( 0 ); row++ )
			{
				if ( !numbersPicked.Contains( board[ row, row ] ) )
				{
					return false;
				}
			}
			return true;
		}

		private static bool HasDiagonalUpBingo()
		{
			for ( int row = board.GetLength( 0 ) - 1; row >= 0; row-- )
			{
				if ( !numbersPicked.Contains( board[ row, board.GetLength( 0 ) - row - 1 ] ) )
				{
					return false;
				}
			}
			return true;
		}

		private static bool HasRowBingo()
		{
			for ( int row = 0; row < board.GetLength( 0 ); row++ )
			{
				bool hasBingo = true;
				for ( int col = 0; hasBingo && col < board.GetLength( 1 ); col++ )
				{
					if ( !numbersPicked.Contains( board[ row, col ] ) )
					{
						hasBingo = false;
					}
				}
				if ( hasBingo )
				{
					return true;
				}
			}
			return false;
		}

		static bool HasColumnBingo()
		{
			for ( int col = 0; col < board.GetLength( 1 ); col++ )
			{
				bool hasBingo = true;
				for ( int row = 0; hasBingo && row < board.GetLength( 0 ); row++ )
				{
					if ( !numbersPicked.Contains( board[ row, col ] ) )
					{
						hasBingo = false;
					}
				}
				if ( hasBingo )
				{
					return true;
				}
			}
			return false;
		}

		static bool GameOver()
		{
			return ( HasColumnBingo() || HasRowBingo()
				|| HasDiagonalUpBingo() || HasDiagonalDownBingo() );
		}

		static void Print()
		{
			for ( int row = 0; row < board.GetLength( 0 ); row++ )
			{
				for ( int col = 0; col < board.GetLength( 1 ); col++ )
				{
					Console.Write( board[ row, col ].ToString() + "\t" );
				}
				Console.WriteLine();
			}
		}
	}
}
