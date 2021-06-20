
namespace Taller_2
{
    partial class Listados_clientes
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
            this.listadoNacionales = new System.Windows.Forms.Button();
            this.dataGridView_clientesNacionales = new System.Windows.Forms.DataGridView();
            this.dataGridView_clientesExtranjeros = new System.Windows.Forms.DataGridView();
            this.listadoExtranjeros = new System.Windows.Forms.Button();
            this.dataGridView_listadoClientes = new System.Windows.Forms.DataGridView();
            this.listadoClientes = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientesNacionales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientesExtranjeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoNacionales
            // 
            this.listadoNacionales.Location = new System.Drawing.Point(103, 158);
            this.listadoNacionales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listadoNacionales.Name = "listadoNacionales";
            this.listadoNacionales.Size = new System.Drawing.Size(144, 47);
            this.listadoNacionales.TabIndex = 0;
            this.listadoNacionales.Text = "Listado Clientes Nacionales";
            this.listadoNacionales.UseVisualStyleBackColor = true;
            this.listadoNacionales.Click += new System.EventHandler(this.listadoNacionales_Click);
            // 
            // dataGridView_clientesNacionales
            // 
            this.dataGridView_clientesNacionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clientesNacionales.Location = new System.Drawing.Point(16, 212);
            this.dataGridView_clientesNacionales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_clientesNacionales.Name = "dataGridView_clientesNacionales";
            this.dataGridView_clientesNacionales.RowHeadersWidth = 51;
            this.dataGridView_clientesNacionales.Size = new System.Drawing.Size(320, 185);
            this.dataGridView_clientesNacionales.TabIndex = 1;
            // 
            // dataGridView_clientesExtranjeros
            // 
            this.dataGridView_clientesExtranjeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clientesExtranjeros.Location = new System.Drawing.Point(380, 212);
            this.dataGridView_clientesExtranjeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_clientesExtranjeros.Name = "dataGridView_clientesExtranjeros";
            this.dataGridView_clientesExtranjeros.RowHeadersWidth = 51;
            this.dataGridView_clientesExtranjeros.Size = new System.Drawing.Size(320, 185);
            this.dataGridView_clientesExtranjeros.TabIndex = 3;
            // 
            // listadoExtranjeros
            // 
            this.listadoExtranjeros.Location = new System.Drawing.Point(467, 158);
            this.listadoExtranjeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listadoExtranjeros.Name = "listadoExtranjeros";
            this.listadoExtranjeros.Size = new System.Drawing.Size(144, 47);
            this.listadoExtranjeros.TabIndex = 2;
            this.listadoExtranjeros.Text = "Listado Clientes Extranjeros";
            this.listadoExtranjeros.UseVisualStyleBackColor = true;
            this.listadoExtranjeros.Click += new System.EventHandler(this.listadoExtranjeros_Click);
            // 
            // dataGridView_listadoClientes
            // 
            this.dataGridView_listadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listadoClientes.Location = new System.Drawing.Point(731, 212);
            this.dataGridView_listadoClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_listadoClientes.Name = "dataGridView_listadoClientes";
            this.dataGridView_listadoClientes.RowHeadersWidth = 51;
            this.dataGridView_listadoClientes.Size = new System.Drawing.Size(320, 185);
            this.dataGridView_listadoClientes.TabIndex = 5;
            // 
            // listadoClientes
            // 
            this.listadoClientes.Location = new System.Drawing.Point(817, 158);
            this.listadoClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listadoClientes.Name = "listadoClientes";
            this.listadoClientes.Size = new System.Drawing.Size(144, 47);
            this.listadoClientes.TabIndex = 4;
            this.listadoClientes.Text = "Listado de todos los Clientes";
            this.listadoClientes.UseVisualStyleBackColor = true;
            this.listadoClientes.Click += new System.EventHandler(this.listadoClientes_Click);
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(980, 12);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 6;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Listados_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.dataGridView_listadoClientes);
            this.Controls.Add(this.listadoClientes);
            this.Controls.Add(this.dataGridView_clientesExtranjeros);
            this.Controls.Add(this.listadoExtranjeros);
            this.Controls.Add(this.dataGridView_clientesNacionales);
            this.Controls.Add(this.listadoNacionales);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Listados_clientes";
            this.Text = "Listados_clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientesNacionales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientesExtranjeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listadoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listadoNacionales;
        private System.Windows.Forms.DataGridView dataGridView_clientesNacionales;
        private System.Windows.Forms.DataGridView dataGridView_clientesExtranjeros;
        private System.Windows.Forms.Button listadoExtranjeros;
        private System.Windows.Forms.DataGridView dataGridView_listadoClientes;
        private System.Windows.Forms.Button listadoClientes;
        private System.Windows.Forms.Button Volver;
    }
}