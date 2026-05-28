using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConverter
{
    static class TemperatureConverter
    {
        public static decimal F;
        public static decimal C;
        public static void CelsiusToFahrenheit(decimal celsius)
        {

            F = celsius * 9 / 5 + 32;

        }
        public static void FahrenheitToCelsius(decimal fahrenheit)
        {

            C = (fahrenheit - 32) * 5 / 9;

        }

    }
}

