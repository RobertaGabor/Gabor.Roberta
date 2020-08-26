using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
valor máximo, el valor mínimo y el promedio.*/

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            Console.WriteLine("Ingrese 5 numeros apretando enter luego de cada uno:");
            Int32 var1 = int.Parse(Console.ReadLine());
            Int32 var2 = int.Parse(Console.ReadLine());
            Int32 var3 = int.Parse(Console.ReadLine());
            Int32 var4 = int.Parse(Console.ReadLine());
            Int32 var5 = int.Parse(Console.ReadLine());

            Int32 varMaximo;
            Int32 varMinimo;
            Single promedio;

            if(var1>var2&&var1>var3&&var1>var4&&var1>var5)
            {
                varMaximo = var1;
            }
            else if(var2>var3&&var2>var4&&var2>var5)
            {
                varMaximo = var2;
            }
            else if(var3>var4&&var3>var5)
            {
                varMaximo = var3;
            }
            else if(var4>var5)
            {
                varMaximo = var4;
            }
            else 
            {
                varMaximo = var5;
            }


            if (var1 < var2 && var1 < var3 && var1 < var4 && var1 < var5)
            {
                varMinimo = var1;
            }
            else if (var2 < var3 && var2 < var4 && var2 < var5)
            {
                varMinimo = var2;
            }
            else if (var3 < var4 && var3 < var5)
            {
                varMinimo = var3;
            }
            else if (var4 < var5)
            {
                varMinimo = var4;
            }
            else
            {
                varMinimo = var5;
            }

            promedio = (Single)(var1 + var2 + var3 + var4 + var5) / 5;
            Console.WriteLine("El maximo es {0,-7:#,###.00}, el minimo es {1,-7:#,###.00}, y el promedio es {2,-7:#,###.00}", varMaximo,varMinimo,promedio);
            Console.ReadKey(true);
        }
    }
}
