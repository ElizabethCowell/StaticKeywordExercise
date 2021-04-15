using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordExercise
{
    class TempConverter
    {
        public static double FahrenheitToCelsius(double temp1)
        {
            var celsius = (temp1 - 32) * .5556;
            return celsius;
        }

        public static double CelsiusToFahrenheit(double temp2)
        {
            var fahrenheit = temp2 * 1.8 + 32;
            return fahrenheit;
        }
    }
}
