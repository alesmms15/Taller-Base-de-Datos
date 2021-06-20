using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Taller_2
{
    public partial class Listados_clientes : Form
    {
        public Listados_clientes()
        {
            InitializeComponent();
        }

        private void listadoNacionales_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string seleccionNacional = "SELECT id_cliente AS \"ID del Cliente\", codigo_nacional AS \"Codigo del Cliente Nacional\", nombre AS \"Nombre\", ciudad AS \"Ciudad\" FROM  cliente  INNER JOIN cliente_nacional ON cliente.id_cliente=cliente_nacional.clienteid_cliente WHERE cliente.desactivado_c=0 ";
                DataTable tabla = conex.selectQuery(seleccionNacional);
                dataGridView_clientesNacionales.DataSource = tabla;

                conex.close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void listadoExtranjeros_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string seleccionExtranjeros = "SELECT id_cliente AS \"ID del cliente\", codigo_extranjero AS \"Código del Cliente extranjero\", nombre AS \"Nombre\", ciudad AS \"Ciudad\" FROM  cliente  INNER JOIN cliente_extranjero ON cliente.id_cliente=cliente_extranjero.clienteid_cliente WHERE cliente.desactivado_c=0";
                DataTable tabla = conex.selectQuery(seleccionExtranjeros);
                dataGridView_clientesExtranjeros.DataSource = tabla;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void listadoClientes_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string seleccionClientes = "SELECT cliente.id_cliente AS \"ID del Cliente\", cliente_extranjero.nombre AS \"Nombre Cliente Extranjero\", cliente_nacional.nombre AS \"Nombre Cliente Nacional\" FROM  cliente LEFT JOIN cliente_nacional  ON cliente_nacional.clienteid_cliente=cliente.id_cliente LEFT JOIN cliente_extranjero ON cliente_extranjero.clienteid_cliente=cliente.id_cliente WHERE cliente.desactivado_c=0 ";
                DataTable tabla = conex.selectQuery(seleccionClientes);
                dataGridView_listadoClientes.DataSource = tabla;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Main.latch_Listados = false;
            this.Close();
        }
    }
}
