using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Domain;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumToTextServiceController : ControllerBase
    {
        private NumberToText numberToText = new NumberToText();

        private ScrawlText st = new ScrawlText();
        public NumToTextServiceController() 
        {

        }

        [HttpGet]
        public ScrawlText Get()
        {
            if (st.originalString == null)
            {
                st.originalString = "2020";
                st.rebuiltString = numberToText.Convert(st.originalString);
            } 
            else
            {
                st.rebuiltString = RebuildFromOrigin();    
            }
            return st;
        }

        [HttpPost]
        public ScrawlText Post(ScrawlText formInput) 
        {
            st.originalString = formInput.originalString;
            st.rebuiltString = RebuildFromOrigin(); 
            return st; 
        }

        private string RebuildFromOrigin()
        {
            string result = "";
            string[] origin = st.originalString.Split();
            long value;
            for (int i = 0; i < origin.Length; i++)
            {
                string word = origin[i];
                if (Int64.TryParse(word, out value))
                {
                    origin[i] = numberToText.Convert(word);
                }
            }
            result = origin.ToString();
            return result;
        }

    }
}
