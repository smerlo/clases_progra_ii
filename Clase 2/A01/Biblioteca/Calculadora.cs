using System;

namespace Biblioteca
{
    public class Calculadora
    {
        /// <summary>
        /// Recibe un numero entero positivo y devuelve su factorial
        /// </summary>
        /// <param name="numeroIngresado">Numero entero positivo a calcular su factorial</param>
        /// <returns>Retorna el factorial del numero ingresado</returns>
        public static int CalcularFactorial(int numeroIngresado)
        {
            int factorial = 1;
            for (int i = 1; i <= numeroIngresado; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
