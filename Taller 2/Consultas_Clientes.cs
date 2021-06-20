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
    public partial class Consultas_Clientes : Form
    {
        public Consultas_Clientes()
        {
            InitializeComponent();

            textBox_clientesExtranjerosProductoNombre.ReadOnly = true;
            textBox_clientesNacionalesProductoNombre.ReadOnly = true;
            textBox_todosClientesNombre.ReadOnly = true;

        }

        readonly string fecha_ano_actual = DateTime.Now.ToString("yyyy");
        readonly string fecha_hace4anos = DateTime.Now.AddYears(-4).ToString("yyyy");

        public void rellenarComboBoxCodigoClientesNacionales()
        {
            comboBox_clientesNacionalesProductoCodigo.Items.Clear();
            try
            {
                ConexMySQL conexion = new ConexMySQL();
                conexion.open();
                string codigoProducto = "SELECT codigo FROM producto WHERE desactivado_p=0";
                DataTable tabla = conexion.selectQuery(codigoProducto);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_clientesNacionalesProductoCodigo.Items.Add(tabla.Rows[i]["codigo"]);
                }
                conexion.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void rellenarComboBoxCodigoClientesExtranjeros()
        {
            comboBox_clientesExtranjerosProductoCodigo.Items.Clear();
            try
            {
                ConexMySQL conexion = new ConexMySQL();
                conexion.open();
                string codigoProducto = "SELECT codigo FROM producto WHERE desactivado_p=0";
                DataTable tabla = conexion.selectQuery(codigoProducto);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_clientesExtranjerosProductoCodigo.Items.Add(tabla.Rows[i]["codigo"]);
                }
                conexion.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void rellenarComboBoxCodigoClientes()
        {
            comboBox_todosClientesCodigo.Items.Clear();
            try
            {
                ConexMySQL conexion = new ConexMySQL();
                conexion.open();
                string codigoProducto = "SELECT codigo FROM producto WHERE desactivado_p=0";
                DataTable tabla = conexion.selectQuery(codigoProducto);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_todosClientesCodigo.Items.Add(tabla.Rows[i]["codigo"]);
                }
                conexion.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }        

        private void comboBox_clientesNacionalesProductoCodigo_DropDown(object sender, EventArgs e)
        {
            rellenarComboBoxCodigoClientesNacionales();
        }

        private void comboBox_clientesExtranjerosProductoCodigo_DropDown(object sender, EventArgs e)
        {
            rellenarComboBoxCodigoClientesExtranjeros();
        }

        private void comboBox_todosClientesCodigo_DropDown(object sender, EventArgs e)
        {
            rellenarComboBoxCodigoClientes();
        }

        private void comboBox_clientesNacionalesProductoCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string productoNombre = "SELECT nombre FROM producto WHERE codigo = " + comboBox_clientesNacionalesProductoCodigo.Text + " AND desactivado_p = 0";
                textBox_clientesNacionalesProductoNombre.Text = conex.selectQueryScalar(productoNombre);

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox_clientesExtranjerosProductoCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string productoNombre = "SELECT nombre FROM producto WHERE codigo = " + comboBox_clientesExtranjerosProductoCodigo.Text + " AND desactivado_p = 0";
                textBox_clientesExtranjerosProductoNombre.Text = conex.selectQueryScalar(productoNombre);

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox_todosClientesCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string productoNombre = "SELECT nombre FROM producto WHERE codigo = " + comboBox_todosClientesCodigo.Text + " AND desactivado_p = 0";
                textBox_todosClientesNombre.Text = conex.selectQueryScalar(productoNombre);

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void clientesNacionalesProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string clientesActualNacional = "SELECT cliente_nacional.codigo_nacional, cliente_nacional.nombre, cliente_nacional.ciudad FROM cliente_nacional INNER JOIN cliente ON cliente_nacional.clienteid_cliente=cliente.id_cliente INNER JOIN venta ON cliente.id_cliente=venta.clienteid_cliente INNER JOIN cantidad_producto_venta ON venta.codigo = cantidad_producto_venta.Ventacodigo INNER JOIN producto ON cantidad_producto_venta.Productocodigo= producto.codigo WHERE producto.codigo = " + comboBox_clientesNacionalesProductoCodigo.Text + " AND producto.desactivado_p=0 AND cliente.desactivado_c=0 AND venta.fecha_venta LIKE " + "\"" + fecha_ano_actual + "%\"";
                DataTable tabla = conex.selectQuery(clientesActualNacional);
                dataGridView_clientesNacionalesProducto.DataSource = tabla;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void clientesExtranjerosProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string clientesActualExtranjeros = "SELECT cliente_extranjero.codigo_extranjero, cliente_extranjero.nombre, cliente_extranjero.ciudad, cliente_extranjero.pais FROM cliente_extranjero INNER JOIN cliente ON cliente_extranjero.clienteid_cliente=cliente.id_cliente INNER JOIN venta ON cliente.id_cliente=venta.clienteid_cliente INNER JOIN cantidad_producto_venta ON venta.codigo = cantidad_producto_venta.Ventacodigo INNER JOIN producto ON cantidad_producto_venta.Productocodigo= producto.codigo WHERE producto.codigo = " + comboBox_clientesExtranjerosProductoCodigo.Text + " AND producto.desactivado_p=0 AND cliente.desactivado_c=0 AND venta.fecha_venta LIKE " + "\"" + fecha_ano_actual + "%\"";
                DataTable tabla = conex.selectQuery(clientesActualExtranjeros);
                dataGridView_clientesExtranjerosProducto.DataSource = tabla;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void todosClientesProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                
                string clientesActualExtranjeros = "SELECT cliente.id_cliente, cliente_extranjero.nombre AS \"Nombre cliente extranjero\", cliente_nacional.nombre AS \"Nombre cliente nacional\" FROM producto LEFT JOIN cantidad_producto_venta ON cantidad_producto_venta.Productocodigo=producto.codigo LEFT JOIN venta ON venta.codigo=cantidad_producto_venta.Ventacodigo LEFT JOIN cliente ON cliente.id_cliente=venta.clienteid_cliente LEFT JOIN cliente_nacional  ON cliente_nacional.clienteid_cliente=cliente.id_cliente LEFT JOIN cliente_extranjero ON cliente_extranjero.clienteid_cliente=cliente.id_cliente WHERE cliente.desactivado_c=0 AND producto.desactivado_p=0 AND producto.codigo= " + comboBox_todosClientesCodigo.Text + " AND (venta.fecha_venta LIKE " + "\"" + fecha_ano_actual + "%\"" + " OR venta.fecha_venta LIKE " + "\"" + fecha_hace4anos + "%\"" + ") GROUP BY cliente_extranjero.nombre, cliente_nacional.nombre";
                DataTable tabla = conex.selectQuery(clientesActualExtranjeros);
                dataGridView_todosClientesProducto.DataSource = tabla;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
