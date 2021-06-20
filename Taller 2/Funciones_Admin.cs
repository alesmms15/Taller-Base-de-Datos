using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_2
{
    public partial class Funciones_Admin : Form
    {
        public Funciones_Admin()
        {
            InitializeComponent();
        }

        private void botonProducto_Click(object sender, EventArgs e)
        {
            Funciones_Producto productoVentana = new Funciones_Producto();
            productoVentana.Show();
        }

        private void botonClientes_Click(object sender, EventArgs e)
        {
            Funciones_Cliente clienteVentana = new Funciones_Cliente();
            clienteVentana.Show();
        }
    }

}
