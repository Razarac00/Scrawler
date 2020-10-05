using System;
using System.Collections.Generic;

namespace Domain
{
    public class NumberToText
    {
        public List<string[]> numberMatrix { get; private set; }

        private string[] single_digits = new string[]
        { 
            "zero", "one", "two", 
            "three", "four", "five", 
            "six", "seven", "eight", 
            "nine"
        }; 
 
        private string[] double_digits = new string[]
        {
            "ten", "eleven", "twelve", 
            "thirteen", "fourteen", 
            "fifteen", "sixteen", "seventeen", 
            "eighteen", "nineteen"
        }; 
 
        private string[] tens_multiple = new string[]
        {
            "twenty", "thirty", 
            "forty", "fifty","sixty", 
            "seventy", "eighty", "ninety"
        }; 
 
        private string[] tens_power = new string[] 
        {
            "hundred", "thousand", "million", "billion"
        };

        public string Convert(string num)
        {
            string result = "";
            num = num.Replace(",", "");

            if (num.StartsWith("+"))
            {
                result += "positive ";
                num = num.Replace("+", "");
            } 
            else if (num.StartsWith("-"))
            {
                result += "negative ";
                num = num.Replace("-", "");
            }

            if (num.Length == 1)
            {
                result += numberMatrix[0][Int32.Parse(num)];
            } else if (num.Length == 2)
            {
                result += GroupOfThreeHandler(num);
            }

            return result;
        }

        private string GroupOfThreeHandler(string num)
        {
            string result = "";
            var arr = num.ToCharArray();

            for (int i = arr.Length - 1; i > 0; i--)
            {
                int val = Int32.Parse(arr[i].ToString());
                switch (i)
                {
                    case 2: // hundreds
                        if (val != 0)
                        {
                            result = numberMatrix[0][val] + " " + numberMatrix[3][0];
                        }
                        break;

                    case 1: // --ty's or --teen's
                        val = val - 2; // twenty--2--is at position 0
                        if (val >= 0) 
                        {
                            result += " " + numberMatrix[1][val];
                        }
                        break;

                    case 0: // singles
                        result += " " + numberMatrix[0][val];
                        break;

                    default:
                        break;

                }
            }
            return result;
        }

        public NumberToText() 
        {
            numberMatrix = new List<string[]>();
            numberMatrix.Add(single_digits);
            numberMatrix.Add(double_digits);
            numberMatrix.Add(tens_multiple);
            numberMatrix.Add(tens_power);
        }
    }
}
