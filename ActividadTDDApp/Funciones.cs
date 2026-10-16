using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {
        public static long CalcularFactorial(int number)
        {
            if (number < 0)
                return -1;

            if (number == 0 || number == 1)
                return 1;

            long resultado = 1;
            for (int i = 2; i <= number; i++)
                resultado *= i;

            return resultado;
        }
    }
}
