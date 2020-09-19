using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    namespace Billetes
    {
            public class Peso
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
                /*setter*/
                public static void SetCotizacionPeso(double peso)
                {
                    Peso.cotizRespectDolar = peso;
                }
                /*explicits*/
                public static explicit operator Dolar(Peso x)
                {
                    double coti = Peso.GetCotizacion();
                    double cant = x.GetCantidad();
                    double cotizacionFinal = cant / coti;
                    Dolar retorno = new Dolar(cotizacionFinal);
                    return retorno;
                }
                public static explicit operator Euro(Peso x)
                {
                    Dolar cotiDol = (Dolar)x;
                    Euro retorno = (Euro)cotiDol;
                    return retorno;
                }

                public static implicit operator Peso(double d)
                {
                    Peso novo = new Peso(d);
                    return novo;
                }
                /*sobrecargas*/
                public static bool operator ==(Peso p, Dolar d)
                {
                    if (d == p)
                    {
                        return true;
                    }

                    return false;
                }
                public static bool operator !=(Peso p, Dolar d)
                {
                    return !(p == d);
                }
                public static bool operator ==(Peso p, Euro e)
                {

                    if (e == p)
                    {
                        return true;
                    }
                    return false;
                }
                public static bool operator !=(Peso p, Euro e)
                {
                    return !(p == e);
                }
                public static bool operator ==(Peso p, Peso pp)
                {
                    if (p.GetCantidad() == pp.GetCantidad())
                    {
                        return true;
                    }
                    return false;
                }
                public static bool operator !=(Peso p, Peso pp)
                {
                    return !(p == pp);
                }
                public static Peso operator +(Peso p, Dolar d)
                {
                    Peso aux = (Peso)d;
                    Peso suma = new Peso(p.GetCantidad() + aux.GetCantidad());
                    return suma;
                }
                public static Peso operator +(Peso p, Euro e)
                {
                    Peso aux = (Peso)e;
                    Peso suma = new Peso(p.GetCantidad() + aux.GetCantidad());
                    return suma;
                }
                public static Peso operator -(Peso p, Dolar d)
                {
                    Peso aux = (Peso)d;
                    Peso suma = new Peso(p.GetCantidad() - aux.GetCantidad());
                    return suma;
                }
                public static Peso operator -(Peso p, Euro e)
                {
                    Peso aux = (Peso)e;
                    Peso suma = new Peso(p.GetCantidad() - aux.GetCantidad());
                    return suma;
                }
            }




            public class Euro
            {
                /*atributos*/
                private double cantidad;
                private static double cotizRespectDolar;/*1,16 dol*/
                /*constructores*/
                public Euro()
                {
                    cantidad = 0;
                }

                public Euro(double cantidad) : this()
                {
                    this.cantidad = cantidad;
                }

                public Euro(double cantidad, double cotizacion) : this(cantidad)
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
                /*setter*/
                public static void SetCotizacionEuro(double euro)
                {
                    Euro.cotizRespectDolar = euro;
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
                    if (d == e)
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



            public class Dolar
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
                /*setter*/
                public static void SetCotizacionDolar(double dolar)
                {
                    Dolar.cotizRespectDolar = dolar;
                }
                /*explicits*/
                public static explicit operator Euro(Dolar x)
                {
                    double coti = Euro.GetCotizacion();
                    double cant = x.GetCantidad();
                    double cotizacionFinal = cant * coti;
                    Euro retorno = new Euro(cotizacionFinal);
                    return retorno;
                }

                public static explicit operator Peso(Dolar x)
                {
                    double coti = Peso.GetCotizacion();
                    double cant = x.GetCantidad();
                    double cotizacionFinal = cant * coti;
                    Peso retorno = new Peso(cotizacionFinal);
                    return retorno;
                }

                public static implicit operator Dolar(double d)
                {
                    Dolar novo = new Dolar(d);
                    return novo;
                }


                /*sobrecargas*/
                public static bool operator ==(Dolar d, Euro e)
                {
                    if (d.GetCantidad() * Euro.GetCotizacion() == e.GetCantidad())
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
}
