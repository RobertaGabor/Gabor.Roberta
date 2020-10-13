using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPracticaPP
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static EtipoManada tipo;

        static Grupo()
        {
            Grupo.tipo = EtipoManada.Unica;
        }

        private Grupo()
        {
            manada = new List<Mascota>();
            //this.nombre = ""; no se llama xq como es privado no se llama desde main
        }

        public Grupo(string nombre) : this()/*aca solo llamo al const privado*/
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            Grupo.tipo = tipo;
        }

        public EtipoManada Tipo
        {
            set { Grupo.tipo = value; }
        }

        public static bool operator ==(Grupo g1, Mascota m1)
        {
            bool rtn = false;

            foreach (Mascota can in g1.manada)
            {
                if (m1.Equals(can))/*IMPORTANTE*/
                {
                    rtn = true;
                    break;
                }
            }
            return rtn;
        }
        public static bool operator !=(Grupo g1, Mascota m1)
        {
            return !(g1 == m1);
        }

        public static Grupo operator +(Grupo g1, Mascota m1)
        {
            Grupo aux = new Grupo();
            aux = g1;
            if (g1 != m1)
            {
                aux.manada.Add(m1);
            }
            else
            {
                Console.WriteLine($"{m1.ToString()} ya está en la lista");
            }

            return aux;
        }

        public static Grupo operator -(Grupo g1, Mascota m1)
        {
            Grupo aux = new Grupo();
            aux = g1;
            if (g1 == m1)
            {
                g1.manada.Remove(m1);
            }
            else
            {
                Console.WriteLine($"{m1.ToString()} no está en la lista");
            }
            return aux;
        }

        public static implicit operator String(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Grupo: {g.nombre} - Tipo: {Grupo.tipo}");
            sb.AppendLine($"Integrantes ({g.manada.Count})");
            foreach(Mascota can in g.manada)
            {
                sb.AppendLine(can.ToString());
            }
            return sb.ToString();
        }

    }
}
