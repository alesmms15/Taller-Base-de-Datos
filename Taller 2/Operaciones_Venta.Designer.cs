
namespace Taller_2
{
    partial class Operaciones_Venta
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
            this.Volver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_ID_Venta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Cantidad_Producto = new System.Windows.Forms.TextBox();
            this.Agregar_Producto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nombre_Producto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_ID_Producto = new System.Windows.Forms.ComboBox();
            this.Ingresar_Venta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Cliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Consultar_Venta = new System.Windows.Forms.Button();
            this.dataGridView_Consulta = new System.Windows.Forms.DataGridView();
            this.textBox_NombreCliente_Consulta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_ID_cliente_Consulta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_Consulta_Venta = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox_Terminar_Venta = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(1337, 12);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 0;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox_Terminar_Venta);
            this.panel1.Controls.Add(this.textBox_ID_Venta);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_Cantidad_Producto);
            this.panel1.Controls.Add(this.Agregar_Producto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_Nombre_Producto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_ID_Producto);
            this.panel1.Controls.Add(this.Ingresar_Venta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_Cliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 661);
            this.panel1.TabIndex = 2;
            // 
            // textBox_ID_Venta
            // 
            this.textBox_ID_Venta.Location = new System.Drawing.Point(38, 61);
            this.textBox_ID_Venta.Name = "textBox_ID_Venta";
            this.textBox_ID_Venta.Size = new System.Drawing.Size(113, 22);
            this.textBox_ID_Venta.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cantidad";
            // 
            // textBox_Cantidad_Producto
            // 
            this.textBox_Cantidad_Producto.Location = new System.Drawing.Point(182, 318);
            this.textBox_Cantidad_Producto.Name = "textBox_Cantidad_Producto";
            this.textBox_Cantidad_Producto.Size = new System.Drawing.Size(116, 22);
            this.textBox_Cantidad_Producto.TabIndex = 13;
            // 
            // Agregar_Producto
            // 
            this.Agregar_Producto.Location = new System.Drawing.Point(127, 372);
            this.Agregar_Producto.Name = "Agregar_Producto";
            this.Agregar_Producto.Size = new System.Drawing.Size(91, 68);
            this.Agregar_Producto.TabIndex = 12;
            this.Agregar_Producto.Text = "Agregar producto\r\na la venta\r\n";
            this.Agregar_Producto.UseVisualStyleBackColor = true;
            this.Agregar_Producto.Click += new System.EventHandler(this.Agregar_Producto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre Producto";
            // 
            // textBox_Nombre_Producto
            // 
            this.textBox_Nombre_Producto.Location = new System.Drawing.Point(41, 318);
            this.textBox_Nombre_Producto.Name = "textBox_Nombre_Producto";
            this.textBox_Nombre_Producto.Size = new System.Drawing.Size(118, 22);
            this.textBox_Nombre_Producto.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID Producto";
            // 
            // comboBox_ID_Producto
            // 
            this.comboBox_ID_Producto.FormattingEnabled = true;
            this.comboBox_ID_Producto.Location = new System.Drawing.Point(38, 249);
            this.comboBox_ID_Producto.Name = "comboBox_ID_Producto";
            this.comboBox_ID_Producto.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ID_Producto.TabIndex = 7;
            this.comboBox_ID_Producto.SelectedIndexChanged += new System.EventHandler(this.comboBox_ID_Producto_SelectedIndexChanged);
            // 
            // Ingresar_Venta
            // 
            this.Ingresar_Venta.Location = new System.Drawing.Point(32, 617);
            this.Ingresar_Venta.Name = "Ingresar_Venta";
            this.Ingresar_Venta.Size = new System.Drawing.Size(115, 29);
            this.Ingresar_Venta.TabIndex = 3;
            this.Ingresar_Venta.Text = "Ingresar Venta";
            this.Ingresar_Venta.UseVisualStyleBackColor = true;
            this.Ingresar_Venta.Click += new System.EventHandler(this.Ingresar_Venta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Cliente";
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(38, 123);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Cliente.TabIndex = 1;
            this.comboBox_Cliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Nueva Venta";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Consultar_Venta);
            this.panel2.Controls.Add(this.dataGridView_Consulta);
            this.panel2.Controls.Add(this.textBox_NombreCliente_Consulta);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBox_ID_cliente_Consulta);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTimePicker_Consulta_Venta);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(418, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 661);
            this.panel2.TabIndex = 3;
            // 
            // Consultar_Venta
            // 
            this.Consultar_Venta.Location = new System.Drawing.Point(67, 229);
            this.Consultar_Venta.Name = "Consultar_Venta";
            this.Consultar_Venta.Size = new System.Drawing.Size(111, 57);
            this.Consultar_Venta.TabIndex = 8;
            this.Consultar_Venta.Text = "Realizar Consulta";
            this.Consultar_Venta.UseVisualStyleBackColor = true;
            this.Consultar_Venta.Click += new System.EventHandler(this.Consultar_Venta_Click);
            // 
            // dataGridView_Consulta
            // 
            this.dataGridView_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Consulta.Location = new System.Drawing.Point(23, 336);
            this.dataGridView_Consulta.Name = "dataGridView_Consulta";
            this.dataGridView_Consulta.RowHeadersWidth = 51;
            this.dataGridView_Consulta.RowTemplate.Height = 24;
            this.dataGridView_Consulta.Size = new System.Drawing.Size(891, 310);
            this.dataGridView_Consulta.TabIndex = 15;
            // 
            // textBox_NombreCliente_Consulta
            // 
            this.textBox_NombreCliente_Consulta.Location = new System.Drawing.Point(66, 181);
            this.textBox_NombreCliente_Consulta.Name = "textBox_NombreCliente_Consulta";
            this.textBox_NombreCliente_Consulta.Size = new System.Drawing.Size(121, 22);
            this.textBox_NombreCliente_Consulta.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre de Cliente";
            // 
            // comboBox_ID_cliente_Consulta
            // 
            this.comboBox_ID_cliente_Consulta.FormattingEnabled = true;
            this.comboBox_ID_cliente_Consulta.Location = new System.Drawing.Point(67, 123);
            this.comboBox_ID_cliente_Consulta.Name = "comboBox_ID_cliente_Consulta";
            this.comboBox_ID_cliente_Consulta.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ID_cliente_Consulta.TabIndex = 4;
            this.comboBox_ID_cliente_Consulta.SelectedIndexChanged += new System.EventHandler(this.comboBox_ID_cliente_Consulta_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "ID Cliente";
            // 
            // dateTimePicker_Consulta_Venta
            // 
            this.dateTimePicker_Consulta_Venta.Location = new System.Drawing.Point(67, 59);
            this.dateTimePicker_Consulta_Venta.Name = "dateTimePicker_Consulta_Venta";
            this.dateTimePicker_Consulta_Venta.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Consulta_Venta.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(104, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Consultar Venta";
            // 
            // checkBox_Terminar_Venta
            // 
            this.checkBox_Terminar_Venta.AutoSize = true;
            this.checkBox_Terminar_Venta.Location = new System.Drawing.Point(32, 503);
            this.checkBox_Terminar_Venta.Name = "checkBox_Terminar_Venta";
            this.checkBox_Terminar_Venta.Size = new System.Drawing.Size(256, 21);
            this.checkBox_Terminar_Venta.TabIndex = 17;
            this.checkBox_Terminar_Venta.Text = "He terminado de agregar productos";
            this.checkBox_Terminar_Venta.UseVisualStyleBackColor = true;
            // 
            // Operaciones_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 812);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Volver);
            this.Name = "Operaciones_Venta";
            this.Text = "Operaciones_Venta";
            this.Load += new System.EventHandler(this.Operaciones_Venta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ingresar_Venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Nombre_Producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_ID_Producto;
        private System.Windows.Forms.Button Agregar_Producto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Cantidad_Producto;
        private System.Windows.Forms.TextBox textBox_ID_Venta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView_Consulta;
        private System.Windows.Forms.TextBox textBox_NombreCliente_Consulta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_ID_cliente_Consulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Consulta_Venta;
        private System.Windows.Forms.Button Consultar_Venta;
        private System.Windows.Forms.CheckBox checkBox_Terminar_Venta;
    }
}