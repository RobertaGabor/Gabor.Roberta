using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Ejercicio_19
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 19";

            Sumador sumaUno = new Sumador(12);
            Sumador sumaDos = new Sumador();
            string example;
            long exampleLong;
            long sumaSobrecarga;
            bool igualdadSobrecarga;

            sumaDos.Mostrar();
            sumaUno.Mostrar();


            example=sumaUno.Sumar("2", "3");
            exampleLong=sumaUno.Sumar(2, 3);

            Console.WriteLine("string: {0} int: {1}", example, exampleLong);

            sumaUno = (Sumador)9;
            Console.WriteLine("*************");
            sumaUno.Mostrar();
            
            sumaSobrecarga = sumaUno + sumaDos;
            igualdadSobrecarga = sumaUno | sumaDos;
            Console.WriteLine("suma: {0}, igualdad: {1}", sumaSobrecarga, igualdadSobrecarga);
            
            sumaDos = (Sumador)9;

            sumaSobrecarga = sumaUno + sumaDos;
            igualdadSobrecarga = sumaUno | sumaDos;
            Console.WriteLine("suma: {0}, igualdad: {1}", sumaSobrecarga, igualdadSobrecarga);

            Console.ReadKey(true);
        }
    }
}
