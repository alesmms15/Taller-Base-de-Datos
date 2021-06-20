
namespace Taller_2
{
    partial class Aumentar_Stock
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
            this.comboBox_codigoProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nombreProducto = new System.Windows.Forms.TextBox();
            this.textBox_StockActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_StockSuma = new System.Windows.Forms.TextBox();
            this.button_AumentarStock = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_codigoProducto
            // 
            this.comboBox_codigoProducto.FormattingEnabled = true;
            this.comboBox_codigoProducto.Location = new System.Drawing.Point(521, 166);
            this.comboBox_codigoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_codigoProducto.Name = "comboBox_codigoProducto";
            this.comboBox_codigoProducto.Size = new System.Drawing.Size(160, 24);
            this.comboBox_codigoProducto.TabIndex = 0;
            this.comboBox_codigoProducto.DropDown += new System.EventHandler(this.comboBox_codigoProducto_DropDown);
            this.comboBox_codigoProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox_codigoProducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre producto";
            // 
            // textBox_nombreProducto
            // 
            this.textBox_nombreProducto.Location = new System.Drawing.Point(521, 214);
            this.textBox_nombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_nombreProducto.Name = "textBox_nombreProducto";
            this.textBox_nombreProducto.Size = new System.Drawing.Size(160, 22);
            this.textBox_nombreProducto.TabIndex = 3;
            // 
            // textBox_StockActual
            // 
            this.textBox_StockActual.Location = new System.Drawing.Point(521, 261);
            this.textBox_StockActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_StockActual.Name = "textBox_StockActual";
            this.textBox_StockActual.Size = new System.Drawing.Size(160, 22);
            this.textBox_StockActual.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock a aumentar";
            // 
            // textBox_StockSuma
            // 
            this.textBox_StockSuma.Location = new System.Drawing.Point(521, 306);
            this.textBox_StockSuma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_StockSuma.Name = "textBox_StockSuma";
            this.textBox_StockSuma.Size = new System.Drawing.Size(160, 22);
            this.textBox_StockSuma.TabIndex = 6;
            // 
            // button_AumentarStock
            // 
            this.button_AumentarStock.Location = new System.Drawing.Point(521, 359);
            this.button_AumentarStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_AumentarStock.Name = "button_AumentarStock";
            this.button_AumentarStock.Size = new System.Drawing.Size(161, 28);
            this.button_AumentarStock.TabIndex = 8;
            this.button_AumentarStock.Text = "Aumentar Stock";
            this.button_AumentarStock.UseVisualStyleBackColor = true;
            this.button_AumentarStock.Click += new System.EventHandler(this.button_AumentarStock_Click);
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(980, 12);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 9;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Aumentar_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.button_AumentarStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_StockSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_StockActual);
            this.Controls.Add(this.textBox_nombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_codigoProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Aumentar_Stock";
            this.Text = "AumentarStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_codigoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nombreProducto;
        private System.Windows.Forms.TextBox textBox_StockActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_StockSuma;
        private System.Windows.Forms.Button button_AumentarStock;
        private System.Windows.Forms.Button Volver;
    }
}