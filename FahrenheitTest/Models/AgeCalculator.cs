using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FahrenheitTest.Models
{
    public class AgeCalculator
    {
        public static int HowOldAmI(DateTime calculateDate, DateTime myBirthDate)
        {
            int age;
            age = calculateDate.Year - myBirthDate.Year;

            if (myBirthDate.Date > calculateDate.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
