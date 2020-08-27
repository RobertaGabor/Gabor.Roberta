using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas y selectivas*/
namespace Ejercicio04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio Nro 04";
            Int32 suma;
            Int32 combinaciones = 0;
            Int32 numeroActual;
            Int32 anterior;

              for(numeroActual=2;combinaciones<4;numeroActual++)
              {
                suma = 0;
                for (anterior=numeroActual-1;anterior>0;anterior--)
                {
                        if (numeroActual % anterior == 0)
                        {
                            suma += anterior;
                        }
                }
                if(numeroActual==suma)
                {
                   Console.Write(" {0}", suma);
                   combinaciones++;
                }
              }
           Console.ReadKey(true);
        }
    }
}
