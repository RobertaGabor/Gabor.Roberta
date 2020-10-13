using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPracticaPP
{
    public class Gato: Mascota
    {
        public Gato(string nombre, string raza)
            : base(nombre, raza)
        {
        }

        protected override string Ficha()
        {
            return "Gato - " + base.DatosCompletos();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
     
            return (Mascota)g1==(Mascota)g2;
  
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool rtn = false;
            if (obj is Gato)/*casteo con la clase que estoy parada*/
            {
                rtn = this == (Gato)obj;
            }

            return rtn;
        }

    }
}
