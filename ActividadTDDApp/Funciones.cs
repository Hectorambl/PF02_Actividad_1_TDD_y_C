using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {

        private const long ERROR_FACTORIAL = -1;
        public static long CalcularFactorial(int number)
        {
            if (number < 0)
                return ERROR_FACTORIAL;

            long resultado = 1;
            for (int i = 2; i <= number; i++)
                resultado *= i;

            return resultado;
        }
    }
}
