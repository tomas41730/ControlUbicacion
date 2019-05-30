using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chachasForm
{
    class UbicacionConductor
    {
        int idConductor;
        double latitud;
        double longitud;
        bool estaDisponible;

      

        public int IdConductor { get => idConductor; set => idConductor = value; }
        public double Latitud { get => latitud; set => latitud = value; }
        public double Longitud { get => longitud; set => longitud = value; }
        public bool EstaDisponible { get => estaDisponible; set => estaDisponible = value; }

        public UbicacionConductor(int idConductor, double latitud, double longitud, bool estaDisponible)
        {
            this.idConductor = idConductor;
            this.latitud = latitud;
            this.longitud = longitud;
            this.estaDisponible = estaDisponible;
        }

        public UbicacionConductor()
        {
        }
    }
}
