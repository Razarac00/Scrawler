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
        public NumToTextServiceController() 
        {

        }

        [HttpGet]
        public ScrawlText Get()
        {
            ScrawlText st = new ScrawlText();
            st.originalString = "2020";
            st.rebuiltString = numberToText.Convert(st.originalString);
            return st;
        }

        // [HttpPost]
        // public void Post(string formInput) 
        // {
            
        // }

    }
}
