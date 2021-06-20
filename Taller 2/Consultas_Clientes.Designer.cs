
namespace Taller_2
{
    partial class Consultas_Clientes
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
            this.comboBox_clientesNacionalesProductoCodigo = new System.Windows.Forms.ComboBox();
            this.textBox_clientesNacionalesProductoNombre = new System.Windows.Forms.TextBox();
            this.dataGridView_clientesNacionalesProducto = new System.Windows.Forms.DataGridView();
            this.clientesNacionalesProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clientesExtranjerosProducto = new System.Windows.Forms.Button();
            this.dataGridView_clientesExtranjerosProducto = new System.Windows.Forms.DataGridView();
            this.textBox_clientesExtranjerosProductoNombre = new System.Windows.Forms.TextBox();
            this.comboBox_clientesExtranjerosProductoCodigo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.todosClientesProducto = new System.Windows.Forms.Button();
            this.dataGridView_todosClientesProducto = new System.Windows.Forms.DataGridView();
            this.textBox_todosClientesNombre = new System.Windows.Forms.TextBox();
            this.comboBox_todosClientesCodigo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientesNacionalesProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientesExtranjerosProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todosClientesProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_clientesNacionalesProductoCodigo
            // 
            this.comboBox_clientesNacionalesProductoCodigo.FormattingEnabled = true;
            this.comboBox_clientesNacionalesProductoCodigo.Location = new System.Drawing.Point(120, 75);
            this.comboBox_clientesNacionalesProductoCodigo.Name = "comboBox_clientesNacionalesProductoCodigo";
            this.comboBox_clientesNacionalesProductoCodigo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_clientesNacionalesProductoCodigo.TabIndex = 0;
            this.comboBox_clientesNacionalesProductoCodigo.DropDown += new System.EventHandler(this.comboBox_clientesNacionalesProductoCodigo_DropDown);
            this.comboBox_clientesNacionalesProductoCodigo.SelectedIndexChanged += new System.EventHandler(this.comboBox_clientesNacionalesProductoCodigo_SelectedIndexChanged);
            // 
            // textBox_clientesNacionalesProductoNombre
            // 
            this.textBox_clientesNacionalesProductoNombre.Location = new System.Drawing.Point(120, 111);
            this.textBox_clientesNacionalesProductoNombre.Name = "textBox_clientesNacionalesProductoNombre";
            this.textBox_clientesNacionalesProductoNombre.Size = new System.Drawing.Size(121, 20);
            this.textBox_clientesNacionalesProductoNombre.TabIndex = 1;
            // 
            // dataGridView_clientesNacionalesProducto
            // 
            this.dataGridView_clientesNacionalesProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clientesNacionalesProducto.Location = new System.Drawing.Point(49, 200);
            this.dataGridView_clientesNacionalesProducto.Name = "dataGridView_clientesNacionalesProducto";
            this.dataGridView_clientesNacionalesProducto.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_clientesNacionalesProducto.TabIndex = 2;
            // 
            // clientesNacionalesProducto
            // 
            this.clientesNacionalesProducto.Location = new System.Drawing.Point(120, 153);
            this.clientesNacionalesProducto.Name = "clientesNacionalesProducto";
            this.clientesNacionalesProducto.Size = new System.Drawing.Size(121, 23);
            this.clientesNacionalesProducto.TabIndex = 3;
            this.clientesNacionalesProducto.Text = "Consultar";
            this.clientesNacionalesProducto.UseVisualStyleBackColor = true;
            this.clientesNacionalesProducto.Click += new System.EventHandler(this.clientesNacionalesProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clientes nacionales que han comprado un cierto producto este año";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 53);
            this.label4.TabIndex = 13;
            this.label4.Text = "Clientes extranjeros que han comprado un cierto producto este año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre del producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Código del producto";
            // 
            // clientesExtranjerosProducto
            // 
            this.clientesExtranjerosProducto.Location = new System.Drawing.Point(455, 153);
            this.clientesExtranjerosProducto.Name = "clientesExtranjerosProducto";
            this.clientesExtranjerosProducto.Size = new System.Drawing.Size(121, 23);
            this.clientesExtranjerosProducto.TabIndex = 10;
            this.clientesExtranjerosProducto.Text = "Consultar";
            this.clientesExtranjerosProducto.UseVisualStyleBackColor = true;
            this.clientesExtranjerosProducto.Click += new System.EventHandler(this.clientesExtranjerosProducto_Click);
            // 
            // dataGridView_clientesExtranjerosProducto
            // 
            this.dataGridView_clientesExtranjerosProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clientesExtranjerosProducto.Location = new System.Drawing.Point(384, 200);
            this.dataGridView_clientesExtranjerosProducto.Name = "dataGridView_clientesExtranjerosProducto";
            this.dataGridView_clientesExtranjerosProducto.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_clientesExtranjerosProducto.TabIndex = 9;
            // 
            // textBox_clientesExtranjerosProductoNombre
            // 
            this.textBox_clientesExtranjerosProductoNombre.Location = new System.Drawing.Point(455, 111);
            this.textBox_clientesExtranjerosProductoNombre.Name = "textBox_clientesExtranjerosProductoNombre";
            this.textBox_clientesExtranjerosProductoNombre.Size = new System.Drawing.Size(121, 20);
            this.textBox_clientesExtranjerosProductoNombre.TabIndex = 8;
            // 
            // comboBox_clientesExtranjerosProductoCodigo
            // 
            this.comboBox_clientesExtranjerosProductoCodigo.FormattingEnabled = true;
            this.comboBox_clientesExtranjerosProductoCodigo.Location = new System.Drawing.Point(455, 75);
            this.comboBox_clientesExtranjerosProductoCodigo.Name = "comboBox_clientesExtranjerosProductoCodigo";
            this.comboBox_clientesExtranjerosProductoCodigo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_clientesExtranjerosProductoCodigo.TabIndex = 7;
            this.comboBox_clientesExtranjerosProductoCodigo.DropDown += new System.EventHandler(this.comboBox_clientesExtranjerosProductoCodigo_DropDown);
            this.comboBox_clientesExtranjerosProductoCodigo.SelectedIndexChanged += new System.EventHandler(this.comboBox_clientesExtranjerosProductoCodigo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(702, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 53);
            this.label7.TabIndex = 20;
            this.label7.Text = "Todos los clientes que han comprado un cierto producto los últimos 5 años";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(677, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nombre del producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(677, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Código del producto";
            // 
            // todosClientesProducto
            // 
            this.todosClientesProducto.Location = new System.Drawing.Point(785, 153);
            this.todosClientesProducto.Name = "todosClientesProducto";
            this.todosClientesProducto.Size = new System.Drawing.Size(121, 23);
            this.todosClientesProducto.TabIndex = 17;
            this.todosClientesProducto.Text = "Consultar";
            this.todosClientesProducto.UseVisualStyleBackColor = true;
            this.todosClientesProducto.Click += new System.EventHandler(this.todosClientesProducto_Click);
            // 
            // dataGridView_todosClientesProducto
            // 
            this.dataGridView_todosClientesProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_todosClientesProducto.Location = new System.Drawing.Point(714, 200);
            this.dataGridView_todosClientesProducto.Name = "dataGridView_todosClientesProducto";
            this.dataGridView_todosClientesProducto.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_todosClientesProducto.TabIndex = 16;
            // 
            // textBox_todosClientesNombre
            // 
            this.textBox_todosClientesNombre.Location = new System.Drawing.Point(785, 111);
            this.textBox_todosClientesNombre.Name = "textBox_todosClientesNombre";
            this.textBox_todosClientesNombre.Size = new System.Drawing.Size(121, 20);
            this.textBox_todosClientesNombre.TabIndex = 15;
            // 
            // comboBox_todosClientesCodigo
            // 
            this.comboBox_todosClientesCodigo.FormattingEnabled = true;
            this.comboBox_todosClientesCodigo.Location = new System.Drawing.Point(785, 75);
            this.comboBox_todosClientesCodigo.Name = "comboBox_todosClientesCodigo";
            this.comboBox_todosClientesCodigo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_todosClientesCodigo.TabIndex = 14;
            this.comboBox_todosClientesCodigo.DropDown += new System.EventHandler(this.comboBox_todosClientesCodigo_DropDown);
            this.comboBox_todosClientesCodigo.SelectedIndexChanged += new System.EventHandler(this.comboBox_todosClientesCodigo_SelectedIndexChanged);
            // 
            // Consultas_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.todosClientesProducto);
            this.Controls.Add(this.dataGridView_todosClientesProducto);
            this.Controls.Add(this.textBox_todosClientesNombre);
            this.Controls.Add(this.comboBox_todosClientesCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clientesExtranjerosProducto);
            this.Controls.Add(this.dataGridView_clientesExtranjerosProducto);
            this.Controls.Add(this.textBox_clientesExtranjerosProductoNombre);
            this.Controls.Add(this.comboBox_clientesExtranjerosProductoCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientesNacionalesProducto);
            this.Controls.Add(this.dataGridView_clientesNacionalesProducto);
            this.Controls.Add(this.textBox_clientesNacionalesProductoNombre);
            this.Controls.Add(this.comboBox_clientesNacionalesProductoCodigo);
            this.Name = "Consultas_Clientes";
            this.Text = "Consultas_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientesNacionalesProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientesExtranjerosProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_todosClientesProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_clientesNacionalesProductoCodigo;
        private System.Windows.Forms.TextBox textBox_clientesNacionalesProductoNombre;
        private System.Windows.Forms.DataGridView dataGridView_clientesNacionalesProducto;
        private System.Windows.Forms.Button clientesNacionalesProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clientesExtranjerosProducto;
        private System.Windows.Forms.DataGridView dataGridView_clientesExtranjerosProducto;
        private System.Windows.Forms.TextBox textBox_clientesExtranjerosProductoNombre;
        private System.Windows.Forms.ComboBox comboBox_clientesExtranjerosProductoCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button todosClientesProducto;
        private System.Windows.Forms.DataGridView dataGridView_todosClientesProducto;
        private System.Windows.Forms.TextBox textBox_todosClientesNombre;
        private System.Windows.Forms.ComboBox comboBox_todosClientesCodigo;
    }
}