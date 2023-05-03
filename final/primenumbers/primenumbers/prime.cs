using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumbers
{
    public class prime : IEnumerable
    {
        public int primeNumberAmount { get; set; }


        public prime(int amount)
        {
            primeNumberAmount = amount;
        }
        public IEnumerator GetEnumerator()
        {
            List<int> primes = new List<int>();

            
           


            //prime number work
            for(int index = 2; index <= primeNumberAmount; index++)
            {
                for(int index2 = 2; index2*index2 < index; index2++)
                {
                    if(index % index2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        //add prime numbers to collection
                        primes.Add(index);
                        
                    }
                }
            }

            IEnumerable<int> items = primes;
            yield return primes;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
