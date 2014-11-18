using System.Web.Http;

namespace DSOApi.Controllers
{
    public class HomeController : ApiController
    {
        [Route("api/home")]
        public string Get()
        {
            return "Welcome";
        }

        [Route("api/home/{id}")]
        public string Get(int id)
        {
            return " you requested " + id;
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
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