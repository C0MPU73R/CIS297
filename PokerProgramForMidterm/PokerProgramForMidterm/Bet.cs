using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProgramForMidterm
{
    // T is your class implemenation of the PokerHand or Horse
    // your class will implement ICompareable so it can be compared
    public class Bet<T> where T : IComparable<T>//used with permission from Eric Charnesky
    {
        public T Mine { get; set; }
        public T[] Theirs { get; set; }

        public int WagerAmount { get; set; }

        public int DoBet()
        {
            if (Mine == null || Theirs == null)
            {
                throw new InvalidOperationException("Must define Mine and Theirs before betting");
            }
            if (Theirs.Length == 0)
            {
                return WagerAmount;
            }

            T highest = Mine;
            foreach (T them in Theirs)
            {
                if (highest.CompareTo(them) < 0)
                {
                    highest = them;
                }
            }

            int numberOfHighest = 0;
            if (Mine.CompareTo(highest) == 0)
            {
                numberOfHighest++;
                foreach (T them in Theirs)
                {
                    if (highest.CompareTo(them) == 0)
                    {
                        numberOfHighest++;
                    }
                }

                return (WagerAmount * Theirs.Length + WagerAmount) / numberOfHighest;
            }
            else
            {
                return 0;
            }

        }
    }
}
