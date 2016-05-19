using SnelStartGatewayInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using Voituron_Framework;

namespace Api.Controllers
{
    //[Authorize]
    public class ProductApiController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public ProductSnelStart Get(string id)
        {

            Assembly.Load("SnelStartGatewayInterface");

            clsGWaySnelStart test = new clsGWaySnelStart();
            //var z = test.prpGWayLoginSettingsGet;
            //test.mtdGWayAdmiOpenenViaLoginSettings(0, z);
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("C:\\SnelStart\\Administraties", "Voorbeeldbedrijf");


            ProductSnelStart obj = ProductSnelStartConnector.Get(id);
            return obj;
        }

        // POST api/values
        public void Post([FromBody]ProductSnelStart value)
        {
            var x = value;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            var i = id;
            var x = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var x = id;
        }
    }
}
