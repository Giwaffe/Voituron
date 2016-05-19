using SnelStartGatewayInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voituron_Framework
{
    public static class CustomerSnelStartConnector
    {
        public static CustomerSnelStart Get(long Id)
        {
            var Customer = new CustomerSnelStart();

            clsGWaySnelStart test = new clsGWaySnelStart();
            //test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("C:\\SnelStart\\Administraties", "Voorbeeldbedrijf");

            clsGWKlant testCustomer = new clsGWKlant();

            testCustomer.mtdGWayKlantRead(10292);

            Customer.Id = 102;
            Customer.Name = testCustomer.prpNaam;

            return Customer;
        }
    }
}
