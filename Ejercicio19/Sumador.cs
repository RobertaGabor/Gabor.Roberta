using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    public class Sumador/*tiene que ser publica*/
    {
        private int cantidadSumas;

        /*constructores*/

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() 
        {
            Sumador x = new Sumador(0);
            this.cantidadSumas = x.cantidadSumas;
        }

        /*sobrecargas*/

        public long Sumar(long a,long b)
        {
            this.cantidadSumas += 1;
            return a + b;
        }

        public string Sumar(string a,string b)
        {
            this.cantidadSumas += 1;
            return a + b;
        }

        public void Mostrar ()
        {
            Console.WriteLine(this.cantidadSumas);
        }

        /*casteos*/
        public static explicit operator Sumador(int y)
        {
            Sumador x = new Sumador();
            x.cantidadSumas = y;
            return x;
        }

        /*sobrecargas de op*/
        public static long operator +(Sumador x, Sumador y)
        {
            return x.cantidadSumas+y.cantidadSumas;
        }
        public static bool operator |(Sumador x,Sumador y)
        {
            if(x.cantidadSumas==y.cantidadSumas)
            {
                return true;
            }
            return false;
        }



    }
}
