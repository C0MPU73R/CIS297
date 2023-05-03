using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterrm3
{
    public class Seminar : Course
    {
        public Seminar(int number, string title, int credits) : base(number, title, credits)
        {
        }

        public string GuestLecturer { get; private set; }


        public override string ToString()
        {
            string str1 = base.ToString();

            string str2 = GuestLecturer;
            return str1 + " Guest Lecturer: " + str2;
        }

    }

}

