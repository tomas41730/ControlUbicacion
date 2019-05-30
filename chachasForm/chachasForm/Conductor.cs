using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chachasForm
{
    class Conductor
    {
        int codigo;
        string nombre;
        string apellido;
        string celular;
        string numeroPlaca;
        string email;
        int edad;
        
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Celular { get => celular; set => celular = value; }
        public string NumeroPlaca { get => numeroPlaca; set => numeroPlaca = value; }
        public string Email { get => email; set => email = value; }
        public int Edad { get => edad; set => edad = value; }

        public Conductor(int codigo, string nombre, string apellido, string celular, string numeroPlaca, string email, int edad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.numeroPlaca = numeroPlaca;
            this.email = email;
            this.edad = edad;
        }

        public Conductor()
        {
        }
    }
}
