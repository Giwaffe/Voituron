using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnelStartGatewayInterface;

namespace Tests
{
    [TestClass]
    public class Customer
    {
        clsGWKlant testKlant = new clsGWKlant();
        private void Connect()
        {
            clsGWaySnelStart test = new clsGWaySnelStart();
            test.Login("jan@e-force.nl", "E-F@ict16!", true);
            test.mtdGWayAdmiOpenen("C:\\SnelStart\\Administraties", "Voorbeeldbedrijf");
        }

        [TestMethod]
        public void Init_Customer()
        {
            Connect();
            Assert.IsTrue(Bool_Customer());
        }

        private bool Bool_Customer()
        {
            return testKlant.mtdGWayKlantRead(10292);
        }

        [TestMethod]
        public void Get_Customer()
        {
            Connect();

            Assert.AreEqual("Aton", Get_Customer_Naam());
            Assert.AreEqual("NL15INGB0003830183", Get_Customer_Iban());
        }

        private string Get_Customer_Naam()
        {
            testKlant.mtdGWayKlantRead(10292);
            var x = testKlant.prpNaam;

            return x;
        }

        private string Get_Customer_Iban()
        {
            testKlant.mtdGWayKlantRead(10292);
            var x = testKlant.prpIban;

            return x;
        }

        [TestMethod]
        public void Set_Customer()
        {
            Connect();

            Assert.AreEqual("Aton@Aton.nl", Set_Customer_Email());
        }

        private string Set_Customer_Email()
        {
            testKlant.mtdGWayKlantRead(10292);
            testKlant.prpEmail = "Aton@Aton.nl";
            var x = testKlant.prpEmail;

            return x;
        }

        [TestMethod]
        public void Save_Customer()
        {
            Connect();

            Assert.IsTrue(SaveCustomer());
        }

        private bool SaveCustomer()
        {
            testKlant.mtdGWayKlantRead(10292);
            testKlant.prpEmail = "Aton@Aton.nl";
            var x = testKlant.mtdGWayKlantWrite();
            return x;
        }
    }
}
