
namespace Taller_2
{
    partial class Funciones_Cliente
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
            this.botonIngresarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tipoCliente = new System.Windows.Forms.ComboBox();
            this.codigo_nacional = new System.Windows.Forms.Label();
            this.textBox_codNacional = new System.Windows.Forms.TextBox();
            this.textBox_nomNacional = new System.Windows.Forms.TextBox();
            this.nombre_nacional = new System.Windows.Forms.Label();
            this.textBox_ciudadNacional = new System.Windows.Forms.TextBox();
            this.ciudad_nacional = new System.Windows.Forms.Label();
            this.textBox_ciudadExtranjero = new System.Windows.Forms.TextBox();
            this.ciudad_extranjero = new System.Windows.Forms.Label();
            this.textBox_nomExtranjero = new System.Windows.Forms.TextBox();
            this.nombre_extranjero = new System.Windows.Forms.Label();
            this.textBox_codExtranjero = new System.Windows.Forms.TextBox();
            this.codigo_extranjero = new System.Windows.Forms.Label();
            this.textBox_paisExtranjero = new System.Windows.Forms.TextBox();
            this.pais_extranjero = new System.Windows.Forms.Label();
            this.textBox_clienteId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_clienteNacional = new System.Windows.Forms.ComboBox();
            this.comboBox_clienteExtranjero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eliminarClienteExtranjero = new System.Windows.Forms.Button();
            this.eliminarClienteNacional = new System.Windows.Forms.Button();
            this.comboBox_actualizarCiudad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.actualizarCiudad = new System.Windows.Forms.Button();
            this.textBox_actualizarCiudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonIngresarCliente
            // 
            this.botonIngresarCliente.Location = new System.Drawing.Point(116, 240);
            this.botonIngresarCliente.Name = "botonIngresarCliente";
            this.botonIngresarCliente.Size = new System.Drawing.Size(75, 23);
            this.botonIngresarCliente.TabIndex = 0;
            this.botonIngresarCliente.Text = "Ingresar Cliente";
            this.botonIngresarCliente.UseVisualStyleBackColor = true;
            this.botonIngresarCliente.Click += new System.EventHandler(this.botonIngresarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Cliente";
            // 
            // comboBox_tipoCliente
            // 
            this.comboBox_tipoCliente.AccessibleDescription = "";
            this.comboBox_tipoCliente.AccessibleName = "";
            this.comboBox_tipoCliente.AutoCompleteCustomSource.AddRange(new string[] {
            "Cliente Extranjero",
            "Cliente Nacional"});
            this.comboBox_tipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoCliente.FormattingEnabled = true;
            this.comboBox_tipoCliente.Items.AddRange(new object[] {
            "Cliente nacional",
            "Cliente extranjero"});
            this.comboBox_tipoCliente.Location = new System.Drawing.Point(97, 54);
            this.comboBox_tipoCliente.Name = "comboBox_tipoCliente";
            this.comboBox_tipoCliente.Size = new System.Drawing.Size(114, 21);
            this.comboBox_tipoCliente.TabIndex = 2;
            this.comboBox_tipoCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipoCliente_SelectedIndexChanged);
            // 
            // codigo_nacional
            // 
            this.codigo_nacional.AutoSize = true;
            this.codigo_nacional.Location = new System.Drawing.Point(50, 110);
            this.codigo_nacional.Name = "codigo_nacional";
            this.codigo_nacional.Size = new System.Drawing.Size(40, 13);
            this.codigo_nacional.TabIndex = 3;
            this.codigo_nacional.Text = "Código";
            // 
            // textBox_codNacional
            // 
            this.textBox_codNacional.Location = new System.Drawing.Point(97, 107);
            this.textBox_codNacional.Name = "textBox_codNacional";
            this.textBox_codNacional.Size = new System.Drawing.Size(114, 20);
            this.textBox_codNacional.TabIndex = 4;
            // 
            // textBox_nomNacional
            // 
            this.textBox_nomNacional.Location = new System.Drawing.Point(97, 142);
            this.textBox_nomNacional.Name = "textBox_nomNacional";
            this.textBox_nomNacional.Size = new System.Drawing.Size(114, 20);
            this.textBox_nomNacional.TabIndex = 6;
            // 
            // nombre_nacional
            // 
            this.nombre_nacional.AutoSize = true;
            this.nombre_nacional.Location = new System.Drawing.Point(50, 145);
            this.nombre_nacional.Name = "nombre_nacional";
            this.nombre_nacional.Size = new System.Drawing.Size(44, 13);
            this.nombre_nacional.TabIndex = 5;
            this.nombre_nacional.Text = "Nombre";
            // 
            // textBox_ciudadNacional
            // 
            this.textBox_ciudadNacional.Location = new System.Drawing.Point(97, 177);
            this.textBox_ciudadNacional.Name = "textBox_ciudadNacional";
            this.textBox_ciudadNacional.Size = new System.Drawing.Size(114, 20);
            this.textBox_ciudadNacional.TabIndex = 8;
            // 
            // ciudad_nacional
            // 
            this.ciudad_nacional.AutoSize = true;
            this.ciudad_nacional.Location = new System.Drawing.Point(50, 180);
            this.ciudad_nacional.Name = "ciudad_nacional";
            this.ciudad_nacional.Size = new System.Drawing.Size(40, 13);
            this.ciudad_nacional.TabIndex = 7;
            this.ciudad_nacional.Text = "Ciudad";
            // 
            // textBox_ciudadExtranjero
            // 
            this.textBox_ciudadExtranjero.Location = new System.Drawing.Point(97, 162);
            this.textBox_ciudadExtranjero.Name = "textBox_ciudadExtranjero";
            this.textBox_ciudadExtranjero.Size = new System.Drawing.Size(114, 20);
            this.textBox_ciudadExtranjero.TabIndex = 14;
            // 
            // ciudad_extranjero
            // 
            this.ciudad_extranjero.AutoSize = true;
            this.ciudad_extranjero.Location = new System.Drawing.Point(50, 165);
            this.ciudad_extranjero.Name = "ciudad_extranjero";
            this.ciudad_extranjero.Size = new System.Drawing.Size(40, 13);
            this.ciudad_extranjero.TabIndex = 13;
            this.ciudad_extranjero.Text = "Ciudad";
            // 
            // textBox_nomExtranjero
            // 
            this.textBox_nomExtranjero.Location = new System.Drawing.Point(97, 127);
            this.textBox_nomExtranjero.Name = "textBox_nomExtranjero";
            this.textBox_nomExtranjero.Size = new System.Drawing.Size(114, 20);
            this.textBox_nomExtranjero.TabIndex = 12;
            // 
            // nombre_extranjero
            // 
            this.nombre_extranjero.AutoSize = true;
            this.nombre_extranjero.Location = new System.Drawing.Point(50, 130);
            this.nombre_extranjero.Name = "nombre_extranjero";
            this.nombre_extranjero.Size = new System.Drawing.Size(44, 13);
            this.nombre_extranjero.TabIndex = 11;
            this.nombre_extranjero.Text = "Nombre";
            // 
            // textBox_codExtranjero
            // 
            this.textBox_codExtranjero.Location = new System.Drawing.Point(97, 92);
            this.textBox_codExtranjero.Name = "textBox_codExtranjero";
            this.textBox_codExtranjero.Size = new System.Drawing.Size(114, 20);
            this.textBox_codExtranjero.TabIndex = 10;
            // 
            // codigo_extranjero
            // 
            this.codigo_extranjero.AutoSize = true;
            this.codigo_extranjero.Location = new System.Drawing.Point(50, 95);
            this.codigo_extranjero.Name = "codigo_extranjero";
            this.codigo_extranjero.Size = new System.Drawing.Size(40, 13);
            this.codigo_extranjero.TabIndex = 9;
            this.codigo_extranjero.Text = "Código";
            // 
            // textBox_paisExtranjero
            // 
            this.textBox_paisExtranjero.Location = new System.Drawing.Point(97, 199);
            this.textBox_paisExtranjero.Name = "textBox_paisExtranjero";
            this.textBox_paisExtranjero.Size = new System.Drawing.Size(114, 20);
            this.textBox_paisExtranjero.TabIndex = 16;
            // 
            // pais_extranjero
            // 
            this.pais_extranjero.AutoSize = true;
            this.pais_extranjero.Location = new System.Drawing.Point(50, 202);
            this.pais_extranjero.Name = "pais_extranjero";
            this.pais_extranjero.Size = new System.Drawing.Size(29, 13);
            this.pais_extranjero.TabIndex = 15;
            this.pais_extranjero.Text = "País";
            // 
            // textBox_clienteId
            // 
            this.textBox_clienteId.Location = new System.Drawing.Point(97, 28);
            this.textBox_clienteId.Name = "textBox_clienteId";
            this.textBox_clienteId.Size = new System.Drawing.Size(114, 20);
            this.textBox_clienteId.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cliente Id";
            // 
            // comboBox_clienteNacional
            // 
            this.comboBox_clienteNacional.FormattingEnabled = true;
            this.comboBox_clienteNacional.Location = new System.Drawing.Point(339, 31);
            this.comboBox_clienteNacional.Name = "comboBox_clienteNacional";
            this.comboBox_clienteNacional.Size = new System.Drawing.Size(121, 21);
            this.comboBox_clienteNacional.TabIndex = 19;
            this.comboBox_clienteNacional.DropDown += new System.EventHandler(this.comboBox_clienteNacional_DropDown);
            // 
            // comboBox_clienteExtranjero
            // 
            this.comboBox_clienteExtranjero.FormattingEnabled = true;
            this.comboBox_clienteExtranjero.Location = new System.Drawing.Point(339, 119);
            this.comboBox_clienteExtranjero.Name = "comboBox_clienteExtranjero";
            this.comboBox_clienteExtranjero.Size = new System.Drawing.Size(121, 21);
            this.comboBox_clienteExtranjero.TabIndex = 20;
            this.comboBox_clienteExtranjero.DropDown += new System.EventHandler(this.comboBox_clienteExtranjero_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre Cliente Nacional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre Cliente Extranjero";
            // 
            // eliminarClienteExtranjero
            // 
            this.eliminarClienteExtranjero.Location = new System.Drawing.Point(339, 147);
            this.eliminarClienteExtranjero.Name = "eliminarClienteExtranjero";
            this.eliminarClienteExtranjero.Size = new System.Drawing.Size(121, 36);
            this.eliminarClienteExtranjero.TabIndex = 24;
            this.eliminarClienteExtranjero.Text = "Eliminar Cliente Extranjero";
            this.eliminarClienteExtranjero.UseVisualStyleBackColor = true;
            this.eliminarClienteExtranjero.Click += new System.EventHandler(this.eliminarClienteExtranjero_Click);
            // 
            // eliminarClienteNacional
            // 
            this.eliminarClienteNacional.Location = new System.Drawing.Point(339, 57);
            this.eliminarClienteNacional.Name = "eliminarClienteNacional";
            this.eliminarClienteNacional.Size = new System.Drawing.Size(121, 36);
            this.eliminarClienteNacional.TabIndex = 25;
            this.eliminarClienteNacional.Text = "Eliminar Cliente Nacional";
            this.eliminarClienteNacional.UseVisualStyleBackColor = true;
            this.eliminarClienteNacional.Click += new System.EventHandler(this.eliminarClienteNacional_Click);
            // 
            // comboBox_actualizarCiudad
            // 
            this.comboBox_actualizarCiudad.FormattingEnabled = true;
            this.comboBox_actualizarCiudad.Location = new System.Drawing.Point(615, 31);
            this.comboBox_actualizarCiudad.Name = "comboBox_actualizarCiudad";
            this.comboBox_actualizarCiudad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_actualizarCiudad.TabIndex = 26;
            this.comboBox_actualizarCiudad.DropDown += new System.EventHandler(this.comboBox_actualizarCiudad_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Actualizar Ciudad Cliente Extranjero";
            // 
            // actualizarCiudad
            // 
            this.actualizarCiudad.Location = new System.Drawing.Point(615, 117);
            this.actualizarCiudad.Name = "actualizarCiudad";
            this.actualizarCiudad.Size = new System.Drawing.Size(121, 23);
            this.actualizarCiudad.TabIndex = 28;
            this.actualizarCiudad.Text = "Actualizar ciudad";
            this.actualizarCiudad.UseVisualStyleBackColor = true;
            this.actualizarCiudad.Click += new System.EventHandler(this.actualizarCiudad_Click);
            // 
            // textBox_actualizarCiudad
            // 
            this.textBox_actualizarCiudad.Location = new System.Drawing.Point(615, 73);
            this.textBox_actualizarCiudad.Name = "textBox_actualizarCiudad";
            this.textBox_actualizarCiudad.Size = new System.Drawing.Size(121, 20);
            this.textBox_actualizarCiudad.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nueva ciudad";
            // 
            // Funciones_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_actualizarCiudad);
            this.Controls.Add(this.actualizarCiudad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_actualizarCiudad);
            this.Controls.Add(this.eliminarClienteNacional);
            this.Controls.Add(this.eliminarClienteExtranjero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_clienteExtranjero);
            this.Controls.Add(this.comboBox_clienteNacional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_clienteId);
            this.Controls.Add(this.textBox_paisExtranjero);
            this.Controls.Add(this.pais_extranjero);
            this.Controls.Add(this.textBox_ciudadExtranjero);
            this.Controls.Add(this.ciudad_extranjero);
            this.Controls.Add(this.textBox_nomExtranjero);
            this.Controls.Add(this.nombre_extranjero);
            this.Controls.Add(this.textBox_codExtranjero);
            this.Controls.Add(this.codigo_extranjero);
            this.Controls.Add(this.textBox_ciudadNacional);
            this.Controls.Add(this.ciudad_nacional);
            this.Controls.Add(this.textBox_nomNacional);
            this.Controls.Add(this.nombre_nacional);
            this.Controls.Add(this.textBox_codNacional);
            this.Controls.Add(this.codigo_nacional);
            this.Controls.Add(this.comboBox_tipoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonIngresarCliente);
            this.Name = "Funciones_Cliente";
            this.Text = "Funciones_Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonIngresarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tipoCliente;
        private System.Windows.Forms.Label codigo_nacional;
        private System.Windows.Forms.TextBox textBox_codNacional;
        private System.Windows.Forms.TextBox textBox_nomNacional;
        private System.Windows.Forms.Label nombre_nacional;
        private System.Windows.Forms.TextBox textBox_ciudadNacional;
        private System.Windows.Forms.Label ciudad_nacional;
        private System.Windows.Forms.TextBox textBox_ciudadExtranjero;
        private System.Windows.Forms.Label ciudad_extranjero;
        private System.Windows.Forms.TextBox textBox_nomExtranjero;
        private System.Windows.Forms.Label nombre_extranjero;
        private System.Windows.Forms.TextBox textBox_codExtranjero;
        private System.Windows.Forms.Label codigo_extranjero;
        private System.Windows.Forms.TextBox textBox_paisExtranjero;
        private System.Windows.Forms.Label pais_extranjero;
        private System.Windows.Forms.TextBox textBox_clienteId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_clienteNacional;
        private System.Windows.Forms.ComboBox comboBox_clienteExtranjero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button eliminarClienteExtranjero;
        private System.Windows.Forms.Button eliminarClienteNacional;
        private System.Windows.Forms.ComboBox comboBox_actualizarCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button actualizarCiudad;
        private System.Windows.Forms.TextBox textBox_actualizarCiudad;
        private System.Windows.Forms.Label label6;
    }
}