using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Program
    {
        public class Libro
        {
            private List<string> paginas= new List<string>();

            /*El indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango
            correcto, sino retornará un string vacio “”. En el set, la asignará si esta ya existe. Si el índice es superior al
            máximo existente, agregará una nueva página.
            Generar el código en el Main para probar la clase.*/

            public string this[int i]
            {
                get {if (i < this.paginas.Count)
                    {
                        return this.paginas[i];
                    }
                    else
                    {
                        return "";
                    }
                }
                set {
                    if (i < this.paginas.Count)
                    {
                        this.paginas[i] = value;
                    }
                    else
                    {
                        paginas.Add(value);
                    }

                }

            }


        }
        static void Main(string[] args)
        {
            Libro book = new Libro();
            string dato = book[0];//""
            Console.WriteLine(dato);

            book[0] = "paginas dos";
            dato = book[0];
            Console.WriteLine(dato);

            Console.ReadKey();
        }
    }
}
