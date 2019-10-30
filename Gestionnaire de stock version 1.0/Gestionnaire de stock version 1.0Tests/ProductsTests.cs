using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gestionnaire_de_stock_version_1._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_de_stock_version_1._0.Tests
{
    [TestClass()]
    public class ProductsTests
    {
        Products productstest;
        [TestInitialize]
        public void Init()
        {


        }
        [TestMethod()]
        public void ToStringTest()
        {
            productstest = new Products(5, "Orange");
            //Arrange - Création des données nécessaires
            string valueExpected = "Orange";

            //Act - appel de la méthode à tester
            string valueCalculated = productstest.ToString();
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
    }
}