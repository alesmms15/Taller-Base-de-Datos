
namespace Taller_2
{
    partial class Inicio_Admin
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
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_admin = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_usuario.Location = new System.Drawing.Point(325, 152);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(100, 22);
            this.textBox_usuario.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_password.Location = new System.Drawing.Point(325, 252);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 22);
            this.textBox_password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "usuario";
            // 
            // Login_admin
            // 
            this.Login_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_admin.Location = new System.Drawing.Point(312, 317);
            this.Login_admin.Name = "Login_admin";
            this.Login_admin.Size = new System.Drawing.Size(126, 32);
            this.Login_admin.TabIndex = 5;
            this.Login_admin.Text = "Iniciar Sesión";
            this.Login_admin.UseVisualStyleBackColor = true;
            this.Login_admin.Click += new System.EventHandler(this.Login_admin_Click);
            // 
            // boton_cerrar
            // 
            this.boton_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_cerrar.Location = new System.Drawing.Point(713, 12);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(75, 31);
            this.boton_cerrar.TabIndex = 6;
            this.boton_cerrar.Text = "Volver";
            this.boton_cerrar.UseVisualStyleBackColor = true;
            this.boton_cerrar.Click += new System.EventHandler(this.boton_cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(268, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 282);
            this.panel1.TabIndex = 7;
            // 
            // Inicio_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton_cerrar);
            this.Controls.Add(this.Login_admin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio_Admin";
            this.Text = "Inicio_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_admin;
        private System.Windows.Forms.Button boton_cerrar;
        private System.Windows.Forms.Panel panel1;
    }
}