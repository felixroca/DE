namespace TP6_ISW
{
    partial class DE_FORMULARIO_PEDIDO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_prodDeseado = new System.Windows.Forms.Label();
            this.txt_prodDeseado = new System.Windows.Forms.TextBox();
            this.gb_datosComercio = new System.Windows.Forms.GroupBox();
            this.btn_googleMaps = new System.Windows.Forms.Button();
            this.lbl_referencia = new System.Windows.Forms.Label();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.lbl_Calle = new System.Windows.Forms.Label();
            this.gb_datosComercio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(105, 30);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(189, 13);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Realizar Pedido de \"lo que sea\"";
            this.lbl_titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_prodDeseado
            // 
            this.lbl_prodDeseado.AutoSize = true;
            this.lbl_prodDeseado.Location = new System.Drawing.Point(12, 75);
            this.lbl_prodDeseado.Name = "lbl_prodDeseado";
            this.lbl_prodDeseado.Size = new System.Drawing.Size(148, 13);
            this.lbl_prodDeseado.TabIndex = 1;
            this.lbl_prodDeseado.Text = "Especificar producto deseado";
            // 
            // txt_prodDeseado
            // 
            this.txt_prodDeseado.Location = new System.Drawing.Point(185, 72);
            this.txt_prodDeseado.Name = "txt_prodDeseado";
            this.txt_prodDeseado.Size = new System.Drawing.Size(207, 20);
            this.txt_prodDeseado.TabIndex = 2;
            // 
            // gb_datosComercio
            // 
            this.gb_datosComercio.Controls.Add(this.btn_googleMaps);
            this.gb_datosComercio.Controls.Add(this.lbl_referencia);
            this.gb_datosComercio.Controls.Add(this.txt_referencia);
            this.gb_datosComercio.Controls.Add(this.txt_ciudad);
            this.gb_datosComercio.Controls.Add(this.lbl_ciudad);
            this.gb_datosComercio.Controls.Add(this.txt_numero);
            this.gb_datosComercio.Controls.Add(this.lbl_numero);
            this.gb_datosComercio.Controls.Add(this.txt_calle);
            this.gb_datosComercio.Controls.Add(this.lbl_Calle);
            this.gb_datosComercio.Location = new System.Drawing.Point(15, 115);
            this.gb_datosComercio.Name = "gb_datosComercio";
            this.gb_datosComercio.Size = new System.Drawing.Size(377, 170);
            this.gb_datosComercio.TabIndex = 3;
            this.gb_datosComercio.TabStop = false;
            this.gb_datosComercio.Text = "Datos de Comercio";
            // 
            // btn_googleMaps
            // 
            this.btn_googleMaps.Location = new System.Drawing.Point(137, 101);
            this.btn_googleMaps.Name = "btn_googleMaps";
            this.btn_googleMaps.Size = new System.Drawing.Size(103, 23);
            this.btn_googleMaps.TabIndex = 8;
            this.btn_googleMaps.Text = "Google Maps";
            this.btn_googleMaps.UseVisualStyleBackColor = true;
            this.btn_googleMaps.Click += new System.EventHandler(this.btn_googleMaps_Click);
            // 
            // lbl_referencia
            // 
            this.lbl_referencia.AutoSize = true;
            this.lbl_referencia.Location = new System.Drawing.Point(194, 64);
            this.lbl_referencia.Name = "lbl_referencia";
            this.lbl_referencia.Size = new System.Drawing.Size(59, 13);
            this.lbl_referencia.TabIndex = 7;
            this.lbl_referencia.Text = "Referencia";
            // 
            // txt_referencia
            // 
            this.txt_referencia.Location = new System.Drawing.Point(261, 61);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(100, 20);
            this.txt_referencia.TabIndex = 6;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(54, 58);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(100, 20);
            this.txt_ciudad.TabIndex = 5;
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(8, 61);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 4;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(261, 32);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 3;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AllowDrop = true;
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(196, 35);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 2;
            this.lbl_numero.Text = "Numero";
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(54, 32);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(100, 20);
            this.txt_calle.TabIndex = 1;
            // 
            // lbl_Calle
            // 
            this.lbl_Calle.AutoSize = true;
            this.lbl_Calle.Location = new System.Drawing.Point(8, 35);
            this.lbl_Calle.Name = "lbl_Calle";
            this.lbl_Calle.Size = new System.Drawing.Size(30, 13);
            this.lbl_Calle.TabIndex = 0;
            this.lbl_Calle.Text = "Calle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 297);
            this.Controls.Add(this.gb_datosComercio);
            this.Controls.Add(this.txt_prodDeseado);
            this.Controls.Add(this.lbl_prodDeseado);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_datosComercio.ResumeLayout(false);
            this.gb_datosComercio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_prodDeseado;
        private System.Windows.Forms.TextBox txt_prodDeseado;
        private System.Windows.Forms.GroupBox gb_datosComercio;
        private System.Windows.Forms.Button btn_googleMaps;
        private System.Windows.Forms.Label lbl_referencia;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.Label lbl_Calle;
    }
}

