using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VentanaPedidosForms
{
    class PedidoFireBase
    {
        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "22zOjsDWB5e7SrHmI24ExVpCKh0YPycnGxmVxE6m",
            BasePath = "https://chachas-426fb.firebaseio.com/"
           // AuthSecret = "5cisYCT6AsWxkh2YR50HXvwYXGUbB68n9ARmGD5X",
           // BasePath = "https://chachas-70327.firebaseio.com/"
        };
        static IFirebaseClient client = new FireSharp.FirebaseClient(config);

        public static async void InsertarPedidoAsync(string idConductor, string latitud, string longitud)
        {
            FirebaseResponse resp = await client.GetAsync("ContadorPedido/contador");
            int get = resp.ResultAs<int>();

            var pedido = new Pedido
            {
                IdConductor = Convert.ToInt32(idConductor),
                Latitud = Convert.ToDouble(latitud),
                Longitud = Convert.ToDouble(longitud),
            };
            get++;


            SetResponse response1 = await client.SetAsync("ContadorPedido/contador", get);
            SetResponse response = await client.SetAsync("Pedido/" + get, pedido);
            SetResponse response2 = await client.SetAsync("UbicacionConductor/" + idConductor + "/EstaDisponible", false);
            Pedido result = response.ResultAs<Pedido>();
        }
    }
}

