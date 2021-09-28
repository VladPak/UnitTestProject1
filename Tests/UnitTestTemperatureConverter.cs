using FahrenheitTest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTestTemperatureConverter
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Test for getting right result
            double tempCelc = 20;
            double tempFahrenActual;
            double tempFahrenExpected = 68;

            tempFahrenActual = Temperature.CelciusToFahrenheit(tempCelc);

            Assert.AreEqual(tempFahrenExpected, tempFahrenActual);
        }
    }
}
