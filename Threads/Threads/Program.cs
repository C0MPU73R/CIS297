using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(CountTo100);
            thread1.Start();

            Thread thread2 = new Thread(CountTo100);
            thread2.Start();



            thread1.Join();
            thread2.Join();


            Thread.Sleep(1000);
            Console.ReadKey();

        }







        public static void CountTo100()
        {
            for(int index = 0; index < 100; index++)
            {
                Console.WriteLine(index + 1);
            }
        }
    }
}
