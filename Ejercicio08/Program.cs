using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
trabajadas en el mes de N empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace Ejercicio08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";
            string nombres="       ";
            string preciohora=" ";
            string anios="   ";
            string cantHoras="";
            string totalBrutos="  ";
            string totalNetos="   ";
            string totalDescuentos="    ";
            Int32 auxPrecio;
            Int32 auxCant;
            Int32 auxBruto;
            Int32 auxAnios;
            Int32 auxExtraAntig;
            Int32 auxDescuento;
            Int32 auxNeto;

            int seguir = 1;

            do
            {
                Console.WriteLine("Ingrese nombre del empleado:");               
                nombres += Console.ReadLine();
                nombres += "  ";

                Console.WriteLine("Ingrese el valor x hora de trabajo del empleado:");
                auxPrecio = int.Parse(Console.ReadLine());             
                preciohora += auxPrecio; 
                preciohora += "    ";

                Console.WriteLine("Ingrese anios de antiguedad:");
                auxAnios = int.Parse(Console.ReadLine());             
                anios += auxAnios;
                anios += "      ";

                Console.WriteLine("Ingrese cantidad de horas trabajadas en el mes:");
                auxCant = int.Parse(Console.ReadLine());              
                cantHoras += auxCant;
                cantHoras += " ";

                auxExtraAntig = 150 * auxAnios;

                auxBruto = (auxCant * auxPrecio)+auxExtraAntig;
                
                
                totalBrutos += (auxBruto);
                totalBrutos += "  ";

               auxDescuento =auxBruto * 13 / 100;
                
                totalDescuentos += (auxDescuento);
                totalDescuentos += "   ";

                auxNeto = auxBruto - auxDescuento;
                
                totalNetos += (auxNeto);
                totalNetos += "   ";

                Console.WriteLine("¿Desea seguir agregando empleados? ingrese 1 para continuar sino ingrese otra cosa y mostrara en pantalla el listado de empleados:");
                seguir = int.Parse(Console.ReadLine());
            } while (seguir == 1);

            Console.WriteLine("nombre:{0}\nantiguedad:{1}\nvalor x hora:{2}\ntotal bruto:{3}\ndescuento:{4}\ntotal neto:{5}", nombres, anios, preciohora, totalBrutos,totalDescuentos,totalNetos);
            /*Console.WriteLine("Escriba otro nombre:");
            string newName = Console.ReadLine();
            
            names += " ";
            names += newName;

            Console.WriteLine("{0}", names);*/

            Console.ReadKey(true);
        }
    }
}
