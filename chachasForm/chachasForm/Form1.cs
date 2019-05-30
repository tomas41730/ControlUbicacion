using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace chachasForm
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        List<UbicacionConductor> lista = new List<UbicacionConductor>();
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        int timer = 0;
        public Form1()
        {
            InitializeComponent();
            InicializacionDataGridView();
            UbicacionFirebase.Export(dt);
            MapControl.InicializarMapa(gMapControl1);
            MapControl.ControlDeMapas(gMapControl1, marker, markerOverlay, lista);

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConductorFirebase.InsertarConductorAsync("Juan", "Perez", "78787878", "4012-ABC", "juan@gmail.com", 20);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UbicacionFirebase.InsertarUbicacionAsync("2", txtLatitud.Text, txtLongitud.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            // label6.Text = lista.ElementAt(0).Lat.ToString()+"  "+lista.ElementAt(0).Lng.ToString() + Environment.NewLine + lista.ElementAt(1).Lat.ToString() + "  " + lista.ElementAt(1).Lng.ToString();

        }
        private void InicializacionDataGridView()
        {
            dt.Columns.Add("Conductor ID");
            dt.Columns.Add("Latitud");
            dt.Columns.Add("Longitud");
            dt.Columns.Add("Disponible");

            dataGridView1.DataSource = dt;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            label4.Text = timer.ToString();

            if (timer % 5 == 0)
            {

                UbicacionFirebase.CargarListaUbicacionesAsync(lista);
                label6.Text = lista.Count().ToString();
                UbicacionFirebase.Export(dt);
                MapControl.ControlDeMapas(gMapControl1, marker, markerOverlay, lista);
            }
        }

    }
}
