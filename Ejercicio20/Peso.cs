using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Peso
    {
        /*atributos*/
        private double cantidad;
        private static double cotizRespectDolar;
        /*constructores*/
        public Peso()
        {
            cantidad = 0;
        }

        public Peso(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Billetes.Peso.cotizRespectDolar = cotizacion;
        }
        /*getter*/
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Peso.cotizRespectDolar;
        }
        /*explicits*/
        public static explicit operator Dolar(Peso x)
        {
            double coti = Peso.GetCotizacion();
            double cant = x.GetCantidad();
            double cotizacionFinal = cant*coti;
            Dolar retorno = new Dolar(cotizacionFinal);
            return retorno;
        }
        public static explicit operator Euro(Peso x)
        {
            Dolar cotiDol = (Dolar)x;
            Euro retorno = (Euro)x;
            return retorno;
        }

        public static implicit operator Peso(double d)
        {
            Peso novo = new Peso(d);
            return novo;
        }
    }
}
