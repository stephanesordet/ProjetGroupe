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
            //Arrange - Création des données nécessaires
            int valueExpected = 1;

            //Act - appel de la méthode à tester
            int valueCalculated = Controller.characterController("Aujo'urd'hui");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);
          
        }
        [TestMethod()]
        public void controllerTestCaract2()
        {
            //Arrange - Création des données nécessaires
            int valueExpected = 0;

            //Act - appel de la méthode à tester
            int valueCalculated = Controller.characterController("Test");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
        [TestMethod()]
        public void controllerTestCaract3()
        {
            //Arrange - Création des données nécessaires
            int valueExpected = 11;

            //Act - appel de la méthode à tester
            int valueCalculated = Controller.characterController("Te@st");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
        [TestMethod()]
        public void controllerTestCaract4()
        {
            //Arrange - Création des données nécessaires
            int valueExpected = 1;

            //Act - appel de la méthode à tester
            int valueCalculated = Controller.characterController("Te%st");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
        [TestMethod()]
        public void controllerNomberTrue()
        {
            //Arrange - Création des données nécessaires
            bool valueExpected = true;

            //Act - appel de la méthode à tester
            bool valueCalculated = Controller.numberController("4");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
        [TestMethod()]
        public void controllerNomberFalse()
        {
            //Arrange - Création des données nécessaires
            bool valueExpected = false;

            //Act - appel de la méthode à tester
            bool valueCalculated = Controller.numberController("numero4");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
        [TestMethod()]
        public void controllerDateTrue()
        {
            //Arrange - Création des données nécessaires
            bool valueExpected = true;

            //Act - appel de la méthode à tester
            bool valueCalculated = Controller.DateController("02.05.2019");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
        [TestMethod()]
        public void controllerDateFalse()
        {
            //Arrange - Création des données nécessaires
            bool valueExpected = false;

            //Act - appel de la méthode à tester
            bool valueCalculated = Controller.DateController("03-05-2019");
            //Assert
            Assert.AreEqual(valueExpected, valueCalculated);

        }
    }
}