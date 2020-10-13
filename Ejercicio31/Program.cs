using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEjercicio31;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente uno = new Cliente(123);
            Cliente unoFail = new Cliente(123,"Julia");
            Cliente dos = new Cliente(125,"Luis");
            Cliente tres = new Cliente(126,"Soria");


            if(uno==unoFail)// igual
            {
                Console.WriteLine("Iguales");
            }
            else
            {
                Console.WriteLine("Desiguales");
            }

            if (uno == tres)// no igual
            {
                Console.WriteLine("Iguales");
            }
            else
            {
                Console.WriteLine("Desiguales");
            }

            Negocio tienda = new Negocio("pepitos");

            if(tienda + uno)
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (tienda + dos)
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (tienda + tres)
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if (tienda + unoFail)//no se puede agregar
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            if(tienda==uno)
            {
                Console.WriteLine("Está");
            }
            else
            {
                Console.WriteLine("No Está");
            }

            if(~tienda)
            {
                Console.WriteLine($"Atendido cliente {uno.Numero}");
            }
            if (~tienda)
            {
                Console.WriteLine($"Atendido cliente {dos.Numero}");
            }
            if (~tienda)
            {
                Console.WriteLine($"Atendido cliente {tres.Numero}");
            }



            Console.ReadKey();
        }
    }
}
