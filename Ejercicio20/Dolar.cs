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

    }
}
