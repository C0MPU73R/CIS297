using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProgramForMidterm
{
    public class RandomNumberGenerator : INumberGenerator//used with permission from Eric Charnesky
    {
        private Random random;

        public RandomNumberGenerator()
        {
            random = new Random();
        }

        public int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}
