using System;
using System.Collections.Generic;

namespace Domain
{
    public class NumberToText
    {
        public List<string[]> numberMatrix { get; private set; }

        private readonly string ERROR_MESSAGE = "Error: Your number is way too long you freak LOL";

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
            "hundred", "thousand", "million", "billion", "trillion"
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
            } 
            else if (num.Length <= 3)
            {
                result += GroupOfThreeHandler(num);
            } 
            else
            {
                num = String.Format("{0:#,###0}", Int64.Parse(num)); // forcefully add commas every third digit
                string[] splits = num.Split(','); // 123,456 -> [123, 456]
                int power = splits.Length - 1;

                for (int i = 0; i < splits.Length; i++)
                {
                    string nextSet = GroupOfThreeHandler(splits[i]).Trim();
                    if (power > 0)
                    {

                        if (nextSet != "")
                        {
                            if (power >= numberMatrix[3].Length) 
                            {
                                return ERROR_MESSAGE;
                            }
                            result += nextSet + " " + numberMatrix[3][power] + " ";
                        }
                        power--;
                    }
                    else
                    {
                        result = result.Trim() + " " + nextSet;
                    }

                }

            }


            return result.Trim();
        }

        private string GroupOfThreeHandler(string num) 
        {
            string result = "";
            var arr = num.ToCharArray(); // [4, 2] [0,1]
            Array.Reverse(arr); // [2, 4]

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int val = Int32.Parse(arr[i].ToString());
                switch (i)
                {
                    case 0: // singles
                        if (val != 0)
                        {
                            result = result.Trim();
                            result += " " + numberMatrix[0][val];
                        }
                        break;

                    case 1: // --ty's or --teen's
                        if (val == 1)
                        {
                            // teens
                            if (result.Contains("hundred"))
                            {
                                result += " ";
                            }
                            val = Int32.Parse(arr[i - 1].ToString());
                            result += numberMatrix[1][val];
                            return result;
                        } 
                        else
                        {
                            val = val - 2; // twenty--2--is at position 0
                            if (val >= 0) 
                            {
                                if (result.Contains("hundred"))
                                {
                                    result += " ";
                                }
                                result += numberMatrix[2][val];
                            }
                        }
                        break;

                    case 2: // hundreds
                        if (val != 0)
                        {
                            result = numberMatrix[0][val] + " " + numberMatrix[3][0];
                        }
                        break;

                    default:
                        result += " you shouldn't be here ";
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
