using Biblioteca;
using System;

namespace Vista
{
    class Program
    {
        private const int numeroMinimoPosible = -100;
        private const int numeroMaximoPosible = 100;
        static void Main(string[] args)
        {
            int cantidadNumerosIngresados = 0;
            int numeroIngresado;
            int minimoIngresado = int.MaxValue;
            int maximoIngresado = int.MinValue;
            int suma = 0;
            bool esNumero = false;
            while (cantidadNumerosIngresados < 10)
            {

                Console.WriteLine("Ingrese un número entero entre {0} y {1}.({2}/10)", numeroMaximoPosible, numeroMinimoPosible, cantidadNumerosIngresados + 1);
                esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (esNumero)
                {
                    if (Validador.Validar(numeroIngresado, numeroMinimoPosible, numeroMaximoPosible))
                    {
                        suma += numeroIngresado;
                        if (numeroIngresado > maximoIngresado)
                        {
                            maximoIngresado = numeroIngresado;
                        }
                        if (numeroIngresado < minimoIngresado)
                        {
                            minimoIngresado = numeroIngresado;
                        }
                        cantidadNumerosIngresados++;
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado se encuentra fuera de rango. Reingrese");
                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un número. Reingrese");
                }
            }
            Console.WriteLine("El minimo ingresado es {0}, el máximo es {1} y el promedio es {2}", minimoIngresado, maximoIngresado, suma / 10);
        }
    }
}
