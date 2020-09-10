using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        /*cordenadas a obtener con getter*/
        private int x;
        private int y;

        /*constructor*/
        public Punto(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        /*metodos*/
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }

        public static Punto AsignarVertice(Punto x, Punto y)/*NO ESTA BIEN QUE SEA STATIC Y LOS ATRIBUTOS DINAMICOS?????? */
        {
            int equis = x.GetX();
            int iyi = y.GetY();
            Punto auxiliar = new Punto(equis, iyi);/*SE PUEDE USAR METODO ESTATICO SOLO SI EL OBJETO SE CREA EN EL METODO*/
            return auxiliar;
        }
    }
}
