using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FahrenheitTest.Models
{
    public class Temperature
    {
        public static double CelciusToFahrenheit(double Tc)
        {
            double Tf;
            Tf = Tc * 9 / 5 + 32;
            return Tf;
        }
    }
}
