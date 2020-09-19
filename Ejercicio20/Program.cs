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
            Dolar dolarcito = new Dolar();
            Peso pesoDouble = new Peso();

            /*dolar a euro*/
            eurito = (Euro)dolaruco;
            double euritoUno=eurito.GetCantidad();
            Console.WriteLine(euritoUno);
            /*dolar a peso*/
            pesito = (Peso)dolaruco;
            double pesoUno = pesito.GetCantidad();
            Console.WriteLine(pesoUno);
            /*Peso a dolar*/
            dolarcito = (Dolar)pesucos;
            double dolarUno = dolarcito.GetCantidad();
            Console.WriteLine(dolarUno);
            /*peso a euro*/
            eurito = (Euro)pesucos;
            euritoUno = eurito.GetCantidad();
            Console.WriteLine(euritoUno);
            /*euro a peso*/
            pesito = (Peso)eurucos;
            pesoUno = pesito.GetCantidad();
            Console.WriteLine(pesoUno);
            /*euro a dolar*/
            dolarcito = (Dolar)eurucos;
            dolarUno = dolarcito.GetCantidad();
            Console.WriteLine(dolarUno);

            /*double a peso*/
            pesoDouble = (Peso)88;
            Console.WriteLine(pesoDouble.GetCantidad());


            
            
            Dolar original = new Dolar(1);
            Euro igual = new Euro(1.16);
            Peso igual2 = new Peso(38.33);

            /*SOBRECARGAS DOLARES*/
            /*igualdad de dolar y euro*/
            if (original==igual)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            /*igualdad de dolar y peso*/
            
            if (original == igual2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            /*igualdad de dolar y dolar*/
            Dolar igual3 = new Dolar(1);
            if (original == igual3)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            /*suma y resta dolares*/
            Dolar suma = new Dolar();
            suma = original + igual;
            Console.WriteLine(suma.GetCantidad());
            suma = original + igual2;
            Console.WriteLine(suma.GetCantidad());
            suma = original - igual;
            Console.WriteLine(suma.GetCantidad());
            suma = original - igual2;
            Console.WriteLine(suma.GetCantidad());
            
            Console.WriteLine("**********************************************************");

            /*SOBRECARGAS EUROS*/
            /*igualdad de euro y dolar*/
            if (igual == original)
            {
                Console.WriteLine("Yes Dos");
            }
            else
            {
                Console.WriteLine("No");
            }
            /*igualdad de euro y peso*/

            if (igual == igual2)
            {
                Console.WriteLine("Yes Dos");
            }
            else
            {
                Console.WriteLine("No");
            }
            /*igualdad de euro y euro*/
            Euro igual4 = new Euro(1.16);
            if (igual == igual4)
            {
                Console.WriteLine("Yes Dos");
            }
            else
            {
                Console.WriteLine("No");
            }
            /*suma y resta dolares*/
            Euro suma2 = new Euro();
            suma2 = igual + original;
            Console.WriteLine(suma2.GetCantidad());
            suma2 = igual + igual2;
            Console.WriteLine(suma2.GetCantidad());
            suma2 = igual - original;
            Console.WriteLine(suma2.GetCantidad());
            suma2 = igual - igual2; ;
            Console.WriteLine(suma2.GetCantidad());

            Console.WriteLine("**********************************************************");

            /*SOBRECARGAS PESOS*/
            /*igualdad de pesos y dolar*/
            if (igual2 == original)
            {
                Console.WriteLine("Yes Tres");
            }
            else
            {
                Console.WriteLine("No");
            }
            /*igualdad de pesos y euro*/

            if (igual2 == igual)
            {
                Console.WriteLine("Yes Tres");
            }
            else
            {
                Console.WriteLine("No");
            }
            /*igualdad de pesos y pesos*/
            Peso igual5 = new Peso(38.33);
            if (igual2 == igual5)
            {
                Console.WriteLine("Yes Tres");
            }
            else
            {
                Console.WriteLine("No");
            }
            /*suma y resta pesos*/
            Peso suma3 = new Peso();
            suma3 = igual2 + original;
            Console.WriteLine(suma3.GetCantidad());
            suma3 = igual2 + igual;
            Console.WriteLine(suma3.GetCantidad());
            suma3 = igual2 - original;
            Console.WriteLine(suma3.GetCantidad());
            suma3 = igual2 - igual; ;
            Console.WriteLine(suma3.GetCantidad());



            Console.ReadKey(true);
        }
    }
}
