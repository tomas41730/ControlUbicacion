using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanaPedidosForms
{
    class Pedido
    {
        int idConductor;
        double latitud;
        double longitud;
        bool estado = false;

        public int IdConductor { get => idConductor; set => idConductor = value; }
        public double Latitud { get => latitud; set => latitud = value; }
        public double Longitud { get => longitud; set => longitud = value; }
        public bool Estado { get => estado; set => estado = value; }

        public Pedido(int idConductor, double latitud, double longitud, bool estado)
        {
            this.idConductor = idConductor;
            this.latitud = latitud;
            this.longitud = longitud;
            this.estado = estado;
        }

        public Pedido()
        {
        }
    }
}
