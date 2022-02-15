
namespace TP_Final_UI
{
    partial class PantallaUsuarioAdministrador
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.botonCerrarSesion = new System.Windows.Forms.Button();
            this.botonListaPrestamos = new System.Windows.Forms.Button();
            this.botonListaUsuarios = new System.Windows.Forms.Button();
            this.botonListaLibros = new System.Windows.Forms.Button();
            this.botonNuevoLibro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(20, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 16);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Agregar Libro";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(133, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 16);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Lista de Libros";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(245, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 16);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Lista de Usuarios";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(356, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 16);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Lista de Prestamos";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(484, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(72, 16);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Cerrar Sesion";
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.Image = global::TP_Final_UI.Properties.Resources.Cerrar_Sesion;
            this.botonCerrarSesion.Location = new System.Drawing.Point(467, 4);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Size = new System.Drawing.Size(110, 110);
            this.botonCerrarSesion.TabIndex = 3;
            this.botonCerrarSesion.UseVisualStyleBackColor = true;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // botonListaPrestamos
            // 
            this.botonListaPrestamos.Image = global::TP_Final_UI.Properties.Resources.Lista_Prestamos;
            this.botonListaPrestamos.Location = new System.Drawing.Point(351, 4);
            this.botonListaPrestamos.Name = "botonListaPrestamos";
            this.botonListaPrestamos.Size = new System.Drawing.Size(110, 110);
            this.botonListaPrestamos.TabIndex = 4;
            this.botonListaPrestamos.UseVisualStyleBackColor = true;
            this.botonListaPrestamos.Click += new System.EventHandler(this.botonListaPrestamos_Click);
            // 
            // botonListaUsuarios
            // 
            this.botonListaUsuarios.Image = global::TP_Final_UI.Properties.Resources.Usuarios;
            this.botonListaUsuarios.Location = new System.Drawing.Point(235, 4);
            this.botonListaUsuarios.Name = "botonListaUsuarios";
            this.botonListaUsuarios.Size = new System.Drawing.Size(110, 110);
            this.botonListaUsuarios.TabIndex = 2;
            this.botonListaUsuarios.UseVisualStyleBackColor = true;
            this.botonListaUsuarios.Click += new System.EventHandler(this.botonListaUsuarios_Click);
            // 
            // botonListaLibros
            // 
            this.botonListaLibros.Image = global::TP_Final_UI.Properties.Resources.Lista_Libros;
            this.botonListaLibros.Location = new System.Drawing.Point(119, 4);
            this.botonListaLibros.Name = "botonListaLibros";
            this.botonListaLibros.Size = new System.Drawing.Size(110, 110);
            this.botonListaLibros.TabIndex = 1;
            this.botonListaLibros.UseVisualStyleBackColor = true;
            this.botonListaLibros.Click += new System.EventHandler(this.botonListaLibros_Click);
            // 
            // botonNuevoLibro
            // 
            this.botonNuevoLibro.Image = global::TP_Final_UI.Properties.Resources.Agregar_Libro;
            this.botonNuevoLibro.Location = new System.Drawing.Point(3, 4);
            this.botonNuevoLibro.Name = "botonNuevoLibro";
            this.botonNuevoLibro.Size = new System.Drawing.Size(110, 110);
            this.botonNuevoLibro.TabIndex = 0;
            this.botonNuevoLibro.UseVisualStyleBackColor = true;
            this.botonNuevoLibro.Click += new System.EventHandler(this.botonNuevoLibro_Click);
            // 
            // PantallaUsuarioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 147);
            this.ControlBox = false;
            this.Controls.Add(this.botonNuevoLibro);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.botonListaLibros);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.botonListaUsuarios);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.botonListaPrestamos);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.botonCerrarSesion);
            this.Controls.Add(this.textBox1);
            this.Name = "PantallaUsuarioAdministrador";
            this.Text = "PantallaUsuarioAdministrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaUsuarioAdministrador_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button botonCerrarSesion;
        private System.Windows.Forms.Button botonListaPrestamos;
        private System.Windows.Forms.Button botonListaUsuarios;
        private System.Windows.Forms.Button botonListaLibros;
        private System.Windows.Forms.Button botonNuevoLibro;
    }
}