using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class reverseClass
    {


        public void ReverseCharacters(char[] toReverse)

        {
            for (int index = 0; index < toReverse.Length / 2; index++)
            {
                char temp = toReverse[index];
                toReverse[index] = toReverse[toReverse.Length - index - 1];
                toReverse[toReverse.Length - index - 1] = temp;

            }

        }
    }
}
