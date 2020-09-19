using Ejercicio13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string s)
        {
            this.numero = s;
        }

        /*sobrecargas*/
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            string db = Conversor.DecimalBinario(d.numero);
            if(b.numero==db)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            string db = Conversor.DecimalBinario(d.numero);
            string suma = "";
            string ceros="";
            Int32 lenght;

            if(b.numero.Length>db.Length)
            {
                lenght = b.numero.Length;
                for(int i=lenght-db.Length;i>0;i++)
                {
                    ceros += "0";
                }
                db = String.Concat(ceros, db);
            }
            else
            {
                lenght = db.Length;
            }

            for(int i=lenght-1;i>=0;i++)
            {
                if(b.numero[i]==db[i])
                {
                    if (db[i] == 0)
                    {
                        suma += "0";
                    }
                    else if (db[i] == 1)
                    {
                        suma += "0";
                        char ii = db[i - 1];
                        int iiInt = Convert.ToInt32(ii);
                        iiInt += 1;


                    }
                }
                lenght--;
            }

            return suma;
        }
    }
}
