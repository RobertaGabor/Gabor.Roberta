using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        /// <summary>
        /// realiza una operacion entre las mostradas y si se puede deuelve el numero, sino devuelve -1111111111
        /// </summary>
        /// <param name="x">numero 1 ingresado</param>
        /// <param name="y">numero 2 ingresado</param>
        /// <param name="operacion">metodo de operacion</param>
        /// <returns></returns>
        public static Double Calcular(Int32 x, Int32 y, char operacion)
        {
            Double resultado=-111111111;

            if(operacion=='+')
            {
                resultado = x + y;
            }
            else if(operacion=='-')
            {
                resultado = x - y;
            }
            else if(operacion=='*')
            {
                resultado = x * y;
            }
            else if(operacion=='/')
            {
                if(Validar(y)==true)
                {
                    resultado = (float)x / y;
                }
            }

            return resultado;
        }

        private static bool Validar(Int32 y)
        {
            bool ok = false;
            if (y != 0)
            {
                ok = true;
            }

            return ok;
        }
    }
}
