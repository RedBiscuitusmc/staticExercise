using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public  class TempConverter
    {
        public TempConverter()
        {

        }
        public static double FahrenheitToCelcius(Double ferinTemp)
        {
            var Celsius = (ferinTemp - 32) / 1.8;
            return Math.Round(Celsius, 2);
        }
        public static double CelciusToFahrenheit(Double celinTemp)
        {
            var Fahrenheit = (celinTemp * 1.8) + 32;
            return Fahrenheit;
        }
    }
}
