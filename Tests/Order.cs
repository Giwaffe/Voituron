using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnelStartGatewayInterface;

namespace Tests
{
    [TestClass]
    public class Order
    {
        clsGWaySnelStart testOrder = new clsGWaySnelStart();

        private void Connect()
        {
            clsGWaySnelStart test = new clsGWaySnelStart();
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("D:\\SnelStart\\Administraties", "Voorbeeldbedrijf");
        }

        [TestMethod]
        public void ConnectorRead_Order()
        {
            var obj = Voituron_Framework.OrderSnelStartConnector.Get(10031);

            Assert.AreEqual(true, true);
        }


        [TestMethod]
        public void Create_An_Order()
        {
            Connect();            
            var x = Create(); 
            Assert.AreEqual("Done", x);            
        }

        private string Create()
        {
            testOrder.mtdGWayVerkoopOrderAanmakenA(1, 10292, DateTime.Today, "Test order maken");
            testOrder.mtdGWayVerkoopOrderRegelToevoegenTekst("Tekstregel");
            testOrder.mtdGWayVerkoopOrderRegelToevoegenArtikelA("12", 3);            
            var x = testOrder.mtdGWayVerkoopOrderSluitenGet();
            System.Diagnostics.Debug.WriteLine(x);
            return "Done";       
        }

        [TestMethod]
        public void Get_Order()
        {
            Connect();
            Assert.IsNotNull(GetOrder());
        }

        private clsGWayVerkoopOrder GetOrder()
        {
            var x = testOrder.mtdGWayVerkoopOrderByNummerGet(220389);

            return x;
        }
        [TestMethod]
        public void Create_Order()
        {
            Connect();
            var obj = Voituron_Framework.OrderSnelStartConnector.Create_Order();
            Assert.IsNotNull(obj);
        }
    }
}
