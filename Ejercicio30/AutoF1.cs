using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private short numero;
        private short vueltaRestante;
        private string escuderia;
        private bool enCompetencia;

        /*construct*/
        public AutoF1(short numero,string escuderia)
        {
            this.cantidadCombustible = 0;
            this.numero = numero;
            this.vueltaRestante = 0;
            this.escuderia = escuderia;
            this.enCompetencia = false;
        }
        /*mostrar*/
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Numero: ");
            sb.AppendLine(this.numero.ToString());
            sb.Append("Escuderia: ");
            sb.AppendLine(this.escuderia);
            sb.Append("Cantidad de combustible: ");
            sb.AppendLine(this.cantidadCombustible.ToString());
            sb.Append("En competencia?: ");
            sb.AppendLine(this.enCompetencia.ToString());
            sb.Append("Vuelta restante: ");
            sb.AppendLine(this.vueltaRestante.ToString());

            return sb.ToString();
        }
        /*set get*/
        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltaRestante; }
            set { this.vueltaRestante = value; }
        }

        /*sobrecarga numero ye scuderia*/
        public static bool operator ==(AutoF1 uno,AutoF1 dos)
        {
            bool rtn = false;

            if((object)uno==null&&(object)dos==null)
            {
                rtn = true;
            }
            else if((object)uno!=null&&(object)dos!=null)
            {
                if(uno.numero==dos.numero&&uno.escuderia==dos.escuderia)
                {
                    rtn = true;
                }
            }
            return rtn;
        }
        public static bool operator !=(AutoF1 uno, AutoF1 dos)
        {
            return !(uno==dos);
        }
    }
}
