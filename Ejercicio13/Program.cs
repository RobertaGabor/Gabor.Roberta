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

            numeroEnBinario = Conversor.DecimalBinario(10.23);
            Console.WriteLine("El numero en binario es: {0}", numeroEnBinario);

            Console.ReadKey(true);
        }
    }
}
