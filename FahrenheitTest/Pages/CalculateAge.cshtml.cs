using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FahrenheitTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FahrenheitTest.Pages
{
    public class CalculateAgeModel : PageModel
    {
        public DateTime currentDate;
        public DateTime myBirthDate;
        public int age;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            currentDate = Convert.ToDateTime(Request.Form["CurrentDate"]);
            myBirthDate = Convert.ToDateTime(Request.Form["MyBirthDate"]);

            age = AgeCalculator.HowOldAmI(currentDate, myBirthDate);

        }
    }
}
