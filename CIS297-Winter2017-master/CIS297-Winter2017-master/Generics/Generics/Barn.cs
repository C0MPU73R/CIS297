using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	public class Barn<T> where T : IPrintable
	{
		private List<T> contents;

		public Barn()
		{
			contents = new List<T>();
		}

		public void add(T item)
		{
			contents.Add( item );
		}

		public string GetContentsOfBarn()
		{
			StringBuilder builder = new StringBuilder();

			foreach( T item in contents )
			{
				builder.Append( item.Print() );
			}

			return builder.ToString();
		}
	}
}
