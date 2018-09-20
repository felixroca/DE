namespace DE
{
    partial class DE_FormPedido
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
            this.btn_subirImagen = new System.Windows.Forms.Button();
            this.pb_Producto = new System.Windows.Forms.PictureBox();
            this.txt_prodDeseado = new System.Windows.Forms.TextBox();
            this.lbl_prodDeseado = new System.Windows.Forms.Label();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.rb_programarRecepcion = new System.Windows.Forms.RadioButton();
            this.rb_loAntesPosible = new System.Windows.Forms.RadioButton();
            this.btn_realizarPedido = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_pagoEfectivo = new System.Windows.Forms.RadioButton();
            this.lbl_montoAbonar = new System.Windows.Forms.Label();
            this.lbl_pesos = new System.Windows.Forms.Label();
            this.rb_tarjetaVisa = new System.Windows.Forms.RadioButton();
            this.txt_montoAbonar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_ciudadDomicilio = new System.Windows.Forms.ComboBox();
            this.lbl_CiudadDomicilio = new System.Windows.Forms.Label();
            this.txt_NumeroDomicilio = new System.Windows.Forms.TextBox();
            this.lbl_numeroDomicilio = new System.Windows.Forms.Label();
            this.txt_calleDomicilio = new System.Windows.Forms.TextBox();
            this.lbl_CalleDomicilio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Producto)).BeginInit();
            this.gb_datosComercio.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(138, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(189, 13);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Realizar Pedido de \"lo que sea\"";
            // 
            // btn_subirImagen
            // 
            this.btn_subirImagen.Location = new System.Drawing.Point(32, 83);
            this.btn_subirImagen.Name = "btn_subirImagen";
            this.btn_subirImagen.Size = new System.Drawing.Size(103, 23);
            this.btn_subirImagen.TabIndex = 9;
            this.btn_subirImagen.Text = "Subir Imagen";
            this.btn_subirImagen.UseVisualStyleBackColor = true;
            this.btn_subirImagen.Click += new System.EventHandler(this.btn_subirImagen_Click);
            // 
            // pb_Producto
            // 
            this.pb_Producto.Location = new System.Drawing.Point(202, 83);
            this.pb_Producto.Name = "pb_Producto";
            this.pb_Producto.Size = new System.Drawing.Size(207, 131);
            this.pb_Producto.TabIndex = 8;
            this.pb_Producto.TabStop = false;
            this.pb_Producto.Click += new System.EventHandler(this.pb_Producto_Click);
            // 
            // txt_prodDeseado
            // 
            this.txt_prodDeseado.Location = new System.Drawing.Point(202, 51);
            this.txt_prodDeseado.Name = "txt_prodDeseado";
            this.txt_prodDeseado.Size = new System.Drawing.Size(207, 20);
            this.txt_prodDeseado.TabIndex = 7;
            // 
            // lbl_prodDeseado
            // 
            this.lbl_prodDeseado.AutoSize = true;
            this.lbl_prodDeseado.Location = new System.Drawing.Point(29, 51);
            this.lbl_prodDeseado.Name = "lbl_prodDeseado";
            this.lbl_prodDeseado.Size = new System.Drawing.Size(148, 13);
            this.lbl_prodDeseado.TabIndex = 6;
            this.lbl_prodDeseado.Text = "Especificar producto deseado";
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
            this.gb_datosComercio.Location = new System.Drawing.Point(32, 220);
            this.gb_datosComercio.Name = "gb_datosComercio";
            this.gb_datosComercio.Size = new System.Drawing.Size(380, 138);
            this.gb_datosComercio.TabIndex = 10;
            this.gb_datosComercio.TabStop = false;
            this.gb_datosComercio.Text = "Datos de Comercio";
            // 
            // btn_googleMaps
            // 
            this.btn_googleMaps.Location = new System.Drawing.Point(137, 109);
            this.btn_googleMaps.Name = "btn_googleMaps";
            this.btn_googleMaps.Size = new System.Drawing.Size(103, 23);
            this.btn_googleMaps.TabIndex = 8;
            this.btn_googleMaps.Text = "Google Maps";
            this.btn_googleMaps.UseVisualStyleBackColor = true;
            // 
            // lbl_referencia
            // 
            this.lbl_referencia.AutoSize = true;
            this.lbl_referencia.Location = new System.Drawing.Point(194, 76);
            this.lbl_referencia.Name = "lbl_referencia";
            this.lbl_referencia.Size = new System.Drawing.Size(59, 13);
            this.lbl_referencia.TabIndex = 7;
            this.lbl_referencia.Text = "Referencia";
            // 
            // txt_referencia
            // 
            this.txt_referencia.Location = new System.Drawing.Point(259, 73);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(100, 20);
            this.txt_referencia.TabIndex = 6;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(54, 73);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(100, 20);
            this.txt_ciudad.TabIndex = 5;
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(6, 76);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 4;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(259, 32);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 3;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AllowDrop = true;
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(194, 35);
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
            this.lbl_Calle.Location = new System.Drawing.Point(6, 35);
            this.lbl_Calle.Name = "lbl_Calle";
            this.lbl_Calle.Size = new System.Drawing.Size(30, 13);
            this.lbl_Calle.TabIndex = 0;
            this.lbl_Calle.Text = "Calle";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_hora);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_fecha);
            this.groupBox4.Controls.Add(this.lbl_fecha);
            this.groupBox4.Controls.Add(this.rb_programarRecepcion);
            this.groupBox4.Controls.Add(this.rb_loAntesPosible);
            this.groupBox4.Location = new System.Drawing.Point(32, 557);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 124);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cuando quieres recibir el pedido?";
            // 
            // txt_hora
            // 
            this.txt_hora.Enabled = false;
            this.txt_hora.Location = new System.Drawing.Point(256, 95);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(115, 20);
            this.txt_hora.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(256, 61);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(115, 20);
            this.txt_fecha.TabIndex = 3;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(215, 64);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "Fecha";
            // 
            // rb_programarRecepcion
            // 
            this.rb_programarRecepcion.AutoSize = true;
            this.rb_programarRecepcion.Location = new System.Drawing.Point(197, 28);
            this.rb_programarRecepcion.Name = "rb_programarRecepcion";
            this.rb_programarRecepcion.Size = new System.Drawing.Size(123, 17);
            this.rb_programarRecepcion.TabIndex = 1;
            this.rb_programarRecepcion.TabStop = true;
            this.rb_programarRecepcion.Text = "Programar recepción";
            this.rb_programarRecepcion.UseVisualStyleBackColor = true;
            this.rb_programarRecepcion.CheckedChanged += new System.EventHandler(this.rb_programarRecepcion_CheckedChanged);
            // 
            // rb_loAntesPosible
            // 
            this.rb_loAntesPosible.AutoSize = true;
            this.rb_loAntesPosible.Checked = true;
            this.rb_loAntesPosible.Location = new System.Drawing.Point(18, 28);
            this.rb_loAntesPosible.Name = "rb_loAntesPosible";
            this.rb_loAntesPosible.Size = new System.Drawing.Size(102, 17);
            this.rb_loAntesPosible.TabIndex = 0;
            this.rb_loAntesPosible.TabStop = true;
            this.rb_loAntesPosible.Text = "Lo antes posible";
            this.rb_loAntesPosible.UseVisualStyleBackColor = true;
            this.rb_loAntesPosible.CheckedChanged += new System.EventHandler(this.rb_loAntesPosible_CheckedChanged);
            // 
            // btn_realizarPedido
            // 
            this.btn_realizarPedido.Location = new System.Drawing.Point(164, 693);
            this.btn_realizarPedido.Name = "btn_realizarPedido";
            this.btn_realizarPedido.Size = new System.Drawing.Size(103, 23);
            this.btn_realizarPedido.TabIndex = 18;
            this.btn_realizarPedido.Text = "Realizar Pedido!";
            this.btn_realizarPedido.UseVisualStyleBackColor = true;
            this.btn_realizarPedido.Click += new System.EventHandler(this.btn_realizarPedido_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_pagoEfectivo);
            this.groupBox2.Controls.Add(this.lbl_montoAbonar);
            this.groupBox2.Controls.Add(this.lbl_pesos);
            this.groupBox2.Controls.Add(this.rb_tarjetaVisa);
            this.groupBox2.Controls.Add(this.txt_montoAbonar);
            this.groupBox2.Location = new System.Drawing.Point(32, 461);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 96);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma de Pago";
            // 
            // rb_pagoEfectivo
            // 
            this.rb_pagoEfectivo.AutoSize = true;
            this.rb_pagoEfectivo.Location = new System.Drawing.Point(194, 31);
            this.rb_pagoEfectivo.Name = "rb_pagoEfectivo";
            this.rb_pagoEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rb_pagoEfectivo.TabIndex = 8;
            this.rb_pagoEfectivo.TabStop = true;
            this.rb_pagoEfectivo.Text = "Efectivo";
            this.rb_pagoEfectivo.UseVisualStyleBackColor = true;
            this.rb_pagoEfectivo.CheckedChanged += new System.EventHandler(this.rb_pagoEfectivo_CheckedChanged_1);
            // 
            // lbl_montoAbonar
            // 
            this.lbl_montoAbonar.AutoSize = true;
            this.lbl_montoAbonar.Location = new System.Drawing.Point(191, 51);
            this.lbl_montoAbonar.Name = "lbl_montoAbonar";
            this.lbl_montoAbonar.Size = new System.Drawing.Size(180, 13);
            this.lbl_montoAbonar.TabIndex = 10;
            this.lbl_montoAbonar.Text = "Indique el monto con el que abonará";
            // 
            // lbl_pesos
            // 
            this.lbl_pesos.AutoSize = true;
            this.lbl_pesos.Location = new System.Drawing.Point(237, 73);
            this.lbl_pesos.Name = "lbl_pesos";
            this.lbl_pesos.Size = new System.Drawing.Size(13, 13);
            this.lbl_pesos.TabIndex = 12;
            this.lbl_pesos.Text = "$";
            // 
            // rb_tarjetaVisa
            // 
            this.rb_tarjetaVisa.AutoSize = true;
            this.rb_tarjetaVisa.Location = new System.Drawing.Point(18, 31);
            this.rb_tarjetaVisa.Name = "rb_tarjetaVisa";
            this.rb_tarjetaVisa.Size = new System.Drawing.Size(81, 17);
            this.rb_tarjetaVisa.TabIndex = 9;
            this.rb_tarjetaVisa.TabStop = true;
            this.rb_tarjetaVisa.Text = "Tarjeta Visa";
            this.rb_tarjetaVisa.UseVisualStyleBackColor = true;
            this.rb_tarjetaVisa.CheckedChanged += new System.EventHandler(this.rb_tarjetaVisa_CheckedChanged);
            // 
            // txt_montoAbonar
            // 
            this.txt_montoAbonar.Enabled = false;
            this.txt_montoAbonar.Location = new System.Drawing.Point(256, 70);
            this.txt_montoAbonar.Name = "txt_montoAbonar";
            this.txt_montoAbonar.Size = new System.Drawing.Size(115, 20);
            this.txt_montoAbonar.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmb_ciudadDomicilio);
            this.groupBox1.Controls.Add(this.lbl_CiudadDomicilio);
            this.groupBox1.Controls.Add(this.txt_NumeroDomicilio);
            this.groupBox1.Controls.Add(this.lbl_numeroDomicilio);
            this.groupBox1.Controls.Add(this.txt_calleDomicilio);
            this.groupBox1.Controls.Add(this.lbl_CalleDomicilio);
            this.groupBox1.Location = new System.Drawing.Point(32, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 95);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del domicilio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Referencia";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 10;
            // 
            // cmb_ciudadDomicilio
            // 
            this.cmb_ciudadDomicilio.FormattingEnabled = true;
            this.cmb_ciudadDomicilio.Location = new System.Drawing.Point(54, 67);
            this.cmb_ciudadDomicilio.Name = "cmb_ciudadDomicilio";
            this.cmb_ciudadDomicilio.Size = new System.Drawing.Size(121, 21);
            this.cmb_ciudadDomicilio.TabIndex = 9;
            // 
            // lbl_CiudadDomicilio
            // 
            this.lbl_CiudadDomicilio.AutoSize = true;
            this.lbl_CiudadDomicilio.Location = new System.Drawing.Point(6, 70);
            this.lbl_CiudadDomicilio.Name = "lbl_CiudadDomicilio";
            this.lbl_CiudadDomicilio.Size = new System.Drawing.Size(40, 13);
            this.lbl_CiudadDomicilio.TabIndex = 8;
            this.lbl_CiudadDomicilio.Text = "Ciudad";
            // 
            // txt_NumeroDomicilio
            // 
            this.txt_NumeroDomicilio.Location = new System.Drawing.Point(259, 28);
            this.txt_NumeroDomicilio.Name = "txt_NumeroDomicilio";
            this.txt_NumeroDomicilio.Size = new System.Drawing.Size(112, 20);
            this.txt_NumeroDomicilio.TabIndex = 7;
            // 
            // lbl_numeroDomicilio
            // 
            this.lbl_numeroDomicilio.AllowDrop = true;
            this.lbl_numeroDomicilio.AutoSize = true;
            this.lbl_numeroDomicilio.Location = new System.Drawing.Point(194, 31);
            this.lbl_numeroDomicilio.Name = "lbl_numeroDomicilio";
            this.lbl_numeroDomicilio.Size = new System.Drawing.Size(44, 13);
            this.lbl_numeroDomicilio.TabIndex = 6;
            this.lbl_numeroDomicilio.Text = "Numero";
            // 
            // txt_calleDomicilio
            // 
            this.txt_calleDomicilio.Location = new System.Drawing.Point(54, 28);
            this.txt_calleDomicilio.Name = "txt_calleDomicilio";
            this.txt_calleDomicilio.Size = new System.Drawing.Size(121, 20);
            this.txt_calleDomicilio.TabIndex = 5;
            // 
            // lbl_CalleDomicilio
            // 
            this.lbl_CalleDomicilio.AutoSize = true;
            this.lbl_CalleDomicilio.Location = new System.Drawing.Point(8, 31);
            this.lbl_CalleDomicilio.Name = "lbl_CalleDomicilio";
            this.lbl_CalleDomicilio.Size = new System.Drawing.Size(30, 13);
            this.lbl_CalleDomicilio.TabIndex = 4;
            this.lbl_CalleDomicilio.Text = "Calle";
            // 
            // DE_FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(437, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_realizarPedido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_datosComercio);
            this.Controls.Add(this.btn_subirImagen);
            this.Controls.Add(this.pb_Producto);
            this.Controls.Add(this.txt_prodDeseado);
            this.Controls.Add(this.lbl_prodDeseado);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "DE_FormPedido";
            this.Text = "Realizar Pedido";
            this.Load += new System.EventHandler(this.DE_FormPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Producto)).EndInit();
            this.gb_datosComercio.ResumeLayout(false);
            this.gb_datosComercio.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_subirImagen;
        private System.Windows.Forms.PictureBox pb_Producto;
        private System.Windows.Forms.TextBox txt_prodDeseado;
        private System.Windows.Forms.Label lbl_prodDeseado;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.RadioButton rb_programarRecepcion;
        private System.Windows.Forms.RadioButton rb_loAntesPosible;
        private System.Windows.Forms.Button btn_realizarPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_pagoEfectivo;
        private System.Windows.Forms.Label lbl_montoAbonar;
        private System.Windows.Forms.Label lbl_pesos;
        private System.Windows.Forms.RadioButton rb_tarjetaVisa;
        private System.Windows.Forms.TextBox txt_montoAbonar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmb_ciudadDomicilio;
        private System.Windows.Forms.Label lbl_CiudadDomicilio;
        private System.Windows.Forms.TextBox txt_NumeroDomicilio;
        private System.Windows.Forms.Label lbl_numeroDomicilio;
        private System.Windows.Forms.TextBox txt_calleDomicilio;
        private System.Windows.Forms.Label lbl_CalleDomicilio;
    }
}

