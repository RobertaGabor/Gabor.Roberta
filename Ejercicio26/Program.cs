using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de
cero de forma aleatoria utilizando la clase Random.
a. Mostrar el vector tal como fue ingresado
b. Luego mostrar los positivos ordenados en forma decreciente.
c. Por último, mostrar los negativos ordenados en forma creciente*/
namespace Ejercicio26
{
    class Ejercicio_26
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 26";
            int[] numero = new int[20];
            Random rdm = new Random();

            for(int i=0;i<numero.Length;i++)
            {
                numero[i] = rdm.Next(-10000,10000);
            }

            Console.WriteLine(Mostrar(numero));

            Console.WriteLine("************************");

            Console.WriteLine(Mostrar(MostrarOrden(numero,true)));

            Console.WriteLine("************************");

            Console.WriteLine(Mostrar(MostrarOrden(numero,false)));


            Console.ReadKey();
        }

        private static string Mostrar(int[]x)
        {
            StringBuilder novo = new StringBuilder();
            foreach (int i in x)
            {

               novo.AppendLine(i.ToString());
             

            }
            return novo.ToString();
        }
        /// <summary>
        /// ordena
        /// </summary>
        /// <param name="x">array de numeros</param>
        /// <param name="z">true si ordenamos positivos o false si ordenamos negativos</param>
        /// <returns></returns>
        private static int[] MostrarOrden(int[]x,bool z)
        {
            List<int> ordenado = new List<int>(); 
            
            for (int i = 0; i < x.Length; i++)
            {
                if(z==true)
                {
                    if(x[i]>=0)
                    {
                        ordenado.Add(x[i]);
                    }
                }
                else if(z==false)
                {
                    if (x[i] < 0)
                    {
                        ordenado.Add(x[i]);
                    }
                }

            }
            int[] array = new int[ordenado.Count];
            array = ordenado.ToArray();
            Array.Sort(array);
            Array.Reverse(array);

            return array;

        }

    }
}
