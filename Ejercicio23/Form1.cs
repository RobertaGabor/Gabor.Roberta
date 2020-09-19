using Moneda.Billetes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio23
{
    public partial class FormConverter : Form
    {
        private bool candado;
        public FormConverter()
        {
            InitializeComponent();
            candado = false;
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            if(candado==false)
            {
                btnCotizacion.ImageIndex = 0;
                txtBoxCotiPeso.Enabled = false;
                txtBoxCotiDolar.Enabled = false;
                txtBoxCotiEuro.Enabled = false;

            }
            else
            {
                btnCotizacion.ImageIndex = 1;
                txtBoxCotiPeso.Enabled = true;
                txtBoxCotiDolar.Enabled = true;
                txtBoxCotiEuro.Enabled = true;
            }
            candado = !candado;
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            string cotizacion = txtBoxCotiEuro.Text;
            double cotizacionDouble;
            bool pudo=double.TryParse(cotizacion, out cotizacionDouble);
            if(!pudo)
            {
                txtBoxCotiEuro.Focus();
            }
            else
            {
                Euro.SetCotizacionEuro(cotizacionDouble);
            }
            
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            string cotizacion = txtBoxCotiDolar.Text;
            double cotizacionDouble;
            bool pudo = double.TryParse(cotizacion, out cotizacionDouble);
            if (!pudo)
            {
                txtBoxCotiDolar.Focus();
            }
            else
            {
                Dolar.SetCotizacionDolar(cotizacionDouble);
            }
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            string cotizacion = txtBoxCotiPeso.Text;
            double cotizacionDouble;
            bool pudo = double.TryParse(cotizacion, out cotizacionDouble);
            if (!pudo)
            {
                txtBoxCotiPeso.Focus();
            }
            else
            {
                Peso.SetCotizacionPeso(cotizacionDouble);
            }
        }
    }
}
