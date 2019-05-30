using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace chachasForm
{
    class MapControl
    {
        public static void ControlDeMapas(GMapControl gMapControl1, GMarkerGoogle marker, GMapOverlay markerOverlay, List<UbicacionConductor> lista)
        {

            markerOverlay = new GMapOverlay("Marcador");
            markerOverlay.Clear();
            foreach (UbicacionConductor ubicacion in lista)
            {
                double lat = ubicacion.Latitud;
                double lng = ubicacion.Longitud;
                if (ubicacion.EstaDisponible == true)
                {
                    marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.green);
                }
                else
                {
                    marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red);
                }

                markerOverlay.Markers.Add(marker);
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Moto # " + ubicacion.IdConductor);

            }

            gMapControl1.Overlays.Add(markerOverlay); //agregamos marcador al mapa
            lista.Clear();

        }

        public static void InicializarMapa(GMapControl gMapControl1)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(-17.396687, -66.217915);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 11;
            gMapControl1.AutoScroll = true;
           
        }
    }
}
