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
    public partial class Aumentar_Stock : Form
    {
        public Aumentar_Stock()
        {
            InitializeComponent();

            textBox_nombreProducto.ReadOnly = true;
            textBox_StockActual.ReadOnly = true;

        }

        public void rellenarComboBoxCodigo()
        {
            comboBox_codigoProducto.Items.Clear();
            try
            {
                ConexMySQL conexion = new ConexMySQL();
                conexion.open();
                string codigoProducto = "SELECT codigo FROM producto WHERE desactivado_p=0";
                DataTable tabla = conexion.selectQuery(codigoProducto);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_codigoProducto.Items.Add(tabla.Rows[i]["codigo"]);
                }
                conexion.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox_codigoProducto_DropDown(object sender, EventArgs e)
        {
            rellenarComboBoxCodigo();
        }

        private void comboBox_codigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string productoNombre = "SELECT nombre FROM producto WHERE codigo = " + comboBox_codigoProducto.Text + " AND desactivado_p = 0";
                textBox_nombreProducto.Text = conex.selectQueryScalar(productoNombre);
                string productoStockActual = "SELECT stock FROM producto WHERE codigo = " + comboBox_codigoProducto.Text + " AND desactivado_p = 0";
                textBox_StockActual.Text = conex.selectQueryScalar(productoStockActual);

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_AumentarStock_Click(object sender, EventArgs e)
        {
            if (comboBox_codigoProducto.Text == "" || textBox_StockActual.Text == "")
            {
                MessageBox.Show("Seleccione un código de productos antes de actualizar o rellene el Stock actual.");
            }
            else
            {
                var confirmacion = MessageBox.Show("¿Está seguro que desea actualizar el stock de este producto?", "Confirmacion", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    ConexMySQL conex = new ConexMySQL();
                    conex.open();

                    string estadoBit = "SELECT desactivado_p FROM producto WHERE codigo='" + comboBox_codigoProducto.Text + "\'";
                    string estadoProducto = conex.selectQueryScalar(estadoBit);

                    if (estadoProducto == "0")
                    {
                        try
                        {


                            string productoStockActual = "SELECT stock FROM producto WHERE codigo = " + comboBox_codigoProducto.Text + " AND desactivado_p = 0";
                            int stockActualInt = int.Parse(conex.selectQueryScalar(productoStockActual));
                            int stockAumentar = int.Parse(textBox_StockSuma.Text);

                            int stockNuevo = stockActualInt + stockAumentar;


                            string actualizarStock = "UPDATE producto SET stock ='" + stockNuevo + "\' WHERE codigo='" + comboBox_codigoProducto.Text + "\'";

                            int actualizacion_correcta = conex.executeNonQuery(actualizarStock);

                            if (actualizacion_correcta == 1)
                            {
                                MessageBox.Show("Se ha ingresado el producto de manera correcta");
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error, intente nuevamente");
                            }

                            conex.close();

                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El producto que desea actualizar no se encuentra registrado, intente nuevamente.");
                    }
                }
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Main.latch_AumentarStock = false;
            this.Close();
        }
    }
}
