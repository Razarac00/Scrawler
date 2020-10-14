using System;
using Domain;

namespace App
{
    public class ScrawlText
    {
        private string _rebuiltString;
        private NumberToText numberToText = new NumberToText();
        public string OriginalString { get; set; } = "";

        public string RebuiltString 
        { 
            get 
            {
                return RebuildFromOrigin();
            } 
            set 
            {
                _rebuiltString = value;
            }     
        }

        private string RebuildFromOrigin()
        {
            string result = "";
            string[] origin = OriginalString.Split();
            long value;
            for (int i = 0; i < origin.Length; i++)
            {
                string word = origin[i];
                if (Int64.TryParse(word, out value))
                {
                    origin[i] = numberToText.Convert(word);
                }
            }
            result = string.Join(" ", origin);
            return result;
        }

    }
}