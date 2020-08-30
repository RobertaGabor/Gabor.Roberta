using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*10. Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
una pirámide como la siguiente:
    *
   ***
  *****
 *******
*********
Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace Ejercicio10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";
            Int32 numero;
            Int32 aux = 0;
            Console.WriteLine("Escriba altura de piramide: ej 5");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                for (int z = numero - i; z >= 0; z--)
                {
                    Console.Write(" ");
                }
                for (int y = aux + 1; y > 0; y--)
                {
                    Console.Write("*");
                }
                aux += 2;
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
