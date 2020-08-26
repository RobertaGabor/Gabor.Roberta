using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/

namespace Ejercicio02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            Console.WriteLine("Ingrese un numero:");
            Int32 num = int.Parse(Console.ReadLine());
            Double numCuadrado = Math.Pow(num, 2);
            Double numCubo = Math.Pow(num, 3);

            if(num>0)
            {
                Console.WriteLine("El cuadrado de {0:#,###.00} es {1:#,###.00} y su cubo es {2:#,###.00}", num, numCuadrado, numCubo);
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

            Console.ReadKey(true);
        }
    }
}
