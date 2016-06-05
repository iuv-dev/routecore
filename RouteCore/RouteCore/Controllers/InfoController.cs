using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RouteCore.Controllers
{
    //TODO limit CORS header e.g. set origins = some domain, put customer request header, change method
    [EnableCors("*", "*", "*")]
    public class InfoController : ApiController
    {

        [HttpGet]
        public string AboutUs()
        {
            return "Hi, Route Core speaking";
        }
    }
}
