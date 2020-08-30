using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*12. Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor*/
namespace Ejercicio12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";
            Int32 numero;
            Int32 suma=0;
            Char seguir;

            do
            {
                Console.WriteLine("Escriba un numero entero:");
                numero = int.Parse(Console.ReadLine());

                suma += numero;

                Console.WriteLine("¿Continuar? (S/N)");
                seguir = (Convert.ToChar(Console.ReadLine()));

            } while (ValidarRespuesta.ValidaS_N(seguir) == true);

            Console.WriteLine("La suma total es {0}", suma);
            Console.ReadKey(true);
        }
    }
}
