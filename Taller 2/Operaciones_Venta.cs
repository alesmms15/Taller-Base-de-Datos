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
using System.Runtime.InteropServices;


namespace Taller_2
{
    public partial class Operaciones_Venta : Form
    {
        public Operaciones_Venta()
        {
            InitializeComponent();
            
            
            textBox_Nombre_Producto.ReadOnly = true;
            

            dateTimePicker_Consulta_Venta.Format = DateTimePickerFormat.Custom;
            
            dateTimePicker_Consulta_Venta.CustomFormat = "yyyy-MM-dd";
        }
        /*
         * Variables de clase
         */
        int index_fila_matriz = 0;
        string[,] matriz_detalle_venta = new string[100,3];
        int monto_total=0;
        string fecha_ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        

        //REQUERIMIENTO 7

        /*
         * Cargar comboBox de ID cliente y ID producto
         */
        private void Operaciones_Venta_Load(object sender, EventArgs e)
        {
            comboBox_Cliente.Items.Clear(); //limpiar elementos antiguos del comboBox
            try
            {
                //COMBO BOX CLIENTE
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string query_ID_Cliente = "SELECT * FROM cliente WHERE cliente.desactivado_c = 0";
                DataTable tabla = conex.selectQuery(query_ID_Cliente);
                for(int i = 0;i<tabla.Rows.Count;i++)
                {
                    comboBox_Cliente.Items.Add(tabla.Rows[i]["id_cliente"]);
                    comboBox_ID_cliente_Consulta.Items.Add(tabla.Rows[i]["id_cliente"]);
                }

                //COMBO BOX PRODUCTO

                string query_ID_Producto = "SELECT * FROM producto WHERE producto.desactivado_p = 0";
                DataTable tabla_id_producto = conex.selectQuery(query_ID_Producto);
                for (int x = 0; x < tabla_id_producto.Rows.Count; x++)
                {
                    comboBox_ID_Producto.Items.Add(tabla_id_producto.Rows[x]["codigo"]);
                }

                conex.close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        /*
         * Boton para cerrar ventana
         */
        private void Volver_Click(object sender, EventArgs e)
        {
            Main.latch_OperacionesVenta = false;
            this.Close();
        }

        /*
         * Evento para confirmar cliente y mostrar nombre
         */

        private void comboBox_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {//ESTO YA NO SE USA
            //try
            //{
            //    ConexMySQL conex = new ConexMySQL();
            //    conex.open();
            //    string query = "SELECT cliente_nacional.nombre FROM cliente, cliente_nacional WHERE cliente.id_cliente = cliente_nacional.Clienteid_cliente AND cliente.id_cliente = " + comboBox_Cliente.Text + " AND cliente.desactivado_c = 0";
            //    textBox_Nombre_Cliente.Text = conex.selectQueryScalar(query);


            //    conex.close();
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show(error.Message);
            //}
        }
        

        /*
         * Evento para confirmar producto y mostrar nombre
         */

        private void comboBox_ID_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string query = "SELECT producto.nombre FROM producto WHERE producto.codigo = " + comboBox_ID_Producto.Text + " AND producto.desactivado_p = 0";
                textBox_Nombre_Producto.Text = conex.selectQueryScalar(query);

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
       


        /*
         * boton para agregar nuevo producto a la lista de productos de cada venta
         */
        private void Agregar_Producto_Click(object sender, EventArgs e)
        {

            matriz_detalle_venta[index_fila_matriz, 0] = textBox_ID_Venta.Text;//ID de Venta  
            matriz_detalle_venta[index_fila_matriz, 1] = comboBox_ID_Producto.Text;//ID producto
            matriz_detalle_venta[index_fila_matriz, 2] = textBox_Cantidad_Producto.Text;//Cantidad de producto
            
            index_fila_matriz++;//aumentar el indice para la siguiente fila, el siguiente producto
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string query = "SELECT producto.precio_unitario FROM producto WHERE producto.codigo = " + comboBox_ID_Producto.Text;
                int precio_unit = int.Parse(conex.selectQueryScalar(query));
                int cantidad = int.Parse(textBox_Cantidad_Producto.Text);
                monto_total += precio_unit * cantidad;


                MessageBox.Show("El monto total hasta el momento es de: " + monto_total.ToString(), "Monto Total", MessageBoxButtons.OK);
                
                
                textBox_Nombre_Producto.Clear();
                textBox_Cantidad_Producto.Clear();

                conex.close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        /*
         * Boton para insertar nueva venta
         */
        private void Ingresar_Venta_Click(object sender, EventArgs e)
        {
            if(comboBox_Cliente.Text == "" || comboBox_ID_Producto.Text == "" || textBox_ID_Venta.Text =="")
            {
                MessageBox.Show("Campo Cliente o Producto en blanco, ingrese todos los datos");
            }
            else
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                try
                {
                    if(checkBox_Terminar_Venta.Checked == true)
                    {
                        //Crear tabla venta primero, luego asociar el detalle
                        int codigo = int.Parse(textBox_ID_Venta.Text);
                        int cliente_id = int.Parse(comboBox_Cliente.Text);
                        string insertar_venta = "INSERT INTO Venta(codigo, fecha_venta, monto_total, Clienteid_cliente) VALUES(" + codigo + "," + "\"" + fecha_ahora + "\"" + ", " + monto_total + "," + cliente_id + ")";

                        int correct_venta = conex.executeNonQuery(insertar_venta);
                        if (correct_venta == 1)
                        {
                            //Crear tabla Cantidad_producto_venta
                            for (int a = 0; a < index_fila_matriz; a++)
                            {
                                int Ventacodigo = int.Parse(matriz_detalle_venta[a, 0]);
                                int Productocodigo = int.Parse(matriz_detalle_venta[a, 1]);
                                int cantidad_producto = int.Parse(matriz_detalle_venta[a, 2]);
                                string insertar_producto = "INSERT INTO Cantidad_producto_venta(Ventacodigo, Productocodigo, cantidad_producto) VALUES(" + Ventacodigo + "," + Productocodigo + "," + cantidad_producto + ")";

                                int insercion_correcta = conex.executeNonQuery(insertar_producto);

                                if (insercion_correcta != 1)
                                {
                                    break;
                                }

                            }
                            index_fila_matriz = 0;//restablecer el indice para utilizar la matriz para la siguiente venta
                        }
                        MessageBox.Show("Venta ingreasada correctamente");

                        conex.close();
                    }
                    else
                    {
                        MessageBox.Show("Verifique que ha terminado de ingresar productos a la venta");
                    }
                    

                    
                }
                catch(Exception error)
                {
                    MessageBox.Show("Ocurrió un problema, intene de nuevo");
                }
            }
        }





        //REQUERIMIENTO 8
        private void Consultar_Venta_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha_consulta = dateTimePicker_Consulta_Venta.Text;

                ConexMySQL conex = new ConexMySQL();
                conex.open();
                int id_cliente_consulta = int.Parse(comboBox_ID_cliente_Consulta.Text);

                                                                                                                                                                                                          //FROM                                                          
                string consulta_Fecha = "SELECT venta.codigo AS \"Venta\", cliente.id_cliente AS \"Cliente\", producto.codigo AS \"Codigo Producto\", producto.nombre AS \"Nombre Producto\", cantidad_producto_venta.cantidad_producto, venta.fecha_venta  FROM venta INNER JOIN cantidad_producto_venta ON venta.codigo = cantidad_producto_venta.Ventacodigo INNER JOIN cliente ON cliente.id_cliente = venta.Clienteid_cliente  INNER JOIN producto ON cantidad_producto_venta.Productocodigo = producto.codigo WHERE cliente.id_cliente = " + id_cliente_consulta + " AND venta.fecha_venta LIKE " + "\"" + fecha_consulta + "%\"" + " ORDER BY venta.codigo ASC ";

                DataTable tabla = conex.selectQuery(consulta_Fecha);
                dataGridView_Consulta.DataSource = tabla;
                

                conex.close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

        }

        private void comboBox_ID_cliente_Consulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string query = "SELECT cliente_nacional.nombre FROM cliente, cliente_nacional WHERE cliente.id_cliente = cliente_nacional.Clienteid_cliente AND cliente.id_cliente = " + comboBox_ID_cliente_Consulta.Text + " AND cliente.desactivado_c = 0";
                textBox_NombreCliente_Consulta.Text = conex.selectQueryScalar(query);


                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

       
    }

}
