using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace BibliotecaEjercicio31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
            this.nombre = "";
        }

        public Cliente(int numero,string nombre):this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente uno, Cliente dos)
        {
            bool rtn = false;
            if(uno.numero==dos.numero)
            {
                rtn = true;
            }
            return rtn;
        }
        public static bool operator !=(Cliente uno, Cliente dos)
        {
            return !(uno == dos);
        }

        public override bool Equals(object obj)
        {
            bool rtn = false;
            if (obj is Cliente)
            {
                rtn = this == (Cliente)obj;
            }

            return rtn;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }


        public static bool operator +(Negocio n,Cliente c)
        {
            bool rtn = false;
            if (n!=c)
            {
                n.clientes.Enqueue(c);
                rtn=true;
            }
            return rtn;
        }
        public Cliente Cliente
        {
            get {return this.clientes.Peek(); }
            set { bool rtn= this+value; }
        }

        public static bool operator ==(Negocio n,Cliente c)
        {
            bool rtn = false;
            if (n.clientes.Count > 0)
            {
                foreach (Cliente cliente in n.clientes)
                {
                    if (cliente == c)
                    {
                        rtn = true;
                        break;
                    }
                }
            }
            return rtn;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            bool rtn = false;
            Cliente actual = n.Cliente;
            if(n.clientes.Count>0)
            {
                n.caja.Atender(actual);
                n.clientes.Dequeue();
                Console.WriteLine($"Cantidad restantes: {n.CantidadClientes}");
                rtn = true;
            }
            return rtn;
        }

        public int CantidadClientes
        {
            get {return this.clientes.Count; }
        }


    }
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto):this()
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get {

                PuestoAtencion.numeroActual += 1;
                
                return PuestoAtencion.numeroActual; }
        }

        public bool Atender(Cliente cli)
        {
            int i=PuestoAtencion.NumeroActual;
            Console.WriteLine(i);
            Thread.Sleep(500);
                return true;
        }

    }

    public enum Puesto
    {
        Caja1,
        Caja2
    }
}
