using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterrm3
{
    public class Course
    {
        private int Number;
        private string Title;
        private int Credits;





        public Course(int number, string title, int credits)
        {
            Number = number;
            Title = title;
            Credits = credits;
        }

        public string NUMBER
        {
            get
            {
                return Convert.ToString(Number);
            }
            protected set
            {
                string Numberv2 = Convert.ToString(Number);
                Numberv2 = value;
            }
        }


        public string TITLE
        {
            get
            {
                return Title;
            }
            protected set
            {

                Title = value;
            }
        }


        public string CREDITS
        {
            get
            {
                return Convert.ToString(Credits);
            }
            protected set
            {
                string Creditsv2 = Convert.ToString(Credits);
                Creditsv2 = value;
            }
        }


        public override string ToString()
        {
            return "Number: " + Number + " " +  "Title: " + Title + " " + "Credits: " + Credits;
        }


    }
}
