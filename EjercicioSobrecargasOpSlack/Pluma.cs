using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Pluma{
(-) marca:string
(-) tinta:Tinta
(-) cantidad:int
//constructor 0, 1, 2 y 3 parametros.
//por defecto->"Sin marca"; null; 1;
//instancia
(-)Mostrar():string
==(Pluma, Tinta):bool
+(Pluma, Tinta):Pluma // agrega solo si las tintas son iguales. (incrementar cantidad)
-(Pluma, Tinta):Pluma // agrega solo si las tintas son iguales. (decrementar cantidad)
implicit (Pluma):string //se relaciona con mostrar
}*/
namespace EjercicioSobrecargasOpSlack
{
    class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        /*construct*/
        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }
        public Pluma(string marca):this()
        {
            this.marca = marca;
        }
        public Pluma(string marca1,Tinta tinta):this(marca1)
        {
            this.tinta = tinta;

        }
        public Pluma(string marca2,Tinta tinta1,int cantidad):this(marca2,tinta1)
        {
            this.cantidad = cantidad;
        }
        /*metodo isntancia*/
        private string Mostrar()
        {
            return this.marca + " - " + Tinta.Mostrar(this.tinta) + " - " + this.cantidad;
        }
        /*sobrecargas*/
        public static bool operator ==(Pluma p, Tinta t)
        {
            if(p.tinta==t)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Pluma p, Tinta t)
        {
            return !(p == t);
        }
        public static Pluma operator +(Pluma p, Tinta t)
        {
           Pluma aux = new Pluma(p.marca,p.tinta,p.cantidad);
           if(p==t)
           {
                aux.cantidad += 1;
           }
            return aux;
        }
        public static Pluma operator -(Pluma p, Tinta t)
        {
            Pluma aux = new Pluma(p.marca, p.tinta, p.cantidad);
            if (p == t)
            {
                aux.cantidad -= 1;
            }
            return aux;
        }
        public static implicit operator string(Pluma p)
        {
            return p.Mostrar();
        }

    }
}
