using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesLavadero
{
    public class Vehiculo
    {

        protected string patente;
        protected byte cantRuedas;
        protected EMarcas marca;


        public EMarcas Marca
        {
            get { return this.marca; }
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Patente: ");
            sb.AppendLine(this.patente);
            sb.Append("Cantidad de ruedas: ");
            sb.AppendLine(this.cantRuedas.ToString());
            sb.Append("Marca: ");
            sb.AppendLine(this.marca.ToString());

            return sb.ToString();
        }

        public Vehiculo(string patente, byte cantidadRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.marca = marca;
            this.cantRuedas = cantidadRuedas;
        }


        public static bool operator ==()


    }
}
