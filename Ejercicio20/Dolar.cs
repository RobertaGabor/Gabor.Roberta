using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        /*atributos*/
        private double cantidad;
        private static double cotizRespectDolar;/*38,33 peso*/
        /*constructores*/
        public Dolar()
        {
            cantidad = 0;
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Billetes.Dolar.cotizRespectDolar = cotizacion;
        }
        /*getter*/
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectDolar;
        }

        /*explicits*/
        public static explicit operator Euro(Dolar x)
        {
            double coti = Euro.GetCotizacion();
            double cant = x.GetCantidad();
            double cotizacionFinal= cant*coti;
            Euro retorno = new Euro(cotizacionFinal);
            return retorno;
        }

        public static explicit operator Peso(Dolar x)
        {
            double coti = Peso.GetCotizacion();
            double cant = x.GetCantidad();
            double cotizacionFinal = cant*coti;
            Peso retorno = new Peso(cotizacionFinal);
            return retorno;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar novo = new Dolar(d);
            return novo;
        }


        /*sobrecargas*/
        public static bool operator ==(Dolar d,Euro e)
        {
            if(d.GetCantidad()*Euro.GetCotizacion()==e.GetCantidad())
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            if (p.GetCantidad() / Peso.GetCotizacion() == d.GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d, Dolar dd)
        {
            if (dd.GetCantidad() == d.GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Dolar d, Dolar dd)
        {
            return !(d == dd);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar aux = (Dolar)e;
            Dolar suma = new Dolar(d.GetCantidad() + aux.GetCantidad());
            return suma;
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar aux = (Dolar)p;
            Dolar suma = new Dolar(d.GetCantidad() + aux.GetCantidad());
            return suma;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar aux = (Dolar)e;
            Dolar suma = new Dolar(d.GetCantidad() - aux.GetCantidad());
            return suma;
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar aux = (Dolar)p;
            Dolar suma = new Dolar(d.GetCantidad() - aux.GetCantidad());
            return suma;
        }
    }
}
