using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tinta{
(-) color:ConsoleColor
(-) tipo:ETipoTinta 
//constructor 0, 1, 2 parametros
//por defecto->Black; Comun
//instancia
(-)Mostrar():string
//clase
(+)Mostrar(Tinta):string
//sobrecarga de operadores
== (Tinta, Tinta): bool //color y tipo
explicit (Tinta) : string 
}*/
namespace EjercicioSobrecargasOpSlack
{
    class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;


        /*construct*/
        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }
        public Tinta(ConsoleColor color):this()
        {
            this.color = color;
        }
        public Tinta(ConsoleColor color, ETipoTinta tipo):this(color)
        {
            this.color = color;
            this.tipo = tipo;
        }

        /*metodo instancia*/
        private string Mostrar()
        {
            return this.color + " - " + this.tipo;
        }
        /*metodo static*/
        public static string Mostrar(Tinta x)
        {
            return x.Mostrar();
        }
        /*sobrecargas*/
        public static bool operator ==(Tinta x, Tinta y)
        {
            if(x.tipo==y.tipo&&x.color==y.color)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Tinta x, Tinta y)
        {
            return !(x == y);
        }
        public static explicit operator string(Tinta x)
        {
            return Tinta.Mostrar(x);/*(string)TintaUno*/
        }
    }
}
