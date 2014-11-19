using System.Web.Http;

namespace DSOApi.Controllers
{
    [RoutePrefix("api/")]
    public class MeterController : ApiController
    {
        [Route("BuyCredit")]
        public void BuyCredit([FromBody] string creditValue, string serialNumber)
        {
        }
    }
}