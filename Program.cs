using System;

namespace StaticKeywordExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.FahrenheitToCelsius(72));
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(32));
        }
    }
}
