using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chachasForm
{
    class ConductorFirebase
    {
        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "5cisYCT6AsWxkh2YR50HXvwYXGUbB68n9ARmGD5X",
            BasePath = "https://chachas-70327.firebaseio.com/"
        };
        static IFirebaseClient client = new FireSharp.FirebaseClient(config);

        public static async void InsertarConductorAsync(string nombre, string apellido, string celular, string placa, string email, int edad)
        {
            FirebaseResponse resp = await client.GetAsync("ContadorConductor/contador");
            int get = resp.ResultAs<int>();
            get++;
            var conductor = new Conductor
            {
                Codigo = get,
                Nombre = nombre,
                Apellido = apellido,
                Celular = celular,
                NumeroPlaca = placa,
                Email = email,
                Edad = edad,

            };
            
            

            SetResponse response1 = await client.SetAsync("ContadorConductor/contador", get);
            SetResponse response = await client.SetAsync("Conductor/" + get, conductor);
            Conductor result = response.ResultAs<Conductor>();
        }
    }
}
