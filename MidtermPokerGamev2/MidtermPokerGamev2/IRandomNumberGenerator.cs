using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPokerGamev2
{
    interface IRandomNumberGenerator
    {
        int Next(int minValue, int maxValue); // given an instance, will generate a new random number between min and max value
    }
}
