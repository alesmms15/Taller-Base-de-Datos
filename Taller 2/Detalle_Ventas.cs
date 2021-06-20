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
    public partial class Detalle_Ventas : Form
    {
        public Detalle_Ventas()
        {
            InitializeComponent();
        }
        readonly string fecha_ano_actual = DateTime.Now.ToString("yyyy");
        readonly string ultimo_mes = DateTime.Now.ToString("yyyy-MM");
       
        private void Volver_Click(object sender, EventArgs e)
        {
            Main.latch_DetalleVentas = false;
            this.Close();
        }

        private void Detalle_Ventas_Load(object sender, EventArgs e)
        {
            comboBox_clienteNacional.Items.Clear(); //limpiar elementos antiguos del comboBox
            try
            {
                //COMBO BOX CLIENTE
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string query_ID_Cliente = "SELECT cliente_nacional.nombre FROM  cliente_nacional INNER JOIN cliente ON cliente.id_cliente = cliente_nacional.Clienteid_cliente WHERE cliente.desactivado_c = 0";
                DataTable tabla = conex.selectQuery(query_ID_Cliente);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_clienteNacional.Items.Add(tabla.Rows[i]["nombre"]);

                }



                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_BuscarVentas_Click_1(object sender, EventArgs e)
        {
            try
            {

                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string id_cliente = "SELECT cliente.id_cliente FROM cliente_nacional INNER JOIN cliente ON cliente_nacional.Clienteid_cliente = cliente.id_cliente";
                int id_cliente_consulta = int.Parse(conex.selectQueryScalar(id_cliente));


                string consulta_Ventas = "SELECT venta.codigo AS \"Venta\",venta.monto_total, cliente.id_cliente AS \"Cliente\", producto.codigo AS \"Codigo Producto\", producto.nombre AS \"Nombre Producto\", cantidad_producto_venta.cantidad_producto, venta.fecha_venta  FROM venta INNER JOIN cantidad_producto_venta ON venta.codigo = cantidad_producto_venta.Ventacodigo INNER JOIN cliente ON cliente.id_cliente = venta.Clienteid_cliente  INNER JOIN producto ON cantidad_producto_venta.Productocodigo = producto.codigo WHERE cliente.id_cliente = " + id_cliente_consulta + " AND venta.fecha_venta LIKE " + "\"" + fecha_ano_actual + "%\"" + " ORDER BY venta.codigo ASC ";

                DataTable tabla = conex.selectQuery(consulta_Ventas);
                dataGridView_21.DataSource = tabla;


                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_buscarVenta25_Click(object sender, EventArgs e)
        {
            try
            {

                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string consulta_Ventas = "SELECT COUNT(*) FROM venta WHERE venta.fecha_venta LIKE " + "\"" + ultimo_mes + "%\"" + " AND (venta.fecha_venta LIKE " + "\"" + "% 08:%" + "\"" + " OR venta.fecha_venta LIKE " + "\"%" + "% 09:%" + "\"" + ")";
                string resultado = conex.selectQueryScalar(consulta_Ventas);

                textBox_resultado25.Text = resultado;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_BuscarVentas26_Click(object sender, EventArgs e)
        {

            try
            {

                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string consulta_Ventas = "SELECT COUNT(*) FROM venta WHERE venta.fecha_venta LIKE " + "\"" + ultimo_mes + "%\"" + " AND (dayofweek(venta.fecha_venta) = 7 OR dayofweek(venta.fecha_venta)= 1)";
                string resultado = conex.selectQueryScalar(consulta_Ventas);

                textBox_Resultado26.Text = resultado;

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
