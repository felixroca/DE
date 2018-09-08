using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Diagnostics;

namespace TP6_ISW
{
    public partial class google_maps : Form
    {

        public google_maps()
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


        private void gMapControl1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            }

            List<Placemark> plc = null;
            var st = GMapProviders.GoogleMap.GetPlacemarks(gMapControl1.FromLocalToLatLng(e.X, e.Y), out plc);
            if (st == GeoCoderStatusCode.G_GEO_SUCCESS && plc != null)
            {
                foreach (var pl in plc)
                {
                    if (!string.IsNullOrEmpty(pl.PostalCodeNumber))
                    {

                        string direccion = pl.Address.ToString();

                        int indiceDeLaComa = direccion.IndexOf(',');
                        int primerIndice = indiceDeLaComa - 4;
                        string numero = direccion.Substring(primerIndice, indiceDeLaComa);
                        string numeroFinal = numero.Substring(0, 4);

                        string calle = direccion.Substring(0, primerIndice);
                        string ciudad = pl.DistrictName.ToString();

                      

                        DE_IFORMPEDIDO formPedido = (DE_IFORMPEDIDO)Application.OpenForms["Form1"];
                        formPedido.ObtenerCalle(calle);
                        formPedido.ObtenerNumero(numeroFinal);
                        formPedido.ObtenerCiudad(ciudad);




                    }
                }
            }
        }

        private void btn_agregarUbicacion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
