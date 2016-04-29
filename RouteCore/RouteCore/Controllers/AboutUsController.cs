using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RouteCore.Controllers
{
    public class AboutUsController : ApiController
    {
        [HttpGet]
        public string Home()
        {
           return "Welcome to AT API Route";
        }
    }
}