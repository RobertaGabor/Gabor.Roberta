using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        private Random rdm;

        /*construct*/
        private Competencia()
        {
            this.cantidadCompetidores = 0;
            this.cantidadVueltas = 0;
            this.competidores = new List<AutoF1>(); 
            this.rdm = new Random();
        }

        public Competencia(short cantComp,short cantVuel):this()
        {
            this.cantidadVueltas = cantVuel;
            this.cantidadCompetidores = cantComp;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cantidad competidores: ");
            sb.AppendLine(this.cantidadCompetidores.ToString());
            sb.Append("Cantidad de vueltas: ");
            sb.AppendLine(this.cantidadVueltas.ToString());
            sb.AppendLine("Listado de autos: ");
            foreach(AutoF1 auto in this.competidores)
            {
                sb.AppendLine(auto.MostrarDatos());
                sb.AppendLine("_________________________________________");
            }
            return sb.ToString();
        }

        /*La sobrecarga + agregará un competidor si es que aún hay espacio (validar con
        cantidadCompetidores) y el competidor no forma parte de la lista (== entre Competencia y
        AutoF1).
        f. Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, la cantidad
        de vueltasRestantes será igual a la cantidadVueltas de Competencia y se le asignará un
        número random entre 15 y 100 a cantidadCombustible.*/

        public static bool operator ==(Competencia c,AutoF1 auto)
        {
            bool rtn = false;
            if(c.competidores.Count>0)
            {
                foreach (AutoF1 car in c.competidores)
                {
                    if(auto==car)
                    {
                        rtn = true;
                    }
                }
            }
            return rtn;
        }
        public static bool operator !=(Competencia c, AutoF1 auto)
        {
            return !(c == auto);
        }

       
        public static bool operator +(Competencia c, AutoF1 a)
        {
            
            bool rtn = false;

            if(c.competidores.Count<c.cantidadCompetidores&&!(c==a))
            {
                
                c.competidores.Add(a);
                a.CantidadCombustible =(short) c.rdm.Next(15, 100);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                rtn = true;
            }

            return rtn;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool rtn = false;
            int indice=-1;
            int tamanio = c.competidores.Count;
            if(tamanio>0)
            {
                for (int i = 0; i < tamanio; i++)
                {
                    if(c==a)
                    {
                        indice = i;
                        break;
                    }
                }
                if(indice!=-1)
                {
                    c.competidores.RemoveAt(indice);
                    rtn = true;
                }
            }


            return rtn;
        }

    }
}
