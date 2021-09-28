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
            double tempCelc = 22;
            double tempFahrenActual;
            double tempFahrenExpected = 71.6;

            tempFahrenActual = Temperature.CelciusToFahrenheit(tempCelc);

            Assert.AreEqual(tempFahrenExpected, tempFahrenActual);
        }
    }
}
