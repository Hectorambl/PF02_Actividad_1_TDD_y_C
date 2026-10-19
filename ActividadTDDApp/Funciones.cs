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

        public static bool EsContrasenyaValida(string contrasenya)
        {
            if (contrasenya == null)
                return false;

            if (contrasenya == "")
                return false;

            if (contrasenya.Length < 8)
                return false;

            if (!contrasenya.Contains('_'))
                return false;

            return true;
        }
    }
}
