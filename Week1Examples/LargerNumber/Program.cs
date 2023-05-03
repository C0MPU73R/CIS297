using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 10;
            int second = 2;
            int largerNumber = first > second ? first : second; // if first > second, largeN = first, else largeN = second
            Console.WriteLine($"First: {first} - Second: { second } - Larger {largerNumber}");
            Console.ReadLine();
        }
    }
}
