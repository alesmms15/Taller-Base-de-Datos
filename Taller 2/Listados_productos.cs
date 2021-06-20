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
    public partial class Listados_productos : Form
    {
        public Listados_productos()
        {
            InitializeComponent();
        }

        readonly string fecha_ano_actual = DateTime.Now.ToString("yyyy");
        readonly string fecha_hace1ano = DateTime.Now.AddYears(-1).ToString("yyyy");
        readonly string fecha_hace4anos = DateTime.Now.AddYears(-4).ToString("yyyy");
        private void productosActualidad_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string productosActual = "SELECT producto.codigo, producto.nombre, producto.stock, producto.precio_unitario FROM cliente INNER JOIN venta ON cliente.id_cliente=venta.clienteid_cliente INNER JOIN cantidad_producto_venta ON venta.codigo=cantidad_producto_venta.Ventacodigo INNER JOIN producto ON cantidad_producto_venta.Productocodigo=producto.codigo AND cliente.desactivado_c= 0 AND producto.desactivado_p=0 AND venta.fecha_venta LIKE " + "\"" + fecha_ano_actual + "%\"" + "";
                DataTable tabla = conex.selectQuery(productosActual);
                dataGridView_productosActualidad.DataSource = tabla;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void productoDos_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string productosActualNac = "SELECT producto.codigo, producto.nombre, producto.stock, producto.precio_unitario FROM cliente_nacional INNER JOIN cliente ON cliente_nacional.clienteid_cliente=cliente.id_cliente INNER JOIN venta ON cliente.id_cliente=venta.clienteid_cliente INNER JOIN cantidad_producto_venta ON venta.codigo = cantidad_producto_venta.Ventacodigo INNER JOIN producto ON cantidad_producto_venta.Productocodigo= producto.codigo WHERE producto.desactivado_p=0" + " AND cliente.desactivado_c=0" + " AND (venta.fecha_venta LIKE " + "\"" + fecha_ano_actual + "%\"" + " OR venta.fecha_venta LIKE " + "\"" + fecha_hace1ano + "%\"" + ")";
                DataTable tabla = conex.selectQuery(productosActualNac);
                dataGridView_productosDos.DataSource = tabla;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void productosCinco_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string productosActualExt = "SELECT producto.codigo, producto.nombre, producto.stock, producto.precio_unitario FROM cliente_extranjero INNER JOIN cliente ON cliente_extranjero.clienteid_cliente=cliente.id_cliente INNER JOIN venta ON cliente.id_cliente=venta.clienteid_cliente INNER JOIN cantidad_producto_venta ON venta.codigo = cantidad_producto_venta.Ventacodigo INNER JOIN producto ON cantidad_producto_venta.Productocodigo= producto.codigo WHERE producto.desactivado_p=0" + " AND cliente.desactivado_c=0" + " AND (venta.fecha_venta LIKE " + "\"" + fecha_ano_actual + "%\"" + " OR venta.fecha_venta LIKE " + "\"" + fecha_hace4anos + "%\"" + ")";
                DataTable tabla = conex.selectQuery(productosActualExt);
                dataGridView_productosCinco.DataSource = tabla;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Main.latch_ListadoProductos = false;
            this.Close();
        }
    }
}
