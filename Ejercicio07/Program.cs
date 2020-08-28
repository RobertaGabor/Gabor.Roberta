using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

/*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos*/

namespace Ejercicio07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";
            Int32 anio;
            Int32 mes;
            Int32 dia;
            Int64 totalDias;

            Console.WriteLine("Dia de nacimiento[01/]: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes de nacimiento[/02/]: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Año de nacimiento[/1998]: ");
            anio = int.Parse(Console.ReadLine());
            
            DateTime birth = new DateTime(anio, mes, dia,0,0,0);
            DateTime now = DateTime.Now;

            TimeSpan diferencia = now-birth;
            totalDias = (int)diferencia.TotalDays;/*paso de double a int asi no redondea*/
            
            Console.WriteLine("{0}", birth);
            Console.WriteLine("{0}", now);
            Console.WriteLine("diferencia de dias: {0:##,###.00}", totalDias);

            Console.ReadKey(true);
        }
    }
}
