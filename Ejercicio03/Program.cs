using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%)*/

namespace Ejercicio03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";
            
            Console.WriteLine("Ingrese un numero:");
            Int32 numero = int.Parse(Console.ReadLine());
            

            if(numero<1)
            {
                Console.WriteLine("Error. debe ser mayor a 0");
            }
            else if(numero==1)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("Los numeros primos hasta el {0} son:", numero);
                for(int i=numero-1;i>=0;i--)
                {
                    byte flag = 0;
                    for(int y=2;y<i;y++)
                    {
                        if(i%y==0)
                        {                      
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.Write(" {0}", i);
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}
