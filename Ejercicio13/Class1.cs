using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(double x)/*Convierte un número de entero a binario*/
        {
            Int32 cambio = 1;
            
            string numero = Convert.ToString(x);
            string entero="";
            string decimales = "";
            Int32 lenght = numero.Length;
            Int32 parteEntera;
            Double parteDecimal;

            string enteroBinario="";
            string decimalBinario = "";
            Int32 lenghtEnteroBinario;
            string enteroBinarioAlReves = "";

            string numeroBinario;

            for (int i=0;i<lenght;i++)
            {
                if(cambio==1)
                {
                    if(numero[i]==',')
                    {
                        cambio=0;
                    }
                    else
                    {
                        entero += numero[i];
                    }
                    
                }
                else
                {
                    decimales += numero[i];
                } 
            }

            
            

            /*Console.WriteLine(parteEntera);
            Console.WriteLine(parteDecimal);*/

            
            #region ENTERO
            parteEntera = int.Parse(entero);
            while(parteEntera!=0)
            {
                if(parteEntera%2==0)
                {
                    parteEntera = parteEntera / 2;
                    enteroBinario += "0";
                }
                else
                {
                    parteEntera = (parteEntera - 1) / 2;
                    enteroBinario += "1";
                }
            }


            lenghtEnteroBinario = enteroBinario.Length;

            for (int b = lenghtEnteroBinario - 1; b >= 0; b--)
            {
                enteroBinarioAlReves += enteroBinario[b];
            }

            //Console.WriteLine(enteroBinarioAlReves);/*INVERTIDO*/

            #endregion

            #region DECIMAL
            if(cambio==0)
            {
                parteDecimal = double.Parse(decimales);
                Int32 cont = 0;
                while (parteDecimal != 0 && cont < 7)
                {
                    if (parteDecimal * 2 < 100)/*si el decimal es mayor a 100 acortar y redondear porque sino no funciona*/
                    {
                        parteDecimal = parteDecimal * 2;
                        decimalBinario += "0";
                    }
                    else
                    {
                        parteDecimal = (parteDecimal * 2) - 100;
                        decimalBinario += "1";
                    }
                    cont++;
                }

                //Console.WriteLine(decimalBinario);
            }

            #endregion


            numeroBinario = enteroBinarioAlReves+ "," + decimalBinario;

            return numeroBinario;
        }

        public static double BinarioDecimal(string y)/*Convierte un número binario a entero*/
        {
            Int32 lenght1 = y.Length;
            Double parteEntera1 = 0;
            Double inicioEntero=-1;
            Double potenciado;
            Double parteDecimal1 = 0;
            bool coma = false;
            
            Double numeroDecimal;

            for (int n = 0; n<lenght1; n++)
            {
                if (y[n]=='.')
                {
                    coma = true;
                    break;
                }
            }
            if(coma)
            {
                for (int n = 0; y[n] != '.'; n++)
                {
                    inicioEntero++;
                }
            }
            else
            {
                inicioEntero = lenght1-1;/*porque empezamos en 0 y el lenght va desde 1*/
            }

            for (int s = 0; s < lenght1; s++)
            {   
                if (y[s] == '0')
                {
                    parteEntera1 += 0;
                    parteDecimal1 += 0;
                }
                else if (y[s] == '1')
                {
                    potenciado = Math.Pow(2, inicioEntero);

                    if(inicioEntero>=0)
                    {
                        parteEntera1 += potenciado;
                    }
                    else
                    {
                        parteDecimal1 += potenciado;
                    }
                    

                }

                if(y[s] != '.')
                {
                    inicioEntero--;
                    
                }

            }
  

            numeroDecimal = parteEntera1 + parteDecimal1;
            return numeroDecimal;
        }
    }
}
