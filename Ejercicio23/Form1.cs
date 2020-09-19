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

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if(cotizacionesVal()==false)
            {
                MessageBox.Show("Ingrese cotizaciones en cada moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string valor = txtBoxEuro.Text;
                double valorDouble;
                bool pudo = double.TryParse(valor, out valorDouble);
                if (!pudo)
                {
                    MessageBox.Show("Ingrese un valor valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Euro txt = new Euro(valorDouble);
                    Dolar txtDolar = new Dolar();
                    Peso txtPeso = new Peso();
                    txtDolar = (Dolar)txt;
                    txtPeso = (Peso)txt;
                    txtBoxEuroEuro.Text = valor;
                    txtBoxEuroDolar.Text = txtDolar.GetCantidad().ToString();
                    txtBoxEuroPeso.Text = txtPeso.GetCantidad().ToString();

                }
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (cotizacionesVal() == false)
            {
                MessageBox.Show("Ingrese cotizaciones en cada moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string valor = txtBoxDolar.Text;
                double valorDouble;
                bool pudo = double.TryParse(valor, out valorDouble);
                if (!pudo)
                {
                    MessageBox.Show("Ingrese un valor valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Dolar txt = new Dolar(valorDouble);
                    Euro txtEuro = new Euro();
                    Peso txtPeso = new Peso();
                    txtEuro = (Euro)txt;
                    txtPeso = (Peso)txt;
                    txtBoxDolarDolar.Text = valor;
                    txtBoxDolarEuro.Text = txtEuro.GetCantidad().ToString();
                    txtBoxDolarPeso.Text = txtPeso.GetCantidad().ToString();

                }
            }

        }

        private bool cotizacionesVal()
        {
            if (Euro.GetCotizacion() > 0 && Peso.GetCotizacion() > 0 && Dolar.GetCotizacion() > 0)
            {
                return true;
            }
            else
            {
                return false;  
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (cotizacionesVal() == false)
            {
                MessageBox.Show("Ingrese cotizaciones en cada moneda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string valor = txtBoxPeso.Text;
                double valorDouble;
                bool pudo = double.TryParse(valor, out valorDouble);
                if (!pudo)
                {
                    MessageBox.Show("Ingrese un valor valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Peso txt = new Peso(valorDouble);
                    Euro txtEuro = new Euro();
                    Dolar txtDolar = new Dolar();
                    txtEuro = (Euro)txt;
                    txtDolar = (Dolar)txt;
                    txtBoxPesoPeso.Text = valor;
                    txtBoxPesoEuro.Text = txtEuro.GetCantidad().ToString();
                    txtBoxPesoDolar.Text = txtDolar.GetCantidad().ToString();

                }
            }
        }
    }
}
