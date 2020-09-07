using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*15. Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
operación que desea realizar (pulsando el caracter +, -, * ó /).
El usuario decidirá cuándo finalizar el programa.
Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
operación matemática. El método devolverá el resultado de la operación.
b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
TRUE si el número es distinto de CERO.*/

namespace Ejercicio15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";

            Int32 numero1;
            Int32 numero2;
            char operacion;
            char seguir = 's';
            Double resultado;

            while(seguir=='s')
            {
                Console.WriteLine("Escriba la operacion(+,-,/,*) que desee: ");
                operacion = char.Parse(Console.ReadLine());
                Console.WriteLine("A {0} B = ", operacion);

                Console.WriteLine("Escriba el valor de A: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba el valor de B: ");
                numero2 = int.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(numero1, numero2, operacion);
                Console.WriteLine("{0} {1} {2} = {3:##,###.00}", numero1, operacion, numero2,resultado);

                Console.WriteLine("Desea calcular otra cosa? s/n: ");
                seguir = char.Parse(Console.ReadLine());
            }

            Console.ReadKey(true);
        }
    }
}
