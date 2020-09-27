using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesIntegrador
{
    
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;
        private Random rnd;

        public Cliente()
        {
            this._aliasParaIncognito = "Sin alias";
            this._nombre = "NN";
            this._tipoDeCliente = eTipoCliente.SinTipo;
            rnd = new Random();
        }

        public Cliente(eTipoCliente tipoCliente):this()
        {
            this._tipoDeCliente = tipoCliente;
        }

        public Cliente(eTipoCliente tipoCliente,string nombre):this(tipoCliente)
        {
            this._nombre = nombre;
        }

        private void CrearAlias()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((this.rnd.Next(1000, 9999)).ToString());
            sb.Append(this._tipoDeCliente);

            this._aliasParaIncognito = sb.ToString();
        }
        public string GetAlias()
        {
            if(this._aliasParaIncognito=="Sin alias")
            {
                this.CrearAlias();
   
            }
            return this._aliasParaIncognito;
        }
        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Alias: ");
            sb.AppendLine(this._aliasParaIncognito);
            sb.Append("Nombre: ");
            sb.AppendLine(this._nombre);
            sb.Append("Tipo de cliente: ");
            sb.AppendLine(this._tipoDeCliente.ToString());

            return sb.ToString();
        }

        public static string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }

    }



    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private Double _saldo;

        public Cliente Dueño
        {
            get { return this._dueño; }
        }
        public Double Saldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }

        public CuentaOffShore(Cliente duenio,int numero,double saldoInicial)
        {
            this._saldo = saldoInicial;
            this._numeroCuenta = numero;
            this._dueño = duenio;
        }
        public CuentaOffShore(string nombre,eTipoCliente tipo, int numero, double saldoInicial):this(new Cliente(tipo,nombre),numero,saldoInicial)
        {
        }

        public static bool operator ==(CuentaOffShore cUno,CuentaOffShore cDos)
        {
            bool rtn = false;
            if((object)cUno==null&&(object)cDos==null)
            {
                rtn = true;
            }
            else if((object)cUno!=null&&(object)cDos!=null)
            {
                if(cUno._numeroCuenta==cDos._numeroCuenta&&String.Equals(cDos._dueño.GetAlias(),cUno._dueño.GetAlias())==true)
                {
                    rtn = true;
                }
            }

            return rtn;
        }
        public static bool operator !=(CuentaOffShore cUno, CuentaOffShore cDos)
        {
            return !(cUno == cDos);
        }

        public static explicit operator int(CuentaOffShore cuenta)
        {
            return cuenta._numeroCuenta;
        }

    }
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadCuentas;
        public static DateTime fechaInicioActividades;

        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }
        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }
        private ParaisoFiscal(eParaisosFiscales paraiso):this()
        {
            this._lugar = paraiso;
        }

        public string MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Lugar: ");
            sb.AppendLine(this._lugar.ToString());
            sb.Append("Cantidad de cuentas: ");
            sb.AppendLine(ParaisoFiscal.cantidadCuentas.ToString());
            sb.Append("Fecha de inicio: ");
            sb.AppendLine(ParaisoFiscal.fechaInicioActividades.ToString());
            sb.Append("Listado de cuentas: ");
            foreach(CuentaOffShore cuenta in this._listadoCuentas)
            {
                sb.AppendLine(Cliente.RetornarDatos((cuenta.Dueño)));
                sb.Append("Saldo en la cuenta: ");
                sb.AppendLine(cuenta.Saldo.ToString());
                sb.Append("Numero de cuenta: ");
                sb.AppendLine(((int)cuenta).ToString());
            }

            return sb.ToString();
        }

        public static implicit operator ParaisoFiscal(eParaisosFiscales x)
        {
            ParaisoFiscal aux = new ParaisoFiscal(x);
            return aux;
        }
        public static bool operator ==(ParaisoFiscal p,CuentaOffShore c)
        {
            bool rtn = false;

            if(ParaisoFiscal.cantidadCuentas>0)
            {
                foreach(CuentaOffShore cuenta in p._listadoCuentas)
                {
                    if(cuenta==c)
                    {
                        rtn = true;
                        break;
                    }
                }
            }

            return rtn;
        }

        public static bool operator !=(ParaisoFiscal p, CuentaOffShore c)
        {
            return !(p == c);
        }


        public static ParaisoFiscal operator -(ParaisoFiscal p,CuentaOffShore c)
        {
            ParaisoFiscal aux = new ParaisoFiscal();
            aux = p;
            for(int i=0;i<p._listadoCuentas.Count;i++)
            {
                if(p==c)
                {
                    aux._listadoCuentas.RemoveAt(i);
                    Console.WriteLine("Se quito con exito");
                    ParaisoFiscal.cantidadCuentas -= 1;
                }
            }

            return aux;
        }
        public static ParaisoFiscal operator +(ParaisoFiscal p, CuentaOffShore c)
        {
            bool pos = false;
            ParaisoFiscal aux = new ParaisoFiscal();
            aux = p;
            int indice=0;
            double saldoAux=0;
            for (int i = 0; i < p._listadoCuentas.Count; i++)
            {
                if (p==c)
                {
                    pos = true;
                    indice = i;
                }
            }

            if(!pos)
            {
                aux._listadoCuentas.Add(c);
                Console.WriteLine("Se agregó con exito");
                ParaisoFiscal.cantidadCuentas += 1;
            }
            else
            {

                saldoAux = p._listadoCuentas[indice].Saldo + c.Saldo;
                foreach(CuentaOffShore cuenta in aux._listadoCuentas)
                {
                    if(cuenta==c)
                    {
                        cuenta.Saldo = saldoAux;
                    }
                }

            }

            return aux;
        }


    }


    public enum eParaisosFiscales
    {
        Anguila,
        Belice,
        Delaware,
        Gibraltar,
        Hong_Kong,
        Mauricio,
        Panamá,
        Seychelles,
        Singapur,
        Suiza
    }
    public enum eTipoCliente
    {
        PoliticoCorrupto,
        EmpresarioCorrupto,
        JugadorDeFutbol,
        Financista,
        SinTipo
    }

}
