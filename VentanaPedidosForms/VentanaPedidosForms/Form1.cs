using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPedidosForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PedidoFireBase.InsertarPedidoAsync(txtIdConductor.Text, txtLatitud.Text, txtLongitud.Text);

            txtIdConductor.Clear();
            txtLatitud.Clear();
            txtLongitud.Clear();
        }

        private void txtIdConductor_Enter(object sender, EventArgs e)
        {
            txtIdConductor.Text = "";
            
            
        }

        private void txtLatitud_Enter(object sender, EventArgs e)
        {
            txtLatitud.Text = "";
        }

        private void txtLongitud_Enter(object sender, EventArgs e)
        {
            txtLongitud.Text = "";
        }
    }
}
