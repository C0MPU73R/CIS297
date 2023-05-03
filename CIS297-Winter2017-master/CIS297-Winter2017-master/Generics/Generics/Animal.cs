using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	public class Animal : IPrintable
	{
		public string Name;
		public string Type;
		public string Print()
		{
			return Type + " " + Name;
		}
	}
}
