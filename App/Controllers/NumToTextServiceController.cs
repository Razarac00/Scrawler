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
            Console.WriteLine("Get has " + st.RebuiltString);
            return st;
        }

        [HttpPost]
        public ScrawlText Post(ScrawlText formInput) 
        {
            st.OriginalString = formInput.OriginalString; 
            st.RebuiltString = st.RebuiltString;
            Console.WriteLine("Can confirm post has " + st.RebuiltString);
            return st; 
        }

    }
}
