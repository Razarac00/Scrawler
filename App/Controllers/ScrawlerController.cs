using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScrawlerController : ControllerBase
    {
        public ScrawlerController() 
        {

        }

        [HttpGet]
        public string Get()
        {
            return "test";
        }

        [HttpPost]
        public void Post(string formInput) 
        {
            
        }

    }
}
