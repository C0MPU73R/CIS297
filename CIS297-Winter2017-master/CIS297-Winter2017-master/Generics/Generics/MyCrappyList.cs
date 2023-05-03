using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	public class MyStack<T>
	{
		private List<T> list;

		public MyStack()
		{
			list = new List<T>();
		}

		public void Add(T item)
		{
			list.Add( item );
		}

		public T Pop()
		{
			T temp = list[ list.Count - 1 ];
			list.RemoveAt( list.Count - 1 );
			return temp;
		}

		public T Peek()
		{
			return list[ list.Count - 1 ];
		}
	}
}
