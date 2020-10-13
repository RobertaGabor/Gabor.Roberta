using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPracticaPP
{
    public class Perro: Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza)
            :this(nombre,raza,0,false)
        {
        }
        
        public Perro(string nombre, string raza, int edad, bool alfa)/*SI LO HAGO AL REVES PUEDO REUTILIZAR*/
            : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = alfa;
        }

        protected override string Ficha()
        {
            
            if(this.esAlfa==true)
            {
                return "Perro - " + base.DatosCompletos() + ", alfa de la manada, edad " + this.edad;
            }
            return "Perro - " + base.DatosCompletos() + ", edad " + this.edad;
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return (Mascota)p1 == (Mascota)p2 && p1.edad == p2.edad;/*DEVUELVE YA LO QUE DEVUELVE LA FUNCION*/
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro p)
        {
            return p.edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool rtn = false;
            if(obj is Perro)/*casteo con la clase que estoy parada*/
            {
                rtn = this == (Perro)obj;
            }

            return rtn;
        }



    }
}
