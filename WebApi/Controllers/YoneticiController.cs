using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    [Authorize(Roles = "yonetici")]
    public class YoneticiController : ApiController
    {
        // GET: api/Yonetici
        public IEnumerable<string> Get()
        {
            var x = User.IsInRole("yonetici")
              ;
            
            return new string[] { "Yönetici value1", " Yönetici value2" };
        }
 
    }
}
