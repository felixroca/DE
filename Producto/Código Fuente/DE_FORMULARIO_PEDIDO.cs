using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6_ISW
{

    public partial class DE_FORMULARIO_PEDIDO : Form, DE_IFORMPEDIDO
    {
        

        public DE_FORMULARIO_PEDIDO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_googleMaps_Click(object sender, EventArgs e)
        {
            google_maps googleForm;

            googleForm = new google_maps();

            googleForm.Show();
        }

        void DE_IFORMPEDIDO.ObtenerCalle(string calle)
        {
            txt_calle.Text = calle;
        }

        void DE_IFORMPEDIDO.ObtenerNumero(string numero)
        {
            txt_numero.Text = numero;
        }

        void DE_IFORMPEDIDO.ObtenerCiudad(string ciudad)
        {
            txt_ciudad.Text = ciudad;
        }
    }
}
