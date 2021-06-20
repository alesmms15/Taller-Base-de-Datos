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
    public partial class Funciones_Producto : Form
    {
        public Funciones_Producto()
        {
            InitializeComponent();
        }

        private void botonIngresarProducto_Click(object sender, EventArgs e)
        {
            if (textBox_codigo.Text == "" || textBox_nombre.Text == "" || textBox_stock.Text == "" || textBox_precio.Text == "")
            {
                MessageBox.Show("Rellene los campos que están vacíos.");
            }
            else
            {
                var confirmacion = MessageBox.Show("¿Está seguro que desea insertar ese producto?", "Confirmacion", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {

                        ConexMySQL conex = new ConexMySQL();
                        conex.open();
                        int codigoInt = int.Parse(textBox_codigo.Text);
                        int stockInt = int.Parse(textBox_stock.Text);
                        int precioInt = int.Parse(textBox_precio.Text);                                                               
                        string insertar = "INSERT INTO Producto(codigo, nombre, stock, precio_unitario, desactivado_p) VALUES(" + codigoInt + "," + "\"" + textBox_nombre.Text + "\"" + ", " + stockInt + "," + precioInt +", " + 0 + ")";
                        
                        int insercion_correcta = conex.executeNonQuery(insertar);

                        if(insercion_correcta == 1)
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
            }
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            if(textBox_codigo3.Text == "" || textBox_precio3.Text == "")
            {
                MessageBox.Show("Rellene los campos que están vacíos.");
            }
            else
            {
                var confirmacion3 = MessageBox.Show("¿Está seguro que desea actualizar el precio unitario de este producto?", "Confirmacion", MessageBoxButtons.YesNo);

                if (confirmacion3 == DialogResult.Yes)
                {
                    ConexMySQL conex = new ConexMySQL();
                    conex.open();

                    int precioInt = int.Parse(textBox_precio3.Text);

                    string estadoBit = "SELECT desactivado_p FROM Producto WHERE codigo='" +  textBox_codigo3.Text + "\'";
                    string estadoProducto = conex.selectQueryScalar(estadoBit);

                    if (estadoProducto == "0")
                    {
                        try
                        {
                            string actualizar = "UPDATE producto SET precio_unitario='" + precioInt + "\' WHERE codigo='" + textBox_codigo3.Text + "\'";
                            int actualizado = conex.executeNonQuery(actualizar);

                            if (actualizado == 1)
                            {
                                MessageBox.Show("Se ha actualizado el precio unitario de manera correcta");
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error, intente nuevamente.");
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
                        MessageBox.Show("El producto ingresado no se encuentra registrado, intente nuevamente.");
                    }

                }
            }
        }

        private void botonEliminarProducto_Click(object sender, EventArgs e)
        {
            if (textBox_codigo2.Text == "")
            {
                MessageBox.Show("Rellene los campos que están vacíos.");
            }
            else
            {
                var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Confirmacion", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    ConexMySQL conex = new ConexMySQL();
                    conex.open();

                    string estadoBit = "SELECT desactivado_p FROM Producto WHERE codigo='" + textBox_codigo2.Text + "\'";
                    string estadoProducto = conex.selectQueryScalar(estadoBit);

                    if (estadoProducto == "0")
                    {

                        try
                        {
                            string actualizar = "UPDATE producto SET desactivado_p=1 WHERE codigo='" + textBox_codigo2.Text + "\'";
                            int eliminacion = conex.executeNonQuery(actualizar);

                            if (eliminacion == 1)
                            {
                                MessageBox.Show("Se ha eliminado el producto de manera correcta");
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error, intentelo nuevamente.");
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
                        MessageBox.Show("El producto que se desea eliminar no está registrado, intentelo nuevamente.");
                    }
                }
            }
        }
    }
}
