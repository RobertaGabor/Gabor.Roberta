using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*9. Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***
*****
*******
*********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
ejemplo anterior la altura ingresada fue de 5.
Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace Ejercicio09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";
            Int32 numero;
            Int32 aux=0;
            Console.WriteLine("Escriba altura de piramide: ej 5");
            numero = int.Parse(Console.ReadLine());

            for(int i=0;i<numero;i++)
            {
                for(int y=aux+1;y>0;y--)
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
