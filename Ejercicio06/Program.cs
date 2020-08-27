using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/
namespace Ejercicio06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            Int32 minimo;
            Int32 maximo;
            Console.Write("Años bisiestos ");
            Console.Write("desde: ");
            minimo = int.Parse(Console.ReadLine());
            Console.Write("hasta: ");
            maximo = int.Parse(Console.ReadLine());

            if(minimo>=1100&&maximo<=2020&&minimo<maximo)
            {
                for(;minimo<=maximo;minimo++)
                {
                    if(minimo%4==0)
                    {
                        if(minimo%100==0)
                        {
                            if(minimo%400==0)
                            {
                                Console.WriteLine("{0}", minimo);
                            }
                        }
                        else
                        {
                            Console.WriteLine("{0}", minimo);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Años invalidos debe ser desde 1100 hasta 2020");
            }

            Console.ReadKey(true);
        }
    }
}
