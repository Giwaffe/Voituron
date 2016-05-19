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
            var z = test.prpGWayLoginSettingsGet;
            test.mtdGWayAdmiOpenenViaLoginSettings(0, z);
            //test.Login("jan@e-force.nl", "E-F@ict16!", true);
            //test.mtdGWayAdmiOpenen("C:\\SnelStart\\Administraties", "Voorbeeldbedrijf");

            clsGWArtikel testProduct = new clsGWArtikel();

            testProduct.mtdGWayArtikelRead(Id.ToString());

            product.Id = Id;                                                    // Id of the Product
            product.Name = testProduct.prpOmschrijvingGet;                      // Name of the Product
            product.Price = testProduct.prpVerkoopprijsGet;                     // Price of the Product
            product.DiscountGroup = testProduct.prpArtikelKortinggroepIDGet;    // Discountgroup of the Product
            product.MaxDiscount = testProduct.prpMaxKortingsPercentageGet;      // MaxDiscount of the Product
            product.AmountInStorage = testProduct.prpVoorraadTechnischGet;      // Quantity in Storage


            return product;
        }
    }
}
