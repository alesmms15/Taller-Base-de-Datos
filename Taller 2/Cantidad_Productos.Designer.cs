
namespace Taller_2
{
    partial class Cantidad_Productos
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
            this.dataGridView_cantidadProductosActual = new System.Windows.Forms.DataGridView();
            this.cantidadProductosNacionales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadProductosExtranjero = new System.Windows.Forms.Button();
            this.dataGridView_cantidadProductosExtranjero = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cantidadProductosActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cantidadProductosExtranjero)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_cantidadProductosActual
            // 
            this.dataGridView_cantidadProductosActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cantidadProductosActual.Location = new System.Drawing.Point(41, 142);
            this.dataGridView_cantidadProductosActual.Name = "dataGridView_cantidadProductosActual";
            this.dataGridView_cantidadProductosActual.Size = new System.Drawing.Size(288, 156);
            this.dataGridView_cantidadProductosActual.TabIndex = 0;
            // 
            // cantidadProductosNacionales
            // 
            this.cantidadProductosNacionales.Location = new System.Drawing.Point(145, 113);
            this.cantidadProductosNacionales.Name = "cantidadProductosNacionales";
            this.cantidadProductosNacionales.Size = new System.Drawing.Size(75, 23);
            this.cantidadProductosNacionales.TabIndex = 1;
            this.cantidadProductosNacionales.Text = "Consultar";
            this.cantidadProductosNacionales.UseVisualStyleBackColor = true;
            this.cantidadProductosNacionales.Click += new System.EventHandler(this.cantidadProductosNacionales_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de productos vendidos en el país el año actual";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(474, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad de productos vendidos en el extranjero el año pasado";
            // 
            // cantidadProductosExtranjero
            // 
            this.cantidadProductosExtranjero.Location = new System.Drawing.Point(553, 113);
            this.cantidadProductosExtranjero.Name = "cantidadProductosExtranjero";
            this.cantidadProductosExtranjero.Size = new System.Drawing.Size(75, 23);
            this.cantidadProductosExtranjero.TabIndex = 4;
            this.cantidadProductosExtranjero.Text = "Consultar";
            this.cantidadProductosExtranjero.UseVisualStyleBackColor = true;
            this.cantidadProductosExtranjero.Click += new System.EventHandler(this.cantidadProductosExtranjero_Click);
            // 
            // dataGridView_cantidadProductosExtranjero
            // 
            this.dataGridView_cantidadProductosExtranjero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cantidadProductosExtranjero.Location = new System.Drawing.Point(449, 142);
            this.dataGridView_cantidadProductosExtranjero.Name = "dataGridView_cantidadProductosExtranjero";
            this.dataGridView_cantidadProductosExtranjero.Size = new System.Drawing.Size(288, 156);
            this.dataGridView_cantidadProductosExtranjero.TabIndex = 3;
            // 
            // Cantidad_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidadProductosExtranjero);
            this.Controls.Add(this.dataGridView_cantidadProductosExtranjero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidadProductosNacionales);
            this.Controls.Add(this.dataGridView_cantidadProductosActual);
            this.Name = "Cantidad_Productos";
            this.Text = "Cantidad_Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cantidadProductosActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cantidadProductosExtranjero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cantidadProductosActual;
        private System.Windows.Forms.Button cantidadProductosNacionales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cantidadProductosExtranjero;
        private System.Windows.Forms.DataGridView dataGridView_cantidadProductosExtranjero;
    }
}