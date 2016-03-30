using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class YetkiliController : ApiController
    {
        // GET: api/mg
        [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "Auth value1", "Auth value2" };
        }
 
    }
}
