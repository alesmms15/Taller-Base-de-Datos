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
    public partial class Cantidad_Productos : Form
    {
        public Cantidad_Productos()
        {
            InitializeComponent();
        }

        readonly string fecha_ano_actual = DateTime.Now.ToString("yyyy");
        readonly string fecha_hace1ano = DateTime.Now.AddYears(-1).ToString("yyyy");

        private void cantidadProductosNacionales_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string  cantProductosActual = "SELECT cantidad_producto_venta.Productocodigo AS \"Código del producto\", producto.nombre AS \"Nombre del producto\", sum(cantidad_producto) AS \"Cantidad total de productos vendidos\" FROM cliente_nacional INNER JOIN cliente ON cliente_nacional.clienteid_cliente = cliente.id_cliente INNER JOIN venta ON cliente.id_cliente = venta.clienteid_cliente INNER JOIN cantidad_producto_venta ON venta.codigo = cantidad_producto_venta.Ventacodigo INNER JOIN producto ON cantidad_producto_venta.Productocodigo = producto.codigo WHERE producto.desactivado_p = 0 AND cliente.desactivado_c = 0 AND venta.fecha_venta LIKE " + "\"" + fecha_ano_actual + "%\" GROUP BY cantidad_producto_venta.Productocodigo, producto.nombre";
                DataTable tabla = conex.selectQuery(cantProductosActual);
                dataGridView_cantidadProductosActual.DataSource = tabla;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cantidadProductosExtranjero_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string cantProductosPasado = "SELECT cantidad_producto_venta.Productocodigo AS \"Código del producto\", producto.nombre AS \"Nombre del producto\", sum(cantidad_producto) AS \"Cantidad total de productos vendidos\" FROM cliente_extranjero INNER JOIN cliente ON cliente_extranjero.clienteid_cliente = cliente.id_cliente INNER JOIN venta ON cliente.id_cliente = venta.clienteid_cliente INNER JOIN cantidad_producto_venta ON venta.codigo = cantidad_producto_venta.Ventacodigo INNER JOIN producto ON cantidad_producto_venta.Productocodigo = producto.codigo WHERE producto.desactivado_p = 0 AND cliente.desactivado_c = 0 AND venta.fecha_venta LIKE " + "\"" + fecha_hace1ano + "%\" GROUP BY cantidad_producto_venta.Productocodigo, producto.nombre";
                DataTable tabla = conex.selectQuery(cantProductosPasado);
                dataGridView_cantidadProductosExtranjero.DataSource = tabla;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
