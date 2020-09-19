using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        /*atributos*/
        private double cantidad;
        private static double cotizRespectDolar;/*1,16 dol*/
        /*constructores*/
        public Euro()
        {
            cantidad = 0;
        }

        public Euro(double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad,double cotizacion) : this(cantidad)
        {
            Billetes.Euro.cotizRespectDolar = cotizacion;
        }
        /*getter*/
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectDolar;
        }
        /*explicits*/
        public static explicit operator Dolar(Euro x)
        {
            double coti = Euro.GetCotizacion();
            double cant = x.GetCantidad();
            double cotizacionFinal = cant / coti;
            Dolar retorno = new Dolar(cotizacionFinal);
            return retorno;
        }

        public static explicit operator Peso(Euro x)
        {
            Dolar cotiDol = (Dolar)x;
            Peso retorno = (Peso)cotiDol;
            return retorno;
        }

        public static implicit operator Euro(double d)
        {
            Euro novo = new Euro(d);
            return novo;
        }

        /*sobrecargas*/
        public static bool operator ==(Euro e, Dolar d)
        {
            if (d==e)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Peso p)
        {

            if (((Euro)p).GetCantidad() == e.GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator ==(Euro e, Euro ee)
        {
            if (e.GetCantidad() == ee.GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Euro e, Euro ee)
        {
            return !(e == ee);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro aux = (Euro)d;
            Euro suma = new Euro(e.GetCantidad() + aux.GetCantidad());
            return suma;
        }
        public static Euro operator +(Euro e, Peso p)
        {
            Euro aux = (Euro)p;
            Euro suma = new Euro(e.GetCantidad() + aux.GetCantidad());
            return suma;
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro aux = (Euro)d;
            Euro suma = new Euro(e.GetCantidad() - aux.GetCantidad());
            return suma;
        }
        public static Euro operator -(Euro e, Peso p)
        {
            Euro aux = (Euro)p;
            Euro suma = new Euro(e.GetCantidad() - aux.GetCantidad());
            return suma;
        }
    }
}
