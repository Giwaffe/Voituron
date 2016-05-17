using SnelStartGatewayInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voituron_Framework
{
    public static class ProductSnelStartConnector
    {

        public static ProductSnelStart Get(long Id)
        {
            var product = new ProductSnelStart();            

            clsGWaySnelStart test = new clsGWaySnelStart();
            //test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("C:\\SnelStart\\Administraties", "Voorbeeldbedrijf");

            clsGWArtikel testProduct = new clsGWArtikel();

            testProduct.mtdGWayArtikelRead(Id.ToString());

            product.Id = Id;
            product.Name = testProduct.prpOmschrijvingGet;

            return product;
        }
    }
}
