using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenWriting
{
    class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        /*constructor*/
        public void AsignarBoligrafo(short cantidadTinta, ConsoleColor colorBoligrafo)
        {
            this.tinta = cantidadTinta;
            this.color = colorBoligrafo;
        }


        /*metodos*/

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            short tintaActual = (short)(GetTinta() + tinta);
            if (tintaActual < 0)
            {
                this.tinta = 0;
            }
            else if(tintaActual>=0&&tintaActual<=100)
            {
                this.tinta = tintaActual;
            }
            else
            {
                this.tinta = 100;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short nivelTintaInicio = GetTinta();
            short nivelTintaActual;
            bool retorno = false;
            dibujo = " ";/*como esta adentro de un case, se inicia para que no quede nulo en el parametro*/
            if(gasto<0)
            {
                 if(nivelTintaInicio>0)
                 {
                    this.SetTinta(gasto);
                    nivelTintaActual = GetTinta();
                    switch (nivelTintaActual)
                    {
                        case 0:
                            /*pinto el valor de tinta que tenia en Inicio*/
                            dibujo = Boligrafo.asteriscos(nivelTintaInicio);
                            break;
                        default:
                            /*pinto Inicio-actual*/
                            dibujo = Boligrafo.asteriscos(nivelTintaInicio - nivelTintaActual);                           
                            break;
                    }
                    retorno = true;
                 }
                else
                {
                    Console.WriteLine("No hay tinta, se debe recargar");
                }               
            }

            return retorno;
        }

        private static string asteriscos (int x)
        {
            string cadena="";
            
            for (int i=0;i<x;i++)
            {
                cadena += "*";
            }
            return cadena;
        }
        public void MostrarTrazo(string trazo)
        {
            Console.ForegroundColor = this.GetColor();
            Console.WriteLine(trazo);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    
    
    }
}
