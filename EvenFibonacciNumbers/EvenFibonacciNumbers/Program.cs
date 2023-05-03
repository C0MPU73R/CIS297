using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci a;
            a.sumOfEvenFibonacciNumbers(10);
        }
    }


    class Fibonacci
    {
        Fibonacci()
        {

        }
        public int sumofEvenFibonacciNumbers(int x)
        {
            int sum = 0;
            if (x < 4000000)
            {
                for (int index = 0; index < ; index++)
                {

                    sum += checkLessThan4000000(even(x - 2)) + checkLessThan4000000(even(x - 1));
                }
            }
            return sum;
        }


        public int even(int x)
        {
            if (x % 2 == 0)

            {
                return x;
            }
            else
            {
                return 0;
            }
        }

        public int checkLessThan4000000(int x)
        {
            if (x < 4000000)
            {
                return x;
            }
        }

        private int sum;



    }





}
