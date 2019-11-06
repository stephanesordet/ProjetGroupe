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
    public class SupplierTests
    {
        Supplier suppliertest;
        [TestInitialize]
        public void Init()
        {
            

        }
        [TestMethod()]
        public void ToStringTest()
        {
            suppliertest = new Supplier(5, "Luana", "Kirchner", "luana@cpnv.ch");
            //Arrange - Création des données nécessaires
            string valueExpected = "Luana";
            valueExpected += " ";
            valueExpected += "Kirchner";

            //Act - appel de la méthode à tester
            string valueCalculated = suppliertest.ToString();
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);
           
        }
    }
}