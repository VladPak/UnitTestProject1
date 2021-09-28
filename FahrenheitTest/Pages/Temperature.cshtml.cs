using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FahrenheitTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FahrenheitTest.Pages
{
    public class TemperatureModel : PageModel
    {
        public double tempCelcius;
        public double tempFahrenheit;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            tempCelcius = Convert.ToDouble(Request.Form["TemperatureCelcius"]);
            tempFahrenheit = Temperature.CelciusToFahrenheit(tempCelcius);
        }
    }
}
