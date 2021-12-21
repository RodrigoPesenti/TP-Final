
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
            this.botonNuevoLibro = new System.Windows.Forms.Button();
            this.botonListaLibros = new System.Windows.Forms.Button();
            this.botonListaUsuarios = new System.Windows.Forms.Button();
            this.botonCerrarSesion = new System.Windows.Forms.Button();
            this.botonListaPrestamos = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonNuevoLibro
            // 
            this.botonNuevoLibro.Location = new System.Drawing.Point(3, 3);
            this.botonNuevoLibro.Name = "botonNuevoLibro";
            this.botonNuevoLibro.Size = new System.Drawing.Size(99, 32);
            this.botonNuevoLibro.TabIndex = 0;
            this.botonNuevoLibro.Text = "Nuevo Libro";
            this.botonNuevoLibro.UseVisualStyleBackColor = true;
            this.botonNuevoLibro.Click += new System.EventHandler(this.botonNuevoLibro_Click);
            // 
            // botonListaLibros
            // 
            this.botonListaLibros.Location = new System.Drawing.Point(108, 3);
            this.botonListaLibros.Name = "botonListaLibros";
            this.botonListaLibros.Size = new System.Drawing.Size(99, 32);
            this.botonListaLibros.TabIndex = 1;
            this.botonListaLibros.Text = "Lista Libros";
            this.botonListaLibros.UseVisualStyleBackColor = true;
            this.botonListaLibros.Click += new System.EventHandler(this.botonListaLibros_Click);
            // 
            // botonListaUsuarios
            // 
            this.botonListaUsuarios.Location = new System.Drawing.Point(213, 3);
            this.botonListaUsuarios.Name = "botonListaUsuarios";
            this.botonListaUsuarios.Size = new System.Drawing.Size(99, 32);
            this.botonListaUsuarios.TabIndex = 2;
            this.botonListaUsuarios.Text = "Lista Usuarios";
            this.botonListaUsuarios.UseVisualStyleBackColor = true;
            this.botonListaUsuarios.Click += new System.EventHandler(this.botonListaUsuarios_Click);
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.Location = new System.Drawing.Point(423, 3);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Size = new System.Drawing.Size(99, 32);
            this.botonCerrarSesion.TabIndex = 3;
            this.botonCerrarSesion.Text = "Cerrar sesion";
            this.botonCerrarSesion.UseVisualStyleBackColor = true;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // botonListaPrestamos
            // 
            this.botonListaPrestamos.Location = new System.Drawing.Point(318, 3);
            this.botonListaPrestamos.Name = "botonListaPrestamos";
            this.botonListaPrestamos.Size = new System.Drawing.Size(99, 32);
            this.botonListaPrestamos.TabIndex = 4;
            this.botonListaPrestamos.Text = "Lista Prestamos";
            this.botonListaPrestamos.UseVisualStyleBackColor = true;
            this.botonListaPrestamos.Click += new System.EventHandler(this.botonListaPrestamos_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.botonNuevoLibro);
            this.flowLayoutPanel1.Controls.Add(this.botonListaLibros);
            this.flowLayoutPanel1.Controls.Add(this.botonListaUsuarios);
            this.flowLayoutPanel1.Controls.Add(this.botonListaPrestamos);
            this.flowLayoutPanel1.Controls.Add(this.botonCerrarSesion);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(605, 367);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // PantallaUsuarioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 367);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PantallaUsuarioAdministrador";
            this.Text = "PantallaUsuarioAdministrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaUsuarioAdministrador_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonNuevoLibro;
        private System.Windows.Forms.Button botonListaLibros;
        private System.Windows.Forms.Button botonListaUsuarios;
        private System.Windows.Forms.Button botonCerrarSesion;
        private System.Windows.Forms.Button botonListaPrestamos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}