using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSobrecargasOpSlack
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta = new Tinta();/*black,comun*/
            Tinta tinta1 = new Tinta();/*black,comun*/
            Tinta tinta2 = new Tinta(ConsoleColor.Green, ETipoTinta.China);/*green,china*/

            Pluma pluma = new Pluma();/*sinmarca,null,1*/ /*COMO ES NULL LAS COMPARACIONES FALLAN porque no puede acceder*/

            Pluma pluma1 = new Pluma("pilot", tinta2, 4);/*pilot,green y china,4*/
            Pluma pluma3 = new Pluma("castell", tinta, 2);/*castell,black y comun, 5*/

            Pluma suma = new Pluma();
            Pluma resta = new Pluma();

            Console.WriteLine((string)pluma1);
            Console.WriteLine((string)pluma3);

            //if(pluma==tinta)/*no*/
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            if (pluma3 == tinta)/*yes*/
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            if (pluma1 == tinta2)/*yes*/
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            if (pluma3 == tinta2)/*no*/
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            if (tinta == tinta2)/*no*/
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            if (tinta == tinta1)/*yes*/
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            suma =pluma1 + tinta2;
            Console.WriteLine((string)suma);/*5*/
            suma = pluma1 + tinta1;
            Console.WriteLine((string)suma);/*4*/
            resta = pluma1 - tinta2;
            Console.WriteLine((string)resta);/*5*/
            resta = pluma1 - tinta1;
            Console.WriteLine((string)resta);/*4*/



            Console.ReadKey();
        }
    }
}
