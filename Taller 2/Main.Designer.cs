
namespace Taller_2
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ingreso_Administrador = new System.Windows.Forms.Button();
            this.Operaciones_Venta = new System.Windows.Forms.Button();
            this.listados = new System.Windows.Forms.Button();
            this.aumentarStock = new System.Windows.Forms.Button();
            this.listado_productos = new System.Windows.Forms.Button();
            this.button_DetalleVentas = new System.Windows.Forms.Button();
            this.cantidadProductos = new System.Windows.Forms.Button();
            this.consultasClientes = new System.Windows.Forms.Button();
            this.consultasProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ingreso_Administrador
            // 
            this.Ingreso_Administrador.Location = new System.Drawing.Point(21, 301);
            this.Ingreso_Administrador.Margin = new System.Windows.Forms.Padding(2);
            this.Ingreso_Administrador.Name = "Ingreso_Administrador";
            this.Ingreso_Administrador.Size = new System.Drawing.Size(79, 40);
            this.Ingreso_Administrador.TabIndex = 0;
            this.Ingreso_Administrador.Text = "Ingreso Administrador";
            this.Ingreso_Administrador.UseVisualStyleBackColor = true;
            this.Ingreso_Administrador.Click += new System.EventHandler(this.Ingreso_Administrador_Click);
            // 
            // Operaciones_Venta
            // 
            this.Operaciones_Venta.Location = new System.Drawing.Point(123, 231);
            this.Operaciones_Venta.Margin = new System.Windows.Forms.Padding(2);
            this.Operaciones_Venta.Name = "Operaciones_Venta";
            this.Operaciones_Venta.Size = new System.Drawing.Size(94, 40);
            this.Operaciones_Venta.TabIndex = 1;
            this.Operaciones_Venta.Text = "Operaciones Venta";
            this.Operaciones_Venta.UseVisualStyleBackColor = true;
            this.Operaciones_Venta.Click += new System.EventHandler(this.Operaciones_Venta_Click);
            // 
            // listados
            // 
            this.listados.Location = new System.Drawing.Point(248, 301);
            this.listados.Name = "listados";
            this.listados.Size = new System.Drawing.Size(94, 40);
            this.listados.TabIndex = 2;
            this.listados.Text = "Listados de Clientes";
            this.listados.UseVisualStyleBackColor = true;
            this.listados.Click += new System.EventHandler(this.listados_Click);
            // 
            // aumentarStock
            // 
            this.aumentarStock.Location = new System.Drawing.Point(368, 301);
            this.aumentarStock.Name = "aumentarStock";
            this.aumentarStock.Size = new System.Drawing.Size(94, 40);
            this.aumentarStock.TabIndex = 3;
            this.aumentarStock.Text = "Aumentar Stock";
            this.aumentarStock.UseVisualStyleBackColor = true;
            this.aumentarStock.Click += new System.EventHandler(this.aumentarStock_Click);
            // 
            // listado_productos
            // 
            this.listado_productos.Location = new System.Drawing.Point(248, 231);
            this.listado_productos.Name = "listado_productos";
            this.listado_productos.Size = new System.Drawing.Size(94, 40);
            this.listado_productos.TabIndex = 4;
            this.listado_productos.Text = "Listado de Productos";
            this.listado_productos.UseVisualStyleBackColor = true;
            this.listado_productos.Click += new System.EventHandler(this.listado_productos_Click);
            // 
            // button_DetalleVentas
            // 
            this.button_DetalleVentas.Location = new System.Drawing.Point(123, 301);
            this.button_DetalleVentas.Margin = new System.Windows.Forms.Padding(2);
            this.button_DetalleVentas.Name = "button_DetalleVentas";
            this.button_DetalleVentas.Size = new System.Drawing.Size(94, 40);
            this.button_DetalleVentas.TabIndex = 5;
            this.button_DetalleVentas.Text = "Detalle Ventas";
            this.button_DetalleVentas.UseVisualStyleBackColor = true;
            this.button_DetalleVentas.Click += new System.EventHandler(this.button_DetalleVentas_Click);
            // 
            // cantidadProductos
            // 
            this.cantidadProductos.Location = new System.Drawing.Point(488, 301);
            this.cantidadProductos.Name = "cantidadProductos";
            this.cantidadProductos.Size = new System.Drawing.Size(94, 40);
            this.cantidadProductos.TabIndex = 6;
            this.cantidadProductos.Text = "Cantidad de Productos";
            this.cantidadProductos.UseVisualStyleBackColor = true;
            this.cantidadProductos.Click += new System.EventHandler(this.cantidadProductos_Click);
            // 
            // consultasClientes
            // 
            this.consultasClientes.Location = new System.Drawing.Point(603, 301);
            this.consultasClientes.Name = "consultasClientes";
            this.consultasClientes.Size = new System.Drawing.Size(94, 40);
            this.consultasClientes.TabIndex = 7;
            this.consultasClientes.Text = "Consultas Clientes";
            this.consultasClientes.UseVisualStyleBackColor = true;
            this.consultasClientes.Click += new System.EventHandler(this.consultasClientes_Click);
            // 
            // consultasProducto
            // 
            this.consultasProducto.Location = new System.Drawing.Point(716, 301);
            this.consultasProducto.Name = "consultasProducto";
            this.consultasProducto.Size = new System.Drawing.Size(94, 40);
            this.consultasProducto.TabIndex = 8;
            this.consultasProducto.Text = "Consultas Productos";
            this.consultasProducto.UseVisualStyleBackColor = true;
            this.consultasProducto.Click += new System.EventHandler(this.consultasProducto_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 371);
            this.Controls.Add(this.consultasProducto);
            this.Controls.Add(this.consultasClientes);
            this.Controls.Add(this.cantidadProductos);
            this.Controls.Add(this.button_DetalleVentas);
            this.Controls.Add(this.listado_productos);
            this.Controls.Add(this.aumentarStock);
            this.Controls.Add(this.listados);
            this.Controls.Add(this.Operaciones_Venta);
            this.Controls.Add(this.Ingreso_Administrador);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "ABC S.A";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ingreso_Administrador;
        private System.Windows.Forms.Button Operaciones_Venta;
        private System.Windows.Forms.Button listados;
        private System.Windows.Forms.Button aumentarStock;
        private System.Windows.Forms.Button listado_productos;
        private System.Windows.Forms.Button button_DetalleVentas;
        private System.Windows.Forms.Button cantidadProductos;
        private System.Windows.Forms.Button consultasClientes;
        private System.Windows.Forms.Button consultasProducto;
    }
}

