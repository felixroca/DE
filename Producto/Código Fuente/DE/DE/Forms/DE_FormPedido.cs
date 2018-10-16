
using DE.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE
{
    public partial class DE_FormPedido : Form
    {
        public DE_FormPedido()
        {
            InitializeComponent();
        }

        private void DE_FormPedido_Load(object sender, EventArgs e)
        {
            llenarComboCiudad();
        }

        private void pb_Producto_Click(object sender, EventArgs e)
        {

        }

        private void btn_subirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*)|*.jpg;*";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {

                string path = Path.GetFullPath(opnfd.FileName);
                FileInfo fi = new FileInfo(path);
                double tamañoImagen = fi.Length;

                if (tamañoImagen > 5000000)
                {
                    MessageBox.Show("El tamaño de la imagen debe ser menor a 5MB", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pb_Producto.Image = new Bitmap(opnfd.FileName);
                    pb_Producto.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

        private void llenarComboCiudad()
        {
            DataTable dt = new DataTable();
            string conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Facu\ISW\DE\DE\Producto\Código Fuente\DE\TP6_DB.mdb";
            string consulta = "SELECT * FROM Ciudad";

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = conString;

            OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, connection.ConnectionString);

            connection.Open();
            adapter.Fill(dt);
            cmb_ciudadDomicilio.DataSource = dt;
            cmb_ciudadDomicilio.DisplayMember = "Nombre";
            cmb_ciudadDomicilio.ValueMember = "ID";

        }

        private void rb_pagoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            txt_montoAbonar.Enabled = true;
        }

        private void btn_realizarPedido_Click(object sender, EventArgs e)
        {
            if(rb_tarjetaVisa.Checked==false && rb_pagoEfectivo.Checked==false)
            {
                MessageBox.Show("Debe seleccionar una forma de pago", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_montoAbonar.Text == "" && rb_pagoEfectivo.Checked == true)
            {
                MessageBox.Show("Debe especificar el monto con el que abonará", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_montoAbonar.Focus();
            }

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Facu\ISW\DE\DE\Producto\Código Fuente\DE\TP6_DB.mdb";

            try
            {
                conn.Open();
                String NombreProducto = txt_prodDeseado.Text.ToString();
                String CalleComercio = txt_calle.Text.ToString();
                String NumeroCalleComercio = txt_numero.Text.ToString();
                String CiudadComercio = txt_ciudad.Text.ToString();

                String ReferenciaComercio = "Vacio";
                if (txt_referencia.Text!="")
                {
                    ReferenciaComercio = txt_referencia.Text.ToString();
                }
              
                
                String CalleDomicilio = txt_calleDomicilio.Text.ToString();
                String NumeroCalleDomicilio = txt_NumeroDomicilio.Text.ToString();
                String CiudadDomicilio = "";
                int CiudadDomicilioCB = int.Parse(cmb_ciudadDomicilio.SelectedValue.ToString());

                switch (CiudadDomicilioCB)
                {
                    case 1:
                        CiudadDomicilio = "Ciudad de Cordoba";
                        break;
                    case 2:
                        CiudadDomicilio = "Villa Carlos Paz";
                        break;
                    case 3:
                        CiudadDomicilio = "Alta Gracia";
                        break;
                    case 4:
                        CiudadDomicilio = "Cosquin";
                        break;
                    case 5:
                        CiudadDomicilio = "Villa Maria";
                        break;
                    case 6:
                        CiudadDomicilio = "Jesus Maria";
                        break;
                    case 7:
                        CiudadDomicilio = "La Falda";
                        break;
                    case 8:
                        CiudadDomicilio = "San Francisco";
                        break;
                    case 9:
                        CiudadDomicilio = "Capilla del Monte";
                        break;
                    case 10:
                        CiudadDomicilio = "Rio Cuarto";
                        break;
                }

                String ReferenciaDomicilio = "Vacio";
                if (textBox1.Text!="")
                {
                   ReferenciaDomicilio = textBox1.Text.ToString();
                }

                String FormaDePago = "Tarjeta Visa";

                if (rb_tarjetaVisa.Checked==true)
                {
                     FormaDePago = "Tarjeta Visa";
                }
                else
                {
                     FormaDePago = "Efectivo";
                }

                String LoAntesPosible = "Lo antes posible";
                String FechaRecepcio = "Vacio";
                String HoraRecepcion = "Vacio";
                if (rb_loAntesPosible.Checked == true)
                {
                   LoAntesPosible = "Lo Antes Posible";
                    FechaRecepcio = "Vacio";
                     HoraRecepcion = "Vacio";
                }
                else
                {
                    LoAntesPosible = "Recepcion Programada";
                    FechaRecepcio = txt_fecha.Text.ToString();
                     HoraRecepcion = txt_hora.Text.ToString();
                }
                

                String my_querry = "INSERT INTO Pedido(NombreProducto,CalleComercio,NumeroCalleComercio,CiudadComercio,ReferenciaComercio, CalleDomicilio, NumeroCalleDomicilio, CiudadDomicilio,ReferenciaDomicilio,FormaDePago,LoAntesPosible,FechaRecepcio,HoraRecepcion) " +
                    "VALUES('" + NombreProducto + "','" + CalleComercio + "','" + NumeroCalleComercio + "','" + CiudadComercio + "','" +  ReferenciaComercio + "','" + CalleDomicilio + "','" + NumeroCalleDomicilio + "','" + CiudadDomicilio + "','" + ReferenciaDomicilio + "','" + FormaDePago + "','" + LoAntesPosible + "','" + FechaRecepcio + "','" + HoraRecepcion + "')";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Su pedido ha sido registrado correctamente...!");

                DE_FormResumenPedido resumenFormPedido;

                resumenFormPedido = new DE_FormResumenPedido();

                resumenFormPedido.Show();
            }
            catch (Exception ex)
            {
            
            }
            finally
            {
                conn.Close();
            }            
        }

        private void rb_tarjetaVisa_CheckedChanged(object sender, EventArgs e)
        {
            txt_montoAbonar.Enabled = false;
        }

        private void rb_pagoEfectivo_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_montoAbonar.Enabled = true;
        }

        private void rb_loAntesPosible_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.Enabled = false;
            txt_hora.Enabled = false;
        }

        private void rb_programarRecepcion_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.Enabled = true;
            txt_hora.Enabled = true;
        }

        private void btn_googleMaps_Click(object sender, EventArgs e)
        {
            DE_FormGoogleMaps googleForm;

            googleForm = new DE_FormGoogleMaps();

            googleForm.Show();
        }

        private void txt_prodDeseado_Leave(object sender, EventArgs e)
        {
            if (txt_prodDeseado.Text == "")
            {
                MessageBox.Show("Debe especificar el nombre del producto", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_prodDeseado.Focus();
            }
            if (Regex.IsMatch(txt_prodDeseado.Text, @"[(.*?%&$#¡¿!+-/|¬@\}{;:=)]"))
            {
                MessageBox.Show("El nombre del producto debe contener solo letras y numeros", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_prodDeseado.Focus();
            }
        }

        private void txt_numero_Leave(object sender, EventArgs e)
        {
            int bandera = 0;
            if (txt_numero.Text == "")
            {
                MessageBox.Show("Debe indicar el numero de la dirección del comercio", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numero.Focus();
                bandera = 1;
            }
            if (!Regex.IsMatch(txt_numero.Text, @"[0-9]") && bandera==0)
            {
                MessageBox.Show("El numero de la calle es incorrecto", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numero.Text = "";
                txt_numero.Focus();
            }
        }

        private void txt_calle_Leave(object sender, EventArgs e)
        {
            if (txt_calle.Text == "")
            {
                MessageBox.Show("Debe indicar el nombre de la calle del comercio", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_calle.Focus();
            }
        }

        private void txt_ciudad_Leave(object sender, EventArgs e)
        {
            if (txt_ciudad.Text == "")
            {
                MessageBox.Show("Debe indicar el nombre de la ciudad del comercio", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ciudad.Focus();
            }
        }

        private void txt_calleDomicilio_Leave(object sender, EventArgs e)
        {
            if (txt_calleDomicilio.Text == "")
            {
                MessageBox.Show("Debe indicar el nombre de la calle del domicilio", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_calleDomicilio.Focus();
            }
           
        }

        private void txt_NumeroDomicilio_Leave(object sender, EventArgs e)
        {
            if (txt_NumeroDomicilio.Text == "")
            {
                MessageBox.Show("Debe indicar el numero de la calle del domicilio", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NumeroDomicilio.Focus();
            }
        }

        private void txt_fecha_Leave(object sender, EventArgs e)
        {
            int bandera = 0;

            if (!Regex.IsMatch(txt_fecha.Text, @"[\d{2}.\d{2}.\d{4}]")) 
            {
                MessageBox.Show("La fecha no es correcta, debe indicarse como dd/mm/aaaa", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                bandera = 1;
            }
            if (Regex.IsMatch(txt_fecha.Text, @"[a-z]") && bandera ==0)
            {
                
            }
                
            if(Regex.IsMatch(txt_fecha.Text, @"[\d{2}.\d{2}.\d{4}]"))
            {
                DateTime fechaEntrega = new DateTime();
                try
                {
                    fechaEntrega = Convert.ToDateTime(txt_fecha.Text);
                    DateTime fechaActual = System.DateTime.Now;
                    if (DateTime.Compare(fechaEntrega.Date, fechaActual.Date) < 0)
                    {
                        MessageBox.Show("La fecha de entrega no puede ser menor a la fecha actual", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("La fecha no es correcta, debe indicarse como dd/mm/aaaa", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                

        

        }

        private void txt_hora_Leave(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txt_hora.Text, @"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$"))
            {
                MessageBox.Show("La hora no es correcta, debe indicarse como hh:mm", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hora.Focus();
            }
        }

        private void txt_montoAbonar_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_montoAbonar.Text, @"[0-9]") || Regex.IsMatch(txt_montoAbonar.Text, @"[.,-]"))
            {
                MessageBox.Show("El monto es incorrecto debe indicar valores enteros. Ej: 200", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_montoAbonar.Focus();
            }
        }
    }
    
}
