using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_2
{
    public partial class Main : Form
    {
        public static bool latch_Admin = false; //canado para abrir ventanas una sola vez
        public static bool latch_OperacionesVenta = false;


        public static bool latch_Listados = false;
        public static bool latch_AumentarStock = false;
        public static bool latch_ListadoProductos = false;
        public static bool latch_DetalleVentas = false;
        public static bool latch_CantidadProductos = false;
        public static bool latch_ConsultasClientes = false;
        public static bool latch_ConsultasProductos = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Ingreso_Administrador_Click(object sender, EventArgs e)
        {
            
            
            if (!latch_Admin)//si no hay ventanas activas
            {
                try
                {
                    Inicio_Admin inicio_Admin = new Inicio_Admin();
                    latch_Admin = true;
                    inicio_Admin.ControlBox = false;
                    inicio_Admin.Show();

                    
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error, por favor intente de nuevo");
                }
            }
            else
            {
                this.SendToBack();// Manda el form Main al fondo para permitir al usuario enfocarse en la ventana que quiere abrir (Inicio Admin)
            }
            

        }

        private void Operaciones_Venta_Click(object sender, EventArgs e)
        {
            if (!latch_OperacionesVenta)//si no hay ventanas activas
            {
                try
                {
                    Operaciones_Venta operaciones_venta = new Operaciones_Venta();
                    latch_OperacionesVenta = true;
                    operaciones_venta.ControlBox = false;
                    operaciones_venta.Show();


                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error, por favor intente de nuevo");
                }
            }
            else
            {
                this.SendToBack();// Manda el form Main al fondo para permitir al usuario enfocarse en la ventana que quiere abrir (Inicio Admin)
            }

        }

        private void listados_Click(object sender, EventArgs e)
        {
            if (!latch_Listados)//si no hay ventanas activas
            {
                try
                {
                    Listados_clientes listados = new Listados_clientes();
                    latch_Listados = true;
                    listados.ControlBox = false;
                    listados.Show();


                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error, por favor intente de nuevo");
                }
            }
            else
            {
                this.SendToBack();// Manda el form Main al fondo para permitir al usuario enfocarse en la ventana que quiere abrir (Inicio Admin)
            }
        }

        private void aumentarStock_Click(object sender, EventArgs e)
        {
            if (!latch_AumentarStock)
            {
                try
                {
                    Aumentar_Stock aumentarStock = new Aumentar_Stock();
                    latch_AumentarStock = true;
                    aumentarStock.ControlBox = false;
                    aumentarStock.Show();


                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error, por favor intente de nuevo");
                }
            }
            else
            {
                this.SendToBack();// Manda el form Main al fondo para permitir al usuario enfocarse en la ventana que quiere abrir (Inicio Admin)
            }
        }

        private void listado_productos_Click(object sender, EventArgs e)
        {
            if (!latch_ListadoProductos)//si no hay ventanas activas
            {
                try
                {
                    Listados_productos listadoProductos = new Listados_productos();
                    latch_ListadoProductos = true;
                    listadoProductos.ControlBox = false;
                    listadoProductos.Show();


                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error, por favor intente de nuevo");
                }
            }
            else
            {
                this.SendToBack();// Manda el form Main al fondo para permitir al usuario enfocarse en la ventana que quiere abrir (Inicio Admin)
            }
        }

        private void button_DetalleVentas_Click(object sender, EventArgs e)
        {
            
            if (!latch_DetalleVentas)
            {
                Detalle_Ventas detalle_Ventas = new Detalle_Ventas();
                latch_DetalleVentas = true;
                detalle_Ventas.ControlBox = false;
                detalle_Ventas.Show();


            }
            else
            {
                this.SendToBack();

            }
        }

        private void cantidadProductos_Click(object sender, EventArgs e)
        {
            if (!latch_CantidadProductos)
            {
                Cantidad_Productos cantidadProductos = new Cantidad_Productos();
                latch_CantidadProductos = true;
                cantidadProductos.ControlBox = false;
                cantidadProductos.Show();


            }
            else
            {
                this.SendToBack();

            }
        }

        private void consultasClientes_Click(object sender, EventArgs e)
        {
            if (!latch_ConsultasClientes)
            {
                Consultas_Clientes consultaClientes = new Consultas_Clientes();
                latch_ConsultasClientes = true;
                consultaClientes.ControlBox = false;
                consultaClientes.Show();


            }
            else
            {
                this.SendToBack();

            }
        }

        private void consultasProducto_Click(object sender, EventArgs e)
        {
            if (!latch_ConsultasProductos)
            {
                Consultas_Productos consultasProductos = new Consultas_Productos();
                latch_ConsultasProductos = true;
                consultasProductos.ControlBox = false;
                consultasProductos.Show();


            }
            else
            {
                this.SendToBack();

            }
        }
    }
}
