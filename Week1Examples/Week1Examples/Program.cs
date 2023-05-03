using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Examples
{

    public enum DaysOfTheWeek {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

    class Program
    {
        static void Main(string[] args)
        {

          // PrintDayOfTheWeek(Console.ReadLine());
          DaysOfTheWeek try1 = Console.ReadKey();
            // Console.ReadLine(try1);
          Console.WriteLine(try1);
            Console.ReadLine();

        }

        static string PrintDayOfTheWeek(DaysOfTheWeek day)
        {
            switch(day)
            {
                case DaysOfTheWeek.Sunday:
                    return "Sunday";
                case DaysOfTheWeek.Monday:
                    return "Monday";
                case DaysOfTheWeek.Tuesday:
                    return "Tuesday";
                case DaysOfTheWeek.Wednesday:
                    return "Wednesday";
                case DaysOfTheWeek.Thursday:
                    return "Thursday";
                case DaysOfTheWeek.Friday:
                    return "Friday";
                case DaysOfTheWeek.Saturday:
                    return "Saturday";
                default:
                    return "Not a day";

            }


          

        }

    }
}
