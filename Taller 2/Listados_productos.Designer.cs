
namespace Taller_2
{
    partial class Listados_productos
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
            this.dataGridView_productosActualidad = new System.Windows.Forms.DataGridView();
            this.productosActualidad = new System.Windows.Forms.Button();
            this.productoDos = new System.Windows.Forms.Button();
            this.dataGridView_productosDos = new System.Windows.Forms.DataGridView();
            this.productosCinco = new System.Windows.Forms.Button();
            this.dataGridView_productosCinco = new System.Windows.Forms.DataGridView();
            this.Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productosActualidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productosDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productosCinco)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_productosActualidad
            // 
            this.dataGridView_productosActualidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productosActualidad.Location = new System.Drawing.Point(16, 154);
            this.dataGridView_productosActualidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_productosActualidad.Name = "dataGridView_productosActualidad";
            this.dataGridView_productosActualidad.RowHeadersWidth = 51;
            this.dataGridView_productosActualidad.Size = new System.Drawing.Size(320, 185);
            this.dataGridView_productosActualidad.TabIndex = 0;
            // 
            // productosActualidad
            // 
            this.productosActualidad.Location = new System.Drawing.Point(89, 103);
            this.productosActualidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productosActualidad.Name = "productosActualidad";
            this.productosActualidad.Size = new System.Drawing.Size(152, 43);
            this.productosActualidad.TabIndex = 1;
            this.productosActualidad.Text = "Productos vendidos en la Actualidad";
            this.productosActualidad.UseVisualStyleBackColor = true;
            this.productosActualidad.Click += new System.EventHandler(this.productosActualidad_Click);
            // 
            // productoDos
            // 
            this.productoDos.Location = new System.Drawing.Point(452, 103);
            this.productoDos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productoDos.Name = "productoDos";
            this.productoDos.Size = new System.Drawing.Size(172, 43);
            this.productoDos.TabIndex = 3;
            this.productoDos.Text = "Productos vendidos en los últimos 2 años";
            this.productoDos.UseVisualStyleBackColor = true;
            this.productoDos.Click += new System.EventHandler(this.productoDos_Click);
            // 
            // dataGridView_productosDos
            // 
            this.dataGridView_productosDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productosDos.Location = new System.Drawing.Point(367, 154);
            this.dataGridView_productosDos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_productosDos.Name = "dataGridView_productosDos";
            this.dataGridView_productosDos.RowHeadersWidth = 51;
            this.dataGridView_productosDos.Size = new System.Drawing.Size(320, 185);
            this.dataGridView_productosDos.TabIndex = 2;
            // 
            // productosCinco
            // 
            this.productosCinco.Location = new System.Drawing.Point(800, 103);
            this.productosCinco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productosCinco.Name = "productosCinco";
            this.productosCinco.Size = new System.Drawing.Size(204, 43);
            this.productosCinco.TabIndex = 5;
            this.productosCinco.Text = "Productos vendidos en el extranjero los últimos 5 años";
            this.productosCinco.UseVisualStyleBackColor = true;
            this.productosCinco.Click += new System.EventHandler(this.productosCinco_Click);
            // 
            // dataGridView_productosCinco
            // 
            this.dataGridView_productosCinco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productosCinco.Location = new System.Drawing.Point(731, 154);
            this.dataGridView_productosCinco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_productosCinco.Name = "dataGridView_productosCinco";
            this.dataGridView_productosCinco.RowHeadersWidth = 51;
            this.dataGridView_productosCinco.Size = new System.Drawing.Size(320, 185);
            this.dataGridView_productosCinco.TabIndex = 4;
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(975, 13);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 6;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Listados_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.productosCinco);
            this.Controls.Add(this.dataGridView_productosCinco);
            this.Controls.Add(this.productoDos);
            this.Controls.Add(this.dataGridView_productosDos);
            this.Controls.Add(this.productosActualidad);
            this.Controls.Add(this.dataGridView_productosActualidad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Listados_productos";
            this.Text = "Listados_productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productosActualidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productosDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productosCinco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_productosActualidad;
        private System.Windows.Forms.Button productosActualidad;
        private System.Windows.Forms.Button productoDos;
        private System.Windows.Forms.DataGridView dataGridView_productosDos;
        private System.Windows.Forms.Button productosCinco;
        private System.Windows.Forms.DataGridView dataGridView_productosCinco;
        private System.Windows.Forms.Button Volver;
    }
}