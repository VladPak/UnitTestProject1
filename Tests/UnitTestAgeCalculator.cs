using FahrenheitTest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class UnitTestAgeCalculator
    {
        [TestMethod]
        public void TestAgeCalculator()
        {
            //Test for getting right result
            DateTime myDate = new DateTime(1994, 12, 13);
            DateTime dateToday = new DateTime(2021, 9, 28);
            int ageActual;
            int ageExpected = 26;

            ageActual = AgeCalculator.HowOldAmI(dateToday, myDate);

            Assert.AreEqual(ageExpected, ageActual);
        }

        [TestMethod]
        public void TestForNull()
        {
            //Test for getting right result
            DateTime myDate = new DateTime(1994, 12, 13);
            DateTime dateToday = new DateTime(2021, 9, 28);
            int ageActual;

            ageActual = AgeCalculator.HowOldAmI(dateToday, myDate);
            Assert.IsNotNull(ageActual);
        }
    }
}
