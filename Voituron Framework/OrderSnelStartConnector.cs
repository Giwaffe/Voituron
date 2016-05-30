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

        public static OrderSnelStart Create_Order()
        {
            var snelstart = new clsGWaySnelStart();
            var order = new OrderSnelStart();
            var voituronpropertyInt = 5;
            var voituronpropertyStr = "15";

            order.fpRelatieCode = voituronpropertyInt;
            order.fpAantalInkoop = voituronpropertyInt;
            order.fpAantalVerkocht = voituronpropertyInt;
            order.fpArtikelCode = voituronpropertyStr;
            order.fpExtraData = voituronpropertyInt;
            order.fpKorting = voituronpropertyInt;
            order.fpKostenPlaatsNummer = voituronpropertyInt;
            order.fpOmschrijving = voituronpropertyStr;
            order.fpPrijs = voituronpropertyInt;

            //snelstart.mtdGWayVerkoopOrderAanmakenA(1, order.fpRelatieCode, DateTime.Today, order.fpOmschrijving);
            snelstart.mtdGWayVerkoopOrderAanmakenA(1,10292, DateTime.Today, "");
            snelstart.mtdGWayVerkoopOrderRegelToevoegenArtikelA(order.fpArtikelCode, order.fpAantalVerkocht);
            snelstart.mtdGWayVerkoopOrderSluiten();

            return order;
        }
    }
}
