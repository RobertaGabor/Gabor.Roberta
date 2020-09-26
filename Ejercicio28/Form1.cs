using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class ContadorForm : Form
    {
        public ContadorForm()
        {
            InitializeComponent();           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();
            string texto = richTextBoxCalcular.Text;
            string palabra="";
            StringBuilder mensaje = new StringBuilder();
            int fore = 0;

            for(int i=0;i<texto.Length;i++)
            {
                if (char.IsWhiteSpace(texto[i])==false&&i!=texto.Length-1)
                {
                    palabra += texto[i];
                }
                else
                {
                    if(i == texto.Length - 1)
                    {
                        palabra += texto[i];
                    }
                    if (contador.ContainsKey(palabra)==true)
                    {
                        int y = contador[palabra] + 1;
                        contador[palabra] = y;
                    }
                    else
                    {
                        contador.Add(palabra, 1);
                    }
                    palabra = "";

                }

            }


            mensaje.AppendLine("TOP 3");
            foreach (KeyValuePair<string, int> pare in contador.OrderBy(key=>key.Value).Reverse())          
            {
                mensaje.AppendLine($"{pare.Value} - {pare.Key}");
                fore++;
                if (fore == 3)
                {
                    break;
                }
            }

            MessageBox.Show(mensaje.ToString());
            


        }

    }
}
