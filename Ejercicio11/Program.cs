using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*11. Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
anteriormente que esten dentro del rango -100 y 100.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores.*/

namespace Ejercicio11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            Int32 numero1;
            Int32 auxiliar;
            Int32 contador = 0;
            Int32 suma = 0;
            Single promedio;
            Int32 maximo=0;
            Int32 minimo=0;

            do
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100:");
                auxiliar = int.Parse(Console.ReadLine());

                if(Validacion.Validar(auxiliar,-100,100)==true)
                {
                    numero1 = auxiliar;
                    suma += numero1;

                    if(contador==0)
                    {
                        maximo = numero1;
                        minimo = numero1;
                    }
                    else if(numero1>maximo)
                    {
                        maximo = numero1;
                    }
                    else if(numero1<minimo)
                    {
                        minimo = numero1;
                    }

                    contador++;
                }


            } while (contador < 10);



            promedio = (float)suma / 10;

            Console.WriteLine("El numero maximo es {0:##,###.00}, el minimo es {1:##,###.00}, y el promedio es {2:##,###.00}", maximo, minimo, promedio);
            Console.ReadKey(true);
        }
    }
}
