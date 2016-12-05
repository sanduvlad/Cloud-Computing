using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Homework_2.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values

        [AllowAnonymous]
        public IQueryable<string> Get()
        {
            return (new string[] { "value1", "value2" }).AsQueryable();
        }

        [AllowAnonymous]
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [AllowAnonymous]
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        [AllowAnonymous]
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [AllowAnonymous]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
