using SnelStartGatewayInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voituron_Framework
{
    public static class OrderSnelStartConnector
    {

        public static OrderSnelStart Get(int Id)
        {
            var order = new OrderSnelStart();

            clsGWaySnelStart test = new clsGWaySnelStart();
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("D:\\SnelStart\\Administraties", "Voorbeeldbedrijf");

            return order;
        }

        public static OrderSnelStart Post()
        {
            var order = new OrderSnelStart();

            return order;
        }
    }
}
