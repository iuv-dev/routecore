using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RouteCore.Controllers
{
    public class InfoController : ApiController
    {
        [HttpGet]
        public string AboutUs()
        {
            return "Hi, Route Core speaking";
        }
    }
}
