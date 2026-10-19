using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {

        private const long ERROR_FACTORIAL = -1;
        private const int LONGITUD_MINIMA = 8;
        private const char CARACTER_OBLIGATORIO = '_';
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
            if (string.IsNullOrEmpty(contrasenya))
                return false;

            if (contrasenya.Length < LONGITUD_MINIMA)
                return false;

            if (!contrasenya.Contains(CARACTER_OBLIGATORIO))
                return false;

            return true;
        }
    }
}
