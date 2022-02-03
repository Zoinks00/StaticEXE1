using System;

namespace StaticEXE1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var fahCon = TempConverter.FahrenheitToCelsius(90);
            var celCon = TempConverter.CelsiusToFahrenheit(30);

            //0:0.0 formats output to display 1 place right of decimal
            Console.WriteLine($"Fahrenhit to Celsius {fahCon, 0:0.0}");
            Console.WriteLine($"Celsius to Fahrenhit {celCon, 0:0.0}");
            
        }
    }
}
