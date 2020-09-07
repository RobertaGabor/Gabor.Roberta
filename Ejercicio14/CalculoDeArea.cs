using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {

        public static double CalcularCuadrado(double lado)
        {
            return lado * lado;
        }
        public static double CalcularTriangulo(double base1, double altura)
        {
            return base1 * altura / 2;
        }
        public static double CalcularCirculo(double radio)
        {
            return radio * radio * Math.PI;
        }
    }
}
