
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE.Forms
{
    public partial class DE_FormResumenPedido : Form
    {
        public DE_FormResumenPedido()
        {
            InitializeComponent();
        }

        private void DE_FormResumenPedido_Load(object sender, EventArgs e)
        {
            DataTable id = new DataTable();
            DataGridView prod = new DataGridView();
                 DataTable dt = new DataTable();
                string conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Facu\ISW\DE\DE\Producto\Código Fuente\DE\DE\TP6_DB.mdb";
                string consulta = "SELECT ID FROM Pedido";

                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = conString;

                OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, connection.ConnectionString);

            connection.Open();
            adapter.Fill(id);

           

            int cantDeFilas = id.Rows.Count;

            int idAbuscar = 53 + cantDeFilas;

            string consulta2 = "SELECT * FROM Pedido WHERE ID="+idAbuscar;
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(consulta2, connection.ConnectionString);

            adapter2.Fill(dt);

            DataRow row = dt.Rows[0];
            lbl_nombreProductoCambiar.Text = row["NombreProducto"].ToString();
            lbl_domicilioCombiar.Text = row["CalleComercio"].ToString() + " " + row["NumeroCalleComercio"].ToString();
            lbl_domicilioClienteCambiar.Text = row["CalleDomicilio"].ToString() + " " + row["NumeroCalleDomicilio"].ToString();

            if (row["LoAntesPosible"].ToString()=="Recepcion Programada")
            {
                lbl_entregaCambiar.Text = row["FechaRecepcio"].ToString() + " " + row["HoraRecepcion"].ToString();
                
            }
            else
            {
                lbl_entregaCambiar.Text = "Lo antes posible";
            }


        }

        private void lbl_fechaCambiarPorLoAntesPosible_Click(object sender, EventArgs e)
        {

        }
    }
}
