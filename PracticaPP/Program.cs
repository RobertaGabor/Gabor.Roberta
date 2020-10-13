using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesPracticaPP;

namespace PracticaPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perroUno = new Perro("Moro", "Pitbull"); 
            Perro perroDos = new Perro("Julio", "Cruza", 13, false); 
            Perro perroTres = new Perro("Ramón", "Salchicha", 2, true); 
            Perro perroCuatro = new Perro("José", "Angora", 2, false); 
            Perro perroCinco = new Perro("Ramón", "Salchicha", 2, false); 
            
            Gato gatoUno = new Gato("José", "Angora"); 
            Gato gatoDos = new Gato("Mauri", "Cruza"); 
            Gato gatoTres = new Gato("Fer", "Siamés"); 
            Gato gatoCuatro = new Gato("Fer", "Siamés"); 
            
            Console.WriteLine(); 
            
            Grupo grupoUno = new Grupo("Río", EtipoManada.Mixta);

            grupoUno += perroUno; 
            grupoUno += perroDos; 
            grupoUno += perroTres; 
            grupoUno += perroCuatro;//repetidos
            grupoUno += perroCinco;                        
            grupoUno += perroUno;            
            grupoUno += gatoUno;            
            grupoUno += gatoDos;            
            grupoUno += gatoTres;//repetido            
            grupoUno += gatoCuatro;            
            
            Console.WriteLine();//Cantidad 7 (4 perros - 3 gatos)            
            Console.WriteLine(grupoUno);              
            
            grupoUno -= perroUno;            
            grupoUno -= perroTres;                      
            grupoUno -= gatoTres;//no están            
            grupoUno -= perroCinco;            
            grupoUno -= gatoTres;            
            grupoUno -= gatoCuatro;            
            
            Console.WriteLine();//Cantidad 4 (2 perros - 2 gatos)            
            Console.WriteLine(grupoUno);

            if (perroUno.Equals("perroUno"))//son distintos
            {
                Console.WriteLine("Son la misma mascota");
            }
            else
            {
                Console.WriteLine("No son la misma mascota");
            }
                
            if (perroTres.Equals(perroCinco))//son iguales  
            {
                Console.WriteLine("Son la misma mascota");
            }      
            else
            {
                Console.WriteLine("No son la misma mascota");   
            }
                                 
                
                
                
                
                
                Console.ReadLine();
            }
    }
}
