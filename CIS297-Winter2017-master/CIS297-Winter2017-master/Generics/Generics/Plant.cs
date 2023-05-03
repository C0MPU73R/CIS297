using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	public class Plant : IPrintable
	{
		public string Name;
		public bool IsEdible;

		public string Print()
		{
			return string.Format("You can{0} eat a {1}", IsEdible ? "" : " not", Name);
		}
	}
}
