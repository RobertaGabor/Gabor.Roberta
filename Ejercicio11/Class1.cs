using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)/*metodo:funciones; ponerla publica para usarla*/
        {
            bool retorno = false;

            if(valor>=min&&valor<=max)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
