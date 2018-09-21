using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE
{
    public partial class DE_FormGoogleMaps : Form
    {
        public DE_FormGoogleMaps()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(-31.3993438, -64.3344307);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
        }

        private void gMapControl1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            }

            List<Placemark> plc = new List<Placemark>();
            var st = GMapProviders.GoogleMap.GetPlacemarks(gMapControl1.FromLocalToLatLng(e.X, e.Y), out plc);
            if (st == GeoCoderStatusCode.G_GEO_SUCCESS && plc != null)
            {
                foreach (var pl in plc)
                {
                    if (!string.IsNullOrEmpty(pl.PostalCodeNumber))
                    {
                        try
                        {
                            string direccion = pl.Address.ToString();

                            int indiceDeLaComa = direccion.IndexOf(',');
                            int primerIndice = indiceDeLaComa - 4;
                            string numero = direccion.Substring(primerIndice, 4);
                            string numeroFinal = numero.Substring(0, 4);

                            string calle = direccion.Substring(0, primerIndice);
                            string ciudad = pl.LocalityName.ToString();

                            //Pasar los datos al formulario 1
                            DE_IFormPedido formPedido = (DE_IFormPedido)Application.OpenForms["DE_FormPedido"];
                            formPedido.ObtenerCalle(calle);
                            formPedido.ObtenerNumero(numeroFinal);
                            formPedido.ObtenerCiudad(ciudad);

                        }
                      


                        catch(Exception)
                         {
                             MessageBox.Show("No puede obtenerse la dirección, por favor ingrésela en forma textual", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    }
                }
            }
        }
    }
}
