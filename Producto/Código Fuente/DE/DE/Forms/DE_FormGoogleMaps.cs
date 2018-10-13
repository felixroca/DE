using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
               var point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                // Load Position

                LoadMap(point);

                // Adding Marker
                AddMarker(point);

                //Get Address
                var adress=GetAddress(point);
                if (adress !=null)
                {
                    txt_prueba.Text = String.Join(" , ", adress.ToArray());
                }
                else
                {
                    txt_prueba.Text = "No se puede cargar la direccion";
                }
           
            }

            //List<Placemark> plc = new List<Placemark>();
            //var st = GMapProviders.GoogleMap.GetPlacemarks(gMapControl1.FromLocalToLatLng(e.X, e.Y), out plc);
            //if (st == GeoCoderStatusCode.G_GEO_SUCCESS && plc != null)
            //{
            //    foreach (var pl in plc)
            //    {
            //        if (!string.IsNullOrEmpty(pl.PostalCodeNumber))
            //        {
            //            try
            //            {
            //                string direccion = pl.Address.ToString();
            //                txt_prueba.Text=direccion;

            //                int indiceDeLaComa = direccion.IndexOf(',');
            //                int primerIndice = indiceDeLaComa - 4;
            //                string numero = direccion.Substring(primerIndice, 4);
            //                string numeroFinal = numero.Substring(0, 4);

            //                string calle = direccion.Substring(0, primerIndice);
            //                string ciudad = pl.LocalityName.ToString();

            //                //Pasar los datos al formulario 1
            //                DE_IFormPedido formPedido = (DE_IFormPedido)Application.OpenForms["DE_FormPedido"];
            //                formPedido.ObtenerCalle(calle);
            //                formPedido.ObtenerNumero(numeroFinal);
            //                formPedido.ObtenerCiudad(ciudad);

            //            }



            //            catch(Exception)
            //             {
            //                 MessageBox.Show("No puede obtenerse la dirección, por favor ingrésela en forma textual", "Error",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //             }
         
        }
             
        private void LoadMap(PointLatLng point)
        {
            gMapControl1.Position = point;
        }
        
        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType= GMarkerGoogleType.arrow)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }

        private List<String> GetAddress(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);

            if(statusCode == GeoCoderStatusCode.G_GEO_SUCCESS && placemarks!=null)
            {
                List<String> adress = new List<string>();
                foreach (var placemark in placemarks)
                {
                    adress.Add(placemark.Address);
                }
                return adress;
            }
            return null;
           
        }

        private void gMapControl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }
    }
}
