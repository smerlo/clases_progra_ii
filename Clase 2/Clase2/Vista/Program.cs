using Biblioteca;
using System;

namespace Vista
{
    class Program
    {
        private static float temperaturaCelsius;
        private static float temperaturaKelvin;
        static void Main(string[] args)
        {
            temperaturaCelsius = 30;
            temperaturaKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelsius);
            MostrarTemperaturas();
        }

        static void MostrarTemperaturas()
        {
            Console.WriteLine("Temperatura Kelvin: {0}", temperaturaKelvin);
            Console.WriteLine("Temperatura Celsius: {0}", temperaturaCelsius);
        }
    }
}
