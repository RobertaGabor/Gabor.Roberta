using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesIntegrador;

namespace ConsolaIntegrador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gabor y Roberta";
            Cliente mauri = new Cliente(eTipoCliente.PoliticoCorrupto, "Mauri");
            Cliente fariña = new Cliente(eTipoCliente.Financista, "Fariña");
            Cliente mesias = new Cliente(eTipoCliente.JugadorDeFutbol, "Lio");

            CuentaOffShore messiOff = new CuentaOffShore(mesias, 123, 15000);
            CuentaOffShore mauriOff = new CuentaOffShore(mauri, 678, 25000);
            CuentaOffShore lazaroOff = new CuentaOffShore("Lazaro", eTipoCliente.EmpresarioCorrupto,456, 56000);
            CuentaOffShore otraDeMauri = new CuentaOffShore(mauri, 678, 50000);
            CuentaOffShore fariOff = new CuentaOffShore(fariña, 666, 3500);

            ParaisoFiscal panamaPapers = eParaisosFiscales.Panamá;

            panamaPapers += messiOff;
            panamaPapers += mauriOff;
            panamaPapers += lazaroOff;

            Console.WriteLine(panamaPapers.MostrarParaiso());
            
            panamaPapers += otraDeMauri;
            panamaPapers -= messiOff;
            panamaPapers -= fariOff;

            Console.WriteLine(panamaPapers.MostrarParaiso());

            Console.ReadKey();
        }
    }
}
