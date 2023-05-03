using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm2
{
    public class LuckyNumber : ILuckyNumber
    {
        public int GetLuckyNumber()
        {
            Random rand = new Random();

            return rand.Next(1, 101);
        }
    }
}
