using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharp
{
	public static class StringExtensions
	{
		public static string ReverseMe( this string text )
		{
			char[] characters = new char[ text.Length ];
			int end = text.Length - 1;
			foreach ( char character in text )
			{
				characters[ end-- ] = character;
			}
			return new string( characters );
		}
	}
}
