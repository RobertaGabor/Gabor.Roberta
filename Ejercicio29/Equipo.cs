using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        /*construc*/
        public Equipo()
        {
            this.cantidadJugadores = 0;
            this.jugadores = new List<Jugador>();//NO OLVIDAR
            this.nombre = "";
        }
        public Equipo(short cant,string nombre):this()
        {
            this.cantidadJugadores = cant;
            this.nombre = nombre;
        }

        /*La sobrecarga del operador + agregará jugadores a la lista siempre y cuando este no exista
        aun en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo
        cantidadDeJugadores*/
        public static bool operator +(Equipo e, Jugador j)
        {
            bool rtn = true;

            if(e.jugadores.Count<e.cantidadJugadores&&e.jugadores.Count!=0)
            {
                foreach(Jugador player in e.jugadores)
                {
                    if(player==j)
                    {
                        rtn = false;
                        break;
                    }

                }
                if (rtn == true)
                {
                    e.jugadores.Add(j);
                }
            }
            else
            {
                e.jugadores.Add(j);
            }

            return rtn;
        }
    }
}
