using System;

namespace Biblioteca
{
    public class Validador
    {
        /// <summary>
        /// Valida que el numero entero recibido se encuentre entre los rangos seteados
        /// </summary>
        /// <param name="valor">Valor ingresado por el usuario</param>
        /// <param name="min">Valor minimo que puede tener el numero ingresado</param>
        /// <param name="max">Valor maximo que puede tener el numero ingresado</param>
        /// <returns>Retorna true si el valor cumple con los criterios. False si no los cumple</returns>
        public static bool Validar(int valor, int min, int max)
        {
            if(valor >= min && valor <= max)
            {
                return true;
            }
            return false;
        }
    }
}
