using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Domain;
using Newtonsoft.Json;

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
            Console.Write("In Get, " + st.OriginalString + " and " + st.RebuiltString + "\n");
            return st;
        }

        // [HttpPost]
        // public async Task<ActionResult<ScrawlText>> Post(string JSONInput)
        // {
        //     Console.Write("What the hell is this " + JSONInput);
        //     st = JsonConvert.DeserializeObject<ScrawlText>(JSONInput);
        //     return Post(st);
        // }
        [HttpPost]
        public ScrawlText Post(ScrawlText formInput) 
        {
            Console.Write("In Post, " + formInput.OriginalString + "\n");
            st.OriginalString = formInput.OriginalString; 
            st.RebuiltString = st.RebuiltString;
            Console.Write("End Post, " + st.RebuiltString + "\n");
            return st; 
        }

    }
}
