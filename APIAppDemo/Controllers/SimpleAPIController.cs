using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIAppDemo.Controllers
{
    public class SimpleAPIController : ApiController
    {
        public string Get()
        {
            return "welcome to the wold of API";
        }
        public List<string> Get(int Id)
        {
            return new List<string>
            {
                "welcome bro"
            };

        }
        
       
    }
}
