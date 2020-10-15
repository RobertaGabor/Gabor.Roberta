using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        /*getters*/
        public float Duracion
        {
            get {return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }
        /*construct*/
        public Llamada(float duracion,string destino,string origen)
        {
            this.nroDestino = destino;
            this.nroOrigen = origen;
            this.duracion = duracion;
        }


        public static int OrdenarPorDuracion (Llamada llamada1, Llamada llamada2)
        {
            return llamada1.duracion.CompareTo(llamada2.duracion);
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.duracion}");
            sb.AppendLine($"Nro destino: {this.nroDestino}");
            sb.AppendLine($"Nro origen: {this.nroOrigen}");
            return sb.ToString();
        }
    }

    public class Local:Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo)
            : this(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen,costo)
        {
            this.costo = costo;
        }
        public Local(float duracion, string destino, string origen,float costo)
            :base(duracion,destino,origen)
        {
            this.costo=costo;
        }

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");
            return sb.ToString();
        }
    }

    public class Provincial:Llamada
    {

        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            :base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen,Franja miFranja, float duracion, string destino)
            :this(miFranja,new Llamada(duracion,destino,origen))
        {
        }
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        private float CalcularCosto()
        {
            float num=0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    num = (float)0.99 * base.duracion;
                    break;
                case Franja.Franja_2:
                    num = (float)1.25 * base.duracion;
                    break;
                case Franja.Franja_3:
                    num = (float)0.66 * base.duracion;
                    break;
                default:
                    break;
            }
            return num;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria.ToString()}");
            return sb.ToString();
        }
    }

    public class Centralita
    {
        private List<Llamada> llamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.llamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float rtn=0;

            foreach(Llamada item in this.llamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if(item is Local)
                        {
                            rtn += ((Local)item).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            rtn += ((Provincial)item).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        if (item is Local)
                        {
                            rtn += ((Local)item).CostoLlamada;
                        }
                        if (item is Provincial)
                        {
                            rtn += ((Provincial)item).CostoLlamada;
                        }
                        break;
                    default:
                        break;
                }  
            }

            return rtn;

        }

        public float GananciasPorLocal
        {
            get {return this.CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.llamadas; }
        }

        public void OrdenarLlamadas()
        {
            this.llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Costo total Locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Costo total Provinciales: {this.GananciasPorProvincial}");
            sb.AppendLine($"Costo Total: {this.GananciasPorTotal}");
            foreach(Llamada item in this.llamadas)
            {
                sb.AppendLine(item.Mostrar());
                sb.AppendLine("---------------------------");
            }
            return sb.ToString();
        }



    }





}
