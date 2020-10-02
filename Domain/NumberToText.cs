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
