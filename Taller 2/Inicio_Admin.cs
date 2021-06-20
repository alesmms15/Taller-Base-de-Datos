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
    public partial class Inicio_Admin : Form
    {
        public Inicio_Admin()
        {
            InitializeComponent();
        }
        
 
        private void Login_admin_Click(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string query_id = "SELECT id FROM admin";
                string query_password = "SELECT password FROM admin";

                string id = conex.selectQueryScalar(query_id);
                string password = conex.selectQueryScalar(query_password);

                

                if (textBox_usuario.Text.Equals(id) && textBox_password.Text.Equals(password))
                {

                    //muestra las funciones de administrador
                    Funciones_Admin funciones_admin = new Funciones_Admin();
                    MessageBox.Show("Bienvenido Administrador");
                    funciones_admin.Show();
                    
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesión");
                }
                
                conex.close();
            }
            catch(Exception error)
            {
                MessageBox.Show("Ocurrió un error, por favor intente de nuevo");
            }
           
        }

        private void boton_cerrar_Click(object sender, EventArgs e)
        {
            Main.latch_Admin = false;//volver a desactivar el candado
            this.Close();
            
        }
    }
}
