using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
   public class Seminar : Course
    {
        public string GuestLecturer{ get; private set; }


        public override string ToString()
        {
            return GuestLecturer;
        }

    }
}
