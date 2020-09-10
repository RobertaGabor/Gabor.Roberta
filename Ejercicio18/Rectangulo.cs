using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        /*constructor*/
        public Rectangulo(Punto vertice1,Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = Punto.AsignarVertice(this.vertice1, this.vertice3);
            this.vertice4 = Punto.AsignarVertice(this.vertice3, this.vertice1);
            this.area = Math.Abs(vertice1.GetX() - vertice3.GetX()) * Math.Abs(vertice1.GetY() - vertice3.GetY());
            this.perimetro = (Math.Abs(vertice1.GetX() - vertice3.GetX()) + Math.Abs(vertice1.GetY() - vertice3.GetY()))*2;

        }

        /*metodos*/
        public float GetArea()
        {
            return this.area;    
        }
        public float GetPerimetro()
        {
            return this.perimetro;
        }

        public void Mostrar()
        {
            Console.WriteLine("Vertice Uno    x:{0}  y:{1}  ",this.vertice1.GetX(), this.vertice1.GetY());
            Console.WriteLine("Vertice Dos    x:{0}  y:{1}  ", this.vertice2.GetX(), this.vertice2.GetY());
            Console.WriteLine("Vertice Tres   x:{0}  y:{1}  ", this.vertice3.GetX(), this.vertice3.GetY());
            Console.WriteLine("Vertice Cuatro x:{0}  y:{1}  ", this.vertice4.GetX(), this.vertice4.GetY());
            Console.WriteLine("Area: {0}, Perimetro: {1}", this.area, this.perimetro);
        }
    }
}
