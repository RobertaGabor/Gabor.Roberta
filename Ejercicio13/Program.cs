using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(double). Convierte un número de entero a binario.
double BinarioDecimal(string). Convierte un número binario a entero*/
namespace Ejercicio13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";
            string numeroEnBinario;
            double numeroEnDecimal;

            numeroEnBinario = Conversor.DecimalBinario(63.87);/*decimal de dos digitos*/
            Console.WriteLine("El numero en binario es: {0}", numeroEnBinario);

            numeroEnDecimal = Conversor.BinarioDecimal("111111.1101111");
            Console.WriteLine("El numero en decimal es: {0}", numeroEnDecimal);

            Console.ReadKey(true);
        }
    }
}
