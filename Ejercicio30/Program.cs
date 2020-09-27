using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Ejercicio_30
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio Nro 30";

            Competencia comp = new Competencia(6, 11);

            AutoF1 uno = new AutoF1(12, "besties");
            AutoF1 dos = new AutoF1(5, "besties");
            AutoF1 cuatro = new AutoF1(12, "feos");
            AutoF1 cinco = new AutoF1(12, "besties");

            Console.WriteLine(uno.MostrarDatos());
            Console.WriteLine("*******************");
            Console.WriteLine(dos.MostrarDatos());
            Console.WriteLine("*******************");
            Console.WriteLine(cuatro.MostrarDatos());
            Console.WriteLine("*******************");
            Console.WriteLine(cinco.MostrarDatos());

            if(uno==dos)/*no*/
            {
                Console.WriteLine("iguales");
            }
            else
            {
                Console.WriteLine("no iguales");
            }
            if (uno == cinco)/*si*/
            {
                Console.WriteLine("iguales");
            }
            else
            {
                Console.WriteLine("no iguales");
            }
            if (uno == cuatro)/*no*/
            {
                Console.WriteLine("iguales");
            }
            else
            {
                Console.WriteLine("no iguales");
            }

            if(comp+uno)
            {
                Console.WriteLine("se agrego");
            }
            else
            {
                Console.WriteLine("no se agrego");
            }

            if (comp + dos)
            {
                Console.WriteLine("se agrego");
            }
            else
            {
                Console.WriteLine("no se agrego");
            }


            if (comp + cuatro)
            {
                Console.WriteLine("se agrego");
            }
            else
            {
                Console.WriteLine("no se agrego");
            }

            if (comp + cinco)
            {
                Console.WriteLine("se agrego");
            }
            else
            {
                Console.WriteLine("no se agrego");
            }

            if (comp + dos)
            {
                Console.WriteLine("se agrego");
            }
            else
            {
                Console.WriteLine("no se agrego");
            }
            Console.WriteLine(comp.MostrarDatos());
            if (comp-uno)
            {
                Console.WriteLine("se elimino");
            }
            else
            {
                Console.WriteLine("no se elimino");
            }
            Console.WriteLine(comp.MostrarDatos());

            Console.ReadKey();
        }
    }
}
