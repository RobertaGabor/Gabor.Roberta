using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    public class Jugador
    {
        /*atributos*/
        private int dni;
        private int partidosJugados;
        private int totalGoles;
        private float promedioGoles;
        private string nombre;
        /*construct*/
        public Jugador()
        {
            this.dni = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;
            this.promedioGoles = 0;
            this.nombre = "";
        }
        public Jugador(int dni,string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni,string nombre,int goles,int partidos):this(dni,nombre)
        {
            this.totalGoles = goles;
            this.partidosJugados = partidos;
        }

        /*getter*/
        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)this.totalGoles / this.partidosJugados;
            return this.promedioGoles;
        }
        /*metodo*/
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Dni: ");
            sb.AppendLine(this.dni.ToString());
            sb.Append("Nombre: ");
            sb.AppendLine(this.nombre);
            sb.Append("Partidos jugados: ");
            sb.AppendLine(this.partidosJugados.ToString());
            sb.Append("Total Goles: ");
            sb.AppendLine(this.totalGoles.ToString());
            sb.Append("Promedio goles: ");
            sb.AppendFormat("{0:##,###.00}",this.GetPromedioGoles());
            return sb.ToString();
        }

        public static bool operator ==(Jugador uno, Jugador dos)
        {
            bool rtn= false;
            if((object)uno==null&&(object)dos==null)
            {
                rtn = true;
            }
            else if((object)uno!=null&&(object)dos!=null)
            {
                if(uno.dni==dos.dni)
                {
                    rtn = true;
                }
            }

            return rtn;
        }
        public static bool operator !=(Jugador uno, Jugador dos)
        {
            return !(uno == dos);
        }

    }
}
