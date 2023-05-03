using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryclass
{
    public class BinaryString


    {


        public string number { get; set; }

        public BinaryString(string input)
        {
            result = input;
        }

        public string result;

        public static BinaryString operator +(BinaryString num1, BinaryString num2)
        {

            int first = num1.number.Length;
            int second = num2.number.Length;
            int maximumInteger = findMax(first, second);
            int carryHolder = 0;




            StringBuilder builtString = new StringBuilder(string.Empty);

            for (int index = 0; index < maximumInteger; index++)
            {
                int value1 = IndividualValue(num1.number, first - index - 1);
                int value2 = IndividualValue(num2.number, second - index - 1);
                int binarySum = value1 + value2 + carryHolder;
                builtString.Append(binarySum % 2);

                carryHolder = binarySum / 2;
            }

            if (carryHolder == 1)
            {
                builtString.Append("1");
            }
            string newBuiltString = Convert.ToString(builtString);
            string reversedBuiltString = ToReverse(newBuiltString);
            return new BinaryString(reversedBuiltString);
        }

        public static string ToReverse(string input)
        {
            char[] toReverse = new char[input.Length];
            for(int index = 0; index < input.Length; index++)
            {
                toReverse[index] = input[index];
            }

            string reversedString = "";
            for (int index = toReverse.Length - 1; index > -1; index--)
            {
                reversedString += toReverse[index];
            }
            return reversedString;
        }
        public static int IndividualValue(string input, int num)
        {
            if (num < 0 || num >= input.Length)
            {
                return 0;
            }
            if (input[num] == '0')
            {
                return 0;
            }
            else
            {
                return 1;
            }


        }


        public static int findMax(int a, int b)
        {
            int max;
            if(a > b)
            {
                max = a;
            }
            else if (b < a)
            {
                max = b;
            }
            else
            {
                max = a;
            }
            return max;
        }

    }
}
