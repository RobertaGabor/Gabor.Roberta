namespace Ejercicio23
{
    partial class FormConverter
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConverter));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtBoxEuro = new System.Windows.Forms.TextBox();
            this.txtBoxDolar = new System.Windows.Forms.TextBox();
            this.txtBoxPeso = new System.Windows.Forms.TextBox();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.Candados = new System.Windows.Forms.ImageList(this.components);
            this.btnEuroConvert = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.txtBoxCotiEuro = new System.Windows.Forms.TextBox();
            this.txtBoxCotiDolar = new System.Windows.Forms.TextBox();
            this.txtBoxCotiPeso = new System.Windows.Forms.TextBox();
            this.labelEuro = new System.Windows.Forms.Label();
            this.labelDolar = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.txtBoxEuroEuro = new System.Windows.Forms.TextBox();
            this.txtBoxDolarEuro = new System.Windows.Forms.TextBox();
            this.txtBoxPesoEuro = new System.Windows.Forms.TextBox();
            this.txtBoxEuroDolar = new System.Windows.Forms.TextBox();
            this.txtBoxDolarDolar = new System.Windows.Forms.TextBox();
            this.txtBoxPesoDolar = new System.Windows.Forms.TextBox();
            this.txtBoxEuroPeso = new System.Windows.Forms.TextBox();
            this.txtBoxDolarPeso = new System.Windows.Forms.TextBox();
            this.txtBoxPesoPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.Location = new System.Drawing.Point(12, 15);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(115, 27);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotizacion";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(12, 76);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(57, 27);
            this.lblEuro.TabIndex = 1;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(12, 125);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(65, 27);
            this.lblDolar.TabIndex = 2;
            this.lblDolar.Text = "Dólar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(12, 176);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(58, 27);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // txtBoxEuro
            // 
            this.txtBoxEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEuro.Location = new System.Drawing.Point(90, 76);
            this.txtBoxEuro.Name = "txtBoxEuro";
            this.txtBoxEuro.Size = new System.Drawing.Size(112, 24);
            this.txtBoxEuro.TabIndex = 5;
            // 
            // txtBoxDolar
            // 
            this.txtBoxDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDolar.Location = new System.Drawing.Point(90, 128);
            this.txtBoxDolar.Name = "txtBoxDolar";
            this.txtBoxDolar.Size = new System.Drawing.Size(112, 24);
            this.txtBoxDolar.TabIndex = 6;
            // 
            // txtBoxPeso
            // 
            this.txtBoxPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPeso.Location = new System.Drawing.Point(90, 176);
            this.txtBoxPeso.Name = "txtBoxPeso";
            this.txtBoxPeso.Size = new System.Drawing.Size(112, 24);
            this.txtBoxPeso.TabIndex = 7;
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.ImageIndex = 1;
            this.btnCotizacion.ImageList = this.Candados;
            this.btnCotizacion.Location = new System.Drawing.Point(133, 12);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(129, 33);
            this.btnCotizacion.TabIndex = 4;
            this.btnCotizacion.UseVisualStyleBackColor = true;
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
            // 
            // Candados
            // 
            this.Candados.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Candados.ImageStream")));
            this.Candados.TransparentColor = System.Drawing.Color.Transparent;
            this.Candados.Images.SetKeyName(0, "bloqueado.png");
            this.Candados.Images.SetKeyName(1, "bloqueado (1).png");
            // 
            // btnEuroConvert
            // 
            this.btnEuroConvert.Location = new System.Drawing.Point(208, 76);
            this.btnEuroConvert.Name = "btnEuroConvert";
            this.btnEuroConvert.Size = new System.Drawing.Size(66, 23);
            this.btnEuroConvert.TabIndex = 8;
            this.btnEuroConvert.Text = "->";
            this.btnEuroConvert.UseVisualStyleBackColor = true;
            this.btnEuroConvert.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(208, 128);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(66, 23);
            this.btnConvertDolar.TabIndex = 9;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(208, 176);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(66, 23);
            this.btnConvertPeso.TabIndex = 10;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // txtBoxCotiEuro
            // 
            this.txtBoxCotiEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCotiEuro.Location = new System.Drawing.Point(280, 15);
            this.txtBoxCotiEuro.Name = "txtBoxCotiEuro";
            this.txtBoxCotiEuro.Size = new System.Drawing.Size(102, 24);
            this.txtBoxCotiEuro.TabIndex = 1;
            this.txtBoxCotiEuro.Leave += new System.EventHandler(this.txtCotizacionEuro_Leave);
            // 
            // txtBoxCotiDolar
            // 
            this.txtBoxCotiDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCotiDolar.Location = new System.Drawing.Point(388, 15);
            this.txtBoxCotiDolar.Name = "txtBoxCotiDolar";
            this.txtBoxCotiDolar.Size = new System.Drawing.Size(102, 24);
            this.txtBoxCotiDolar.TabIndex = 2;
            this.txtBoxCotiDolar.Leave += new System.EventHandler(this.txtCotizacionDolar_Leave);
            // 
            // txtBoxCotiPeso
            // 
            this.txtBoxCotiPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCotiPeso.Location = new System.Drawing.Point(494, 15);
            this.txtBoxCotiPeso.Name = "txtBoxCotiPeso";
            this.txtBoxCotiPeso.Size = new System.Drawing.Size(97, 24);
            this.txtBoxCotiPeso.TabIndex = 3;
            this.txtBoxCotiPeso.Leave += new System.EventHandler(this.txtCotizacionPeso_Leave);
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuro.Location = new System.Drawing.Point(303, 45);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(57, 27);
            this.labelEuro.TabIndex = 14;
            this.labelEuro.Text = "Euro";
            // 
            // labelDolar
            // 
            this.labelDolar.AutoSize = true;
            this.labelDolar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolar.Location = new System.Drawing.Point(408, 45);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(65, 27);
            this.labelDolar.TabIndex = 15;
            this.labelDolar.Text = "Dólar";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(512, 45);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(58, 27);
            this.labelPeso.TabIndex = 16;
            this.labelPeso.Text = "Peso";
            // 
            // txtBoxEuroEuro
            // 
            this.txtBoxEuroEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEuroEuro.Location = new System.Drawing.Point(280, 75);
            this.txtBoxEuroEuro.Name = "txtBoxEuroEuro";
            this.txtBoxEuroEuro.ReadOnly = true;
            this.txtBoxEuroEuro.Size = new System.Drawing.Size(102, 24);
            this.txtBoxEuroEuro.TabIndex = 17;
            // 
            // txtBoxDolarEuro
            // 
            this.txtBoxDolarEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDolarEuro.Location = new System.Drawing.Point(280, 128);
            this.txtBoxDolarEuro.Name = "txtBoxDolarEuro";
            this.txtBoxDolarEuro.ReadOnly = true;
            this.txtBoxDolarEuro.Size = new System.Drawing.Size(102, 24);
            this.txtBoxDolarEuro.TabIndex = 18;
            // 
            // txtBoxPesoEuro
            // 
            this.txtBoxPesoEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesoEuro.Location = new System.Drawing.Point(280, 178);
            this.txtBoxPesoEuro.Name = "txtBoxPesoEuro";
            this.txtBoxPesoEuro.ReadOnly = true;
            this.txtBoxPesoEuro.Size = new System.Drawing.Size(102, 24);
            this.txtBoxPesoEuro.TabIndex = 19;
            // 
            // txtBoxEuroDolar
            // 
            this.txtBoxEuroDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEuroDolar.Location = new System.Drawing.Point(388, 75);
            this.txtBoxEuroDolar.Name = "txtBoxEuroDolar";
            this.txtBoxEuroDolar.ReadOnly = true;
            this.txtBoxEuroDolar.Size = new System.Drawing.Size(102, 24);
            this.txtBoxEuroDolar.TabIndex = 20;
            // 
            // txtBoxDolarDolar
            // 
            this.txtBoxDolarDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDolarDolar.Location = new System.Drawing.Point(388, 128);
            this.txtBoxDolarDolar.Name = "txtBoxDolarDolar";
            this.txtBoxDolarDolar.ReadOnly = true;
            this.txtBoxDolarDolar.Size = new System.Drawing.Size(102, 24);
            this.txtBoxDolarDolar.TabIndex = 21;
            // 
            // txtBoxPesoDolar
            // 
            this.txtBoxPesoDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesoDolar.Location = new System.Drawing.Point(388, 179);
            this.txtBoxPesoDolar.Name = "txtBoxPesoDolar";
            this.txtBoxPesoDolar.ReadOnly = true;
            this.txtBoxPesoDolar.Size = new System.Drawing.Size(102, 24);
            this.txtBoxPesoDolar.TabIndex = 22;
            // 
            // txtBoxEuroPeso
            // 
            this.txtBoxEuroPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEuroPeso.Location = new System.Drawing.Point(494, 74);
            this.txtBoxEuroPeso.Name = "txtBoxEuroPeso";
            this.txtBoxEuroPeso.ReadOnly = true;
            this.txtBoxEuroPeso.Size = new System.Drawing.Size(97, 24);
            this.txtBoxEuroPeso.TabIndex = 23;
            // 
            // txtBoxDolarPeso
            // 
            this.txtBoxDolarPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDolarPeso.Location = new System.Drawing.Point(494, 128);
            this.txtBoxDolarPeso.Name = "txtBoxDolarPeso";
            this.txtBoxDolarPeso.ReadOnly = true;
            this.txtBoxDolarPeso.Size = new System.Drawing.Size(97, 24);
            this.txtBoxDolarPeso.TabIndex = 24;
            // 
            // txtBoxPesoPeso
            // 
            this.txtBoxPesoPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesoPeso.Location = new System.Drawing.Point(496, 179);
            this.txtBoxPesoPeso.Name = "txtBoxPesoPeso";
            this.txtBoxPesoPeso.ReadOnly = true;
            this.txtBoxPesoPeso.Size = new System.Drawing.Size(97, 24);
            this.txtBoxPesoPeso.TabIndex = 25;
            // 
            // FormConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 238);
            this.Controls.Add(this.txtBoxPesoPeso);
            this.Controls.Add(this.txtBoxDolarPeso);
            this.Controls.Add(this.txtBoxEuroPeso);
            this.Controls.Add(this.txtBoxPesoDolar);
            this.Controls.Add(this.txtBoxDolarDolar);
            this.Controls.Add(this.txtBoxEuroDolar);
            this.Controls.Add(this.txtBoxPesoEuro);
            this.Controls.Add(this.txtBoxDolarEuro);
            this.Controls.Add(this.txtBoxEuroEuro);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelDolar);
            this.Controls.Add(this.labelEuro);
            this.Controls.Add(this.txtBoxCotiPeso);
            this.Controls.Add(this.txtBoxCotiDolar);
            this.Controls.Add(this.txtBoxCotiEuro);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnEuroConvert);
            this.Controls.Add(this.btnCotizacion);
            this.Controls.Add(this.txtBoxPeso);
            this.Controls.Add(this.txtBoxDolar);
            this.Controls.Add(this.txtBoxEuro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblCotizacion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(619, 277);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(619, 277);
            this.Name = "FormConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtBoxEuro;
        private System.Windows.Forms.TextBox txtBoxDolar;
        private System.Windows.Forms.TextBox txtBoxPeso;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.Button btnEuroConvert;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.TextBox txtBoxCotiEuro;
        private System.Windows.Forms.TextBox txtBoxCotiDolar;
        private System.Windows.Forms.TextBox txtBoxCotiPeso;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox txtBoxEuroEuro;
        private System.Windows.Forms.TextBox txtBoxDolarEuro;
        private System.Windows.Forms.TextBox txtBoxPesoEuro;
        private System.Windows.Forms.TextBox txtBoxEuroDolar;
        private System.Windows.Forms.TextBox txtBoxDolarDolar;
        private System.Windows.Forms.TextBox txtBoxPesoDolar;
        private System.Windows.Forms.TextBox txtBoxEuroPeso;
        private System.Windows.Forms.TextBox txtBoxDolarPeso;
        private System.Windows.Forms.TextBox txtBoxPesoPeso;
        private System.Windows.Forms.ImageList Candados;
    }
}

