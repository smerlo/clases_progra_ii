using System;

namespace Biblioteca
{
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;
        /// <summary>
        /// Convierte una temeperatura en grados celsius a grados kelvin.
        /// </summary>
        /// <param name="temperaturaCelsius">Temperatura en grados celsius a convertir</param>
        /// <returns>La temperatura en grados kelvin correspondiente al argumento proporsionado</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;
            return temperaturaKelvin;
        }

        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            float temperaturaCelsius = temperaturaKelvin - ceroAbsoluto;
            return temperaturaCelsius;
        }
    }
}
