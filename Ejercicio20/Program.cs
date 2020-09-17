using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Ejercicio_20
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 20";
            
            Dolar dolaruco = new Dolar(34);
            Peso pesucos = new Peso(250, 38.33);
            Euro eurucos = new Euro(42, 1.16);
            
            /*cotizaciones hechas*/
            Peso pesito = new Peso();
            Euro eurito = new Euro();

            eurito = (Euro)dolaruco;
            double euritoUno=eurito.GetCantidad();
            Console.WriteLine(euritoUno);

            Console.ReadKey(true);
        }
    }
}
