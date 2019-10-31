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
    public class ControllerTests
    {
        [TestMethod()]
        public void controllerTestCaract1()
        {
            Controller controlle = new Controller();

            //Arrange - Création des données nécessaires
            int valueExpected = 1;

            //Act - appel de la méthode à tester
            int valueCalculated = controlle.characterController("Aujo'urd'hui");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);
          
        }
        [TestMethod()]
        public void controllerTestCaract2()
        {
            Controller controlle = new Controller();

            //Arrange - Création des données nécessaires
            int valueExpected = 0;

            //Act - appel de la méthode à tester
            int valueCalculated = controlle.characterController("Test");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
        [TestMethod()]
        public void controllerTestCaract3()
        {
            Controller controlle = new Controller();

            //Arrange - Création des données nécessaires
            int valueExpected = 1;

            //Act - appel de la méthode à tester
            int valueCalculated = controlle.characterController("Te@st");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
        [TestMethod()]
        public void controllerTestCaract4()
        {
            Controller controlle = new Controller();

            //Arrange - Création des données nécessaires
            int valueExpected = 1;

            //Act - appel de la méthode à tester
            int valueCalculated = controlle.characterController("Te%st");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
    }
}