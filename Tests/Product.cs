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
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("C:\\SnelStart\\Administraties", "Voorbeeldbedrijf");
        }

        [TestMethod]
        public void Read_Product()
        {
            connect();
            var x = ReadProduct();

            Assert.AreEqual(true, x);
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
            var x = testProduct.prpOmschrijvingGet;
            return x;
        }

    }
}
