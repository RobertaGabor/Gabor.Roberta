using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Program
    {
        /*Crear un enumerado Colores { Rojo, Blanco, Azul, Gris, Negro }
        b. Camión tendrá los atributos cantidadRuedas : short, cantidadPuertas : short, color : Colores,
        cantidadMarchas : short, pesoCarga : int.
        c. Automovil: cantidadRuedas : short, cantidadPuertas : short, color : Colores,
        cantidadMarchas : short, cantidadPasajeros : int.
        d. Moto: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
        e. Crearle a cada clase un constructor que reciba todos sus atributos.
        f. Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores.
        Luego generar una relación de herencia entre ellas, según corresponda.
        g. VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos. Modificar las
        clases que heredan de ésta para que lo reutilicen.*/
        public class VehiculoTerrestre
        {
            private short cantidadRuedas;
            private short cantidadPuertas;
            private Colores color;


            public VehiculoTerrestre(short cantidadR,short cantidadP,Colores color)
            {
                this.color = color;
                this.cantidadRuedas = cantidadR;
                this.cantidadPuertas = cantidadP;
            }

        }
        public class Automovil: VehiculoTerrestre
        {
            private short cantidadMarchas;
            private int cantidadPasajeros;

            public Automovil(short cantidadR,short cantidadP,short cantidadM,int cantidadPas,Colores color)
                :base(cantidadR,cantidadP,color)
            {
                this.cantidadMarchas = cantidadM;
                this.cantidadPasajeros = cantidadPas;
            }


        }
        public class Moto: VehiculoTerrestre
        {
            private short cilindrada;
            public Moto(short cantidadR, short cantidadP, short cilindrada, Colores color)
                : base(cantidadR, cantidadP, color)
            {
                this.cilindrada = cilindrada;
            }

        }
        public class Camion: VehiculoTerrestre
        {
            private int pesoCarga;
            private short cantidadMarchas;

            public Camion(short cantidadR, short cantidadP, short cantidadM, int peso, Colores color)
                : base(cantidadR, cantidadP, color)
            {
                this.pesoCarga = peso;
                this.cantidadMarchas = cantidadM;
            }

        }
        static void Main(string[] args)
        {

        }

        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro,
        }
    }
}
