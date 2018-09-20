using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.png;)|*.jpg;*.jpeg;*.gif;*.png;";
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
            string conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\TP6_DB.mdb";
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

    }
}
