using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DSO_DotNet
{
    public class LoginController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new[] {"value1", "value2"};
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "You requested " + id;
        }

        // POST api/<controller>
        public void Post([FromBody] string username, [FromBody] string passphrase)
        {
           
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}