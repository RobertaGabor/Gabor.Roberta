using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*16)crear clase alumno. 
 a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
nombre, apellido y legajo a cada uno de ellos.
b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
el método de instancia Next de la clase Random.
d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
desaprobado"*/
namespace Ejercicio16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();


            alumno1.ConstructorPublico("juan", "perez", 1000);
            alumno2.ConstructorPublico("sofia", "lopez", 1001);
            alumno3.ConstructorPublico("paula", "pitufa", 1002);

            alumno1.Estudiar(2, 1);
            alumno2.Estudiar(4, 4);
            alumno3.Estudiar(8, 9);


            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();


            alumno1.Mostrar();
            alumno2.Mostrar();
            alumno3.Mostrar();

                

                Console.ReadKey(true);
        }
    }
}
