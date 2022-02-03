using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEXE1
{
   public static class TempConverter
    {
        // formula found at https://www.almanac.com/temperature-conversion-celsius-fahrenheit
        public static double FahrenheitToCelsius(double f)
    {
        double ConSum = (f -32) * .5556;
            
        return ConSum;
    }
        //convert Cel to Fah
  public static double CelsiusToFahrenheit(double c)
    {
        double ConSum = (c * 1.8) + 32;
            
        return ConSum;
    }

    }

    

  
}
