using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        /*atributos*/
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;
        /*constructor*/
        public void ConstructorPublico(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        /*metodos*/
        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            if (this.nota1>=4&&this.nota2>=4)
            {
                Random rand = new Random(DateTime.Now.Millisecond);
                this.notaFinal = rand.Next(1,10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Mostrar()
        {
            string final;
            if(this.notaFinal==-1)
            {
                final = "Alumno desaprobado";
            }
            else {
                final = Convert.ToString(notaFinal);
            
            }
            Console.WriteLine("nombre: {0} - apellido: {1}- legajo: {2} - nota 1: {3} - nota 2: {4} - nota final: {5}", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2,final);
        }
    }
}
