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
    public partial class Funciones_Cliente : Form
    {
        public Funciones_Cliente()
        {
            InitializeComponent();
            esconderCampos();
            
        }

        private void esconderCampos()
        {
            codigo_nacional.Hide();
            textBox_codNacional.Hide();
            nombre_nacional.Hide();
            textBox_nomNacional.Hide();
            ciudad_nacional.Hide();
            textBox_ciudadNacional.Hide();

            codigo_extranjero.Hide();
            textBox_codExtranjero.Hide();
            nombre_extranjero.Hide();
            textBox_nomExtranjero.Hide();
            ciudad_extranjero.Hide();
            textBox_ciudadExtranjero.Hide();
            pais_extranjero.Hide();
            textBox_paisExtranjero.Hide();

            botonIngresarCliente.Hide();
        }

        private void comboBox_tipoCliente_SelectedIndexChanged(object sender, EventArgs e) 
        {           


            if (comboBox_tipoCliente.Text == "Cliente nacional")
                {

                codigo_nacional.Show();
                textBox_codNacional.Show();
                nombre_nacional.Show();
                textBox_nomNacional.Show();
                ciudad_nacional.Show();
                textBox_ciudadNacional.Show();

                botonIngresarCliente.Show();
            }
            else //si es cliente extranjero
            {

                codigo_extranjero.Show();
                textBox_codExtranjero.Show();
                nombre_extranjero.Show();
                textBox_nomExtranjero.Show();
                ciudad_extranjero.Show();
                textBox_ciudadExtranjero.Show();
                pais_extranjero.Show(); ;
                textBox_paisExtranjero.Show();

                botonIngresarCliente.Show();

            }
        }

        private void botonIngresarCliente_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            int id_clienteInt = int.Parse(textBox_clienteId.Text);
            string insertarCliente = "INSERT INTO cliente (id_cliente, desactivado_c) VALUES (" + id_clienteInt +  "," + 0 + ")";
            int insercion_correctaCliente = conex.executeNonQuery(insertarCliente);

            if (insercion_correctaCliente == 1)
            {

                if (comboBox_tipoCliente.Text == "Cliente nacional")
                {
                    if (textBox_codNacional.Text == "" || textBox_nomNacional.Text == "" || textBox_ciudadNacional.Text == "")
                    {
                        MessageBox.Show("Rellene los campos que están vacíos.");
                    }
                    else
                    {
                        var confirmacion = MessageBox.Show("¿Está seguro que desea insertar este cliente?", "Confirmacion", MessageBoxButtons.YesNo);

                        if (confirmacion == DialogResult.Yes)
                        {
                            try
                            {

                                int codigoInt = int.Parse(textBox_codNacional.Text);
                                string insertarClienteNacional = "INSERT INTO cliente_nacional(codigo_nacional, nombre, ciudad, clienteid_cliente) VALUES(" + codigoInt + "," + "\"" + textBox_nomNacional.Text + "\"" + ", " + "\"" + textBox_ciudadNacional.Text + "\"" + "," + "\"" + textBox_clienteId.Text + "\")";

                                int insercion_correctaNacional = conex.executeNonQuery(insertarClienteNacional);

                                if (insercion_correctaNacional == 1)
                                {
                                    MessageBox.Show("Se ha ingresado el cliente nacional de manera correcta");
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
                else
                {
                    if (textBox_codExtranjero.Text == "" || textBox_nomExtranjero.Text == "" || textBox_ciudadExtranjero.Text == "" || textBox_paisExtranjero.Text == "")
                    {
                        MessageBox.Show("Rellene los campos que están vacíos.");
                    }
                    else
                    {
                        var confirmacion = MessageBox.Show("¿Está seguro que desea insertar este cliente?", "Confirmacion", MessageBoxButtons.YesNo);

                        if (confirmacion == DialogResult.Yes)
                        {
                            try
                            {
                                int codigoIntE = int.Parse(textBox_codExtranjero.Text);
                                string insertarClienteExtranjero = "INSERT INTO cliente_extranjero(codigo_extranjero, nombre, ciudad, pais, clienteid_cliente) VALUES(" + codigoIntE + "," + "\"" + textBox_nomExtranjero.Text + "\"" + ", " + "\"" + textBox_ciudadExtranjero.Text + "\"" + "," + "\"" + textBox_paisExtranjero.Text + "\""+ "," + "\"" + textBox_clienteId.Text + "\")";

                                int insercion_clienteExtranjero = conex.executeNonQuery(insertarClienteExtranjero);

                                if (insercion_clienteExtranjero == 1)
                                {
                                    MessageBox.Show("Se ha ingresado el cliente extranjero de manera correcta");
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
            }
            else
            {
                MessageBox.Show("No se pudo realizar la inserción, intente nuevamente.");
            }
        }

        private void rellenarComboBoxNacional()
        {
            comboBox_clienteNacional.Items.Clear();
            try
            {
                ConexMySQL conexion = new ConexMySQL();
                conexion.open();
                string nombre_nacional = "SELECT cliente_nacional.nombre FROM cliente_nacional INNER JOIN cliente ON cliente.id_cliente=cliente_nacional.clienteid_cliente AND cliente.desactivado_c='"+ 0 +"'";
                DataTable tabla = conexion.selectQuery(nombre_nacional);
                for(int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_clienteNacional.Items.Add(tabla.Rows[i]["nombre"]);
                }
                conexion.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void rellenarComboBoxExtranjero()
        {
            comboBox_clienteExtranjero.Items.Clear();
            try
            {
                ConexMySQL conexion = new ConexMySQL();
                conexion.open();
                string nombre_extranjero = "SELECT cliente_extranjero.nombre FROM cliente_extranjero INNER JOIN cliente ON cliente.id_cliente=cliente_extranjero.clienteid_cliente AND cliente.desactivado_c=0";
                DataTable tabla = conexion.selectQuery(nombre_extranjero);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_clienteExtranjero.Items.Add(tabla.Rows[i]["nombre"]);
                }
                conexion.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void rellenarComboBoxCiudadesExtranjero()
        {
            comboBox_clienteNacional.Items.Clear();
            try
            {
                ConexMySQL conexion = new ConexMySQL();
                conexion.open();
                string nombre_extranjero = "SELECT cliente_extranjero.nombre FROM cliente_extranjero INNER JOIN cliente ON cliente.id_cliente=cliente_extranjero.clienteid_cliente AND cliente.desactivado_c='" + 0 + "'";
                DataTable tabla = conexion.selectQuery(nombre_extranjero);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_actualizarCiudad.Items.Add(tabla.Rows[i]["nombre"]);
                }
                conexion.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox_clienteNacional_DropDown(object sender, EventArgs e)
        {
            rellenarComboBoxNacional();
        }

        private void comboBox_clienteExtranjero_DropDown(object sender, EventArgs e)
        {
            rellenarComboBoxExtranjero();
        }

        private void comboBox_actualizarCiudad_DropDown(object sender, EventArgs e)
        {
            rellenarComboBoxCiudadesExtranjero();
        }

        private void eliminarClienteNacional_Click(object sender, EventArgs e)
        {
            if (comboBox_clienteNacional.Text == "")
            {
                MessageBox.Show("Seleccione un código de la lista de clientes nacionales antes de eliminar.");
            }
            else
            {
                var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmacion", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {

                    try
                    {
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();

                        string idN = "SELECT cliente.id_cliente FROM  cliente  INNER JOIN cliente_nacional ON cliente.id_cliente=cliente_nacional.clienteid_cliente AND cliente_nacional.nombre= " + "\"" + comboBox_clienteNacional.Text + "\"";

                        string id_cliente = conex.selectQueryScalar(idN);
                        int id_cliente_int = int.Parse(id_cliente);
                        string eliminar = "UPDATE cliente SET desactivado_c= " + 1 + " WHERE id_cliente= " + id_cliente_int;
                        int confirmacionEliminar = conex.executeNonQuery(eliminar);

                       

                        if (confirmacionEliminar == 1)
                        {
                            MessageBox.Show("Se ha eliminado correctamente el cliente nacional.");
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, intentelo nuevamente.");
                        }

                        conex.close();
                        

                        //string eliminarNacional = "UPDATE cliente SET desactivado_c=1 WHERE id_cliente='" + idNacional + "'";


                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }

                }
            }
        }

        private void eliminarClienteExtranjero_Click(object sender, EventArgs e)
        {
            if (comboBox_clienteExtranjero.Text == "")
            {
                MessageBox.Show("Seleccione un código de la lista de clientes extranjeros antes de eliminar.");
            }
            else
            {
                var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmacion", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {

                    try
                    {
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();

                        string idN = "SELECT cliente.id_cliente FROM  cliente  INNER JOIN cliente_extranjero ON cliente.id_cliente=cliente_extranjero.clienteid_cliente AND cliente_extranjero.nombre= " + "\"" + comboBox_clienteExtranjero.Text + "\"";

                        string id_cliente = conex.selectQueryScalar(idN);
                        int id_cliente_int = int.Parse(id_cliente);
                        string eliminar = "UPDATE cliente SET desactivado_c= " + 1 + " WHERE id_cliente= " + id_cliente_int;
                        int confirmacionEliminar = conex.executeNonQuery(eliminar);



                        if (confirmacionEliminar == 1)
                        {
                            MessageBox.Show("Se ha eliminado correctamente el cliente extranjero.");
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
            }
        }

        private void actualizarCiudad_Click(object sender, EventArgs e)
        {
            if (comboBox_actualizarCiudad.Text == "")
            {
                MessageBox.Show("Seleccione un nombre de la lista de las ciudades de los clientes extranjeros antes de actualizar.");
            }
            else
            {
                var confirmacion = MessageBox.Show("¿Está seguro que desea actualizar la ciudad de este cliente?", "Confirmacion", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {

                    try
                    {
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();

                        string idE = "SELECT cliente.id_cliente FROM  cliente  INNER JOIN cliente_extranjero ON cliente.id_cliente=cliente_extranjero.clienteid_cliente AND cliente_extranjero.nombre= " + "\"" + comboBox_actualizarCiudad.Text + "\"";
                        string id_cliente = conex.selectQueryScalar(idE);
                        int id_cliente_int = int.Parse(id_cliente);
                        string actualizarCiudad = "UPDATE cliente_extranjero SET ciudad= " + "\"" + textBox_actualizarCiudad.Text + "\" WHERE clienteid_cliente= " + id_cliente_int;
                        int confirmacionActualizar = conex.executeNonQuery(actualizarCiudad);

                        if (confirmacionActualizar == 1)
                        {
                            MessageBox.Show("Se ha actualizado correctamente la ciudad del cliente extranjero.");
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
            }
        }
      
    }
}
