using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace pruebaGeometria
{
    class Ejercicio_18
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 18";

            Punto verUno = new Punto(4, 3);
            Punto verTres = new Punto(7, 2);
            Rectangulo rectanguloUno = new Rectangulo(verUno, verTres);
            rectanguloUno.Mostrar();


            Punto verDos = new Punto(12, 9);
            Punto verCuatro = new Punto(3, 1);
            Rectangulo rectanguloDos = new Rectangulo(verDos, verCuatro);
            rectanguloDos.Mostrar();

            Console.ReadKey(true);
        }
    }
}
