﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
usuario ingrese por consola.
Nota: Utilizar estructuras repetitivas y selectivas.
*/
namespace Ejercicio05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";

            Int32 numeroBuffer;
            Int32 anterioresSuma;
            Int32 siguientesSuma;
            Int32 sumaTotalPosterior;
            Int32 flag=0;

            Console.WriteLine("Escriba un numero:");
            numeroBuffer = int.Parse(Console.ReadLine());

            Console.WriteLine("Los numero centricos son:");

            for (int i = 2; i < numeroBuffer; i++)
            {
                siguientesSuma = i+1;
                anterioresSuma = 0;
                sumaTotalPosterior = 0;

                for (int y=i-1;y>0;y--)
                {
                    anterioresSuma += y;
                }

                while (sumaTotalPosterior <= anterioresSuma)
                {

                    sumaTotalPosterior += siguientesSuma;
                    if (sumaTotalPosterior == anterioresSuma)
                    {
                        Console.WriteLine("{0}", i);
                        flag = 1;

                    }
                    siguientesSuma = siguientesSuma + 1;

                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Sin numeros centricos");
            }

            Console.ReadKey(true);
        }
    }
}
