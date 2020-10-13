using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPracticaPP
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Raza
        {
            get { return this.raza; }
        }

        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            return this.nombre + "-" + this.raza;
        }

        public static bool operator ==(Mascota m1, Mascota m2)/*no es necesario hacer lo null xq mascota no va a ser instanciada y en las otras mascotas siempre va a tener eso*/
        {
            bool rtn = false;

            //if((object)m1==null&&(object)m2==null)
            //{
            //    rtn = true;
            //}
            //else if((object)m1!=null&&(object)m2!=null)
            //{
            //}
                if(m1.nombre==m2.nombre&&m1.raza==m2.raza)
                {
                    rtn = true;
                }
            return rtn;
        }
        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
    }
}
