using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/
namespace Ejercicio14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";
            Double areaCirculo;
            Double areaCuadrado;
            Double areaTriangulo;

            areaCirculo = CalculoDeArea.CalcularCirculo(2);
            areaCuadrado = CalculoDeArea.CalcularCuadrado(6);
            areaTriangulo = CalculoDeArea.CalcularTriangulo(4, 3);

            Console.WriteLine("area de circulo: {0:##,###.00}, area de triangulo: {1:##,###.00}, area de cuadrado: {2:##,###.00}", areaCirculo, areaTriangulo, areaCuadrado);


            Console.ReadKey(true);
        }
    }
}
