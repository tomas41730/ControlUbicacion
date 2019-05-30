using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chachasForm
{
    class UbicacionFirebase
    {
        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "5cisYCT6AsWxkh2YR50HXvwYXGUbB68n9ARmGD5X",
            BasePath = "https://chachas-70327.firebaseio.com/"
        };
       static IFirebaseClient client = new FireSharp.FirebaseClient(config);

        public static async void InsertarUbicacionAsync(string idConductor, string latitud, string longitud)
        {
            FirebaseResponse resp = await client.GetAsync("ContadorUbicacion/contador");
            int get = resp.ResultAs<int>();

            var ubicacion = new UbicacionConductor
            {
                IdConductor = Convert.ToInt32(idConductor),
                Latitud = Convert.ToDouble(latitud),
                Longitud = Convert.ToDouble(longitud)
            };
            get++;


            SetResponse response1 = await client.SetAsync("ContadorUbicacion/contador", get);
            SetResponse response = await client.SetAsync("UbicacionConductor/" + get, ubicacion);
            UbicacionConductor result = response.ResultAs<UbicacionConductor>();
        }

        public static async void Export(DataTable dt)
        {
            dt.Rows.Clear();


            int i = 0;
            FirebaseResponse resp1 = await client.GetAsync("ContadorUbicacion/contador");
            int obj1 = resp1.ResultAs<int>();
            int cnt = obj1;

            while (i != cnt)
            {
                i++;
                try
                {
                    FirebaseResponse resp2 = await client.GetAsync("UbicacionConductor/" + i);
                    UbicacionConductor obj2 = resp2.ResultAs<UbicacionConductor>();

                    DataRow row = dt.NewRow();
                    row["Conductor ID"] = obj2.IdConductor;
                    row["Latitud"] = obj2.Latitud;
                    row["Longitud"] = obj2.Longitud;
                    row["Disponible"] = obj2.EstaDisponible;

                    dt.Rows.Add(row);


                }
                catch
                {

                }
            }

        }

        public static async void CargarListaUbicacionesAsync(List<UbicacionConductor> lista)
        {

            int i = 0;
            FirebaseResponse resp1 = await client.GetAsync("ContadorUbicacion/contador");
            int obj1 = resp1.ResultAs<int>();
            int cnt = obj1;

            while (i != cnt)
            {
                i++;
                try
                {
                    FirebaseResponse resp2 = await client.GetAsync("UbicacionConductor/" + i);
                    UbicacionConductor obj2 = resp2.ResultAs<UbicacionConductor>();

                    UbicacionConductor aux = new UbicacionConductor();

                    aux.IdConductor = obj2.IdConductor;
                    aux.Latitud = obj2.Latitud;
                    aux.Longitud = obj2.Longitud;
                    aux.EstaDisponible = obj2.EstaDisponible;

                    lista.Add(aux);
                }
                catch
                {

                }
            }
        }


    }
}
