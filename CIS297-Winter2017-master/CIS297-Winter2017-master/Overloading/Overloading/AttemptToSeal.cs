using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
	class AttemptToSeal : Food
	{
		public AttemptToSeal( string name, int calories, string hiThere ) : base( name, calories )
		{
		}
	}
}
