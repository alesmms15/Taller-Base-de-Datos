
namespace Taller_2
{
    partial class Funciones_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonProducto = new System.Windows.Forms.Button();
            this.botonClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonProducto
            // 
            this.botonProducto.Location = new System.Drawing.Point(241, 137);
            this.botonProducto.Name = "botonProducto";
            this.botonProducto.Size = new System.Drawing.Size(118, 23);
            this.botonProducto.TabIndex = 0;
            this.botonProducto.Text = "Funciones Producto";
            this.botonProducto.UseVisualStyleBackColor = true;
            this.botonProducto.Click += new System.EventHandler(this.botonProducto_Click);
            // 
            // botonClientes
            // 
            this.botonClientes.Location = new System.Drawing.Point(241, 206);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(118, 23);
            this.botonClientes.TabIndex = 1;
            this.botonClientes.Text = "Funciones Cliente";
            this.botonClientes.UseVisualStyleBackColor = true;
            this.botonClientes.Click += new System.EventHandler(this.botonClientes_Click);
            // 
            // Funciones_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.botonClientes);
            this.Controls.Add(this.botonProducto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Funciones_Admin";
            this.Text = "Funciones_Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonProducto;
        private System.Windows.Forms.Button botonClientes;
    }
}