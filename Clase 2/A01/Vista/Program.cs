using Biblioteca;
using System;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            int factorial = 0;
            bool ingresoValorCorrecto = false;
            Console.WriteLine("Ingrese un número positivo mayor a 0");
            while(!ingresoValorCorrecto)
            {
                if(int.TryParse(Console.ReadLine(),out numeroIngresado))
                {
                    if(numeroIngresado > 0)
                    {
                       factorial = Calculadora.CalcularFactorial(numeroIngresado);
                        ingresoValorCorrecto = true;
                    }
                    else
                    {
                        Console.WriteLine("Error. El número debe ser mayor a 0");
                    }    
                }
                else
                {
                    Console.WriteLine("Error. Solo se pueden ingresar números");
                }
            }
            Console.WriteLine($"El factorial de {numeroIngresado} es {factorial}");
        }
    }
}
