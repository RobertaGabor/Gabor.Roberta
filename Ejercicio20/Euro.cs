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
            Peso retorno = (Peso)x;
            return retorno;
        }

        public static implicit operator Euro(double d)
        {
            Euro novo = new Euro(d);
            return novo;
        }


    }
}
