using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador uno = new Jugador(123, "juan", 20, 3);
            Jugador dos = new Jugador(245, "juan",24,5);
            Jugador tres = new Jugador(123, "Lucia", 30, 3);

            Console.WriteLine(uno.MostrarDatos());
            Console.WriteLine(dos.MostrarDatos());
            Console.WriteLine(tres.MostrarDatos());

            Equipo eUno = new Equipo(3,"Denver");
            if(eUno+uno)
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se pudo");
            }

            if (eUno + dos)
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se pudo");
            }
            
            if (eUno + tres)
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se pudo");
            }

            if (eUno + dos)
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se pudo");
            }

           


            Console.ReadKey();
        }
    }
}
