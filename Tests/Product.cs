using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnelStartGatewayInterface;

namespace Tests
{
    [TestClass]
    public class Product
    {
        clsGWArtikel testProduct = new clsGWArtikel();

        public void connect()
        {
            clsGWaySnelStart test = new clsGWaySnelStart();
            //clsGWayLoginSettings testLogin = new clsGWayLoginSettings();
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("D:\\SnelStart\\Administraties", "Voorbeeldbedrijf");
            //test.mtdGWayAdmiOpenenViaLoginSettings(0, testLogin);
        }

        [TestMethod]
        public void Read_Product()
        {
            connect();
            var x = ReadProduct();

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void ConnectorRead_Product()
        {
            var obj = Voituron_Framework.ProductSnelStartConnector.Get("10031");

            Assert.AreEqual(true, true);
        }

        private Boolean ReadProduct()
        {           
             return testProduct.mtdGWayArtikelRead("1");  
        }

        [TestMethod]
        public void Read_Omschrijving()
        {
            connect();
            var x = ReadInfo();

            Assert.AreEqual("Tafelcontactdoos", x);
        }

        private String ReadInfo()
        {
            testProduct.mtdGWayArtikelRead("10031");
            var a = testProduct.prpOmschrijvingGet;                     // name of the product
            var b = testProduct.prpEenheidGet;                          // quantity of the product
            var c = testProduct.prpArtikelKortinggroepIDGet;            // discount group
            var d = testProduct.prpMaxKortingsPercentageGet;            // max discount
            var e = testProduct.prpVerkoopprijsGet;                     // price of the product

            return a;
        }

        [TestMethod]
        public void Get_ProductList()
        {
            var obj = Voituron_Framework.ProductSnelStartConnector.ListProductsGet();
            var x = obj.Count;

            Assert.AreEqual(20, x);
        }
    }
}
