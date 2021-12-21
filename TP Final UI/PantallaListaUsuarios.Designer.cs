
namespace TP_Final_UI
{
    partial class PantallaListaUsuarios
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
            this.listaUsuarios = new System.Windows.Forms.DataGridView();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListBoxFiltro = new System.Windows.Forms.CheckedListBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.botonFiltrar = new System.Windows.Forms.Button();
            this.botonAgregarUsuario = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.AllowUserToAddRows = false;
            this.listaUsuarios.AllowUserToDeleteRows = false;
            this.listaUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre,
            this.ColumnaPuntos,
            this.ColumnaTipoUsuario,
            this.ColumnaMail});
            this.listaUsuarios.Location = new System.Drawing.Point(75, 75);
            this.listaUsuarios.MultiSelect = false;
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.ReadOnly = true;
            this.listaUsuarios.RowTemplate.Height = 25;
            this.listaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUsuarios.Size = new System.Drawing.Size(621, 304);
            this.listaUsuarios.TabIndex = 1;
            this.listaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaUsuarios_CellClick);
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            this.ColumnaNombre.Width = 150;
            // 
            // ColumnaPuntos
            // 
            this.ColumnaPuntos.HeaderText = "Puntos";
            this.ColumnaPuntos.Name = "ColumnaPuntos";
            this.ColumnaPuntos.ReadOnly = true;
            this.ColumnaPuntos.Width = 80;
            // 
            // ColumnaTipoUsuario
            // 
            this.ColumnaTipoUsuario.HeaderText = "Tipo de Usuario";
            this.ColumnaTipoUsuario.Name = "ColumnaTipoUsuario";
            this.ColumnaTipoUsuario.ReadOnly = true;
            this.ColumnaTipoUsuario.Width = 150;
            // 
            // ColumnaMail
            // 
            this.ColumnaMail.HeaderText = "Mail";
            this.ColumnaMail.Name = "ColumnaMail";
            this.ColumnaMail.ReadOnly = true;
            this.ColumnaMail.Width = 200;
            // 
            // checkedListBoxFiltro
            // 
            this.checkedListBoxFiltro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkedListBoxFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxFiltro.CheckOnClick = true;
            this.checkedListBoxFiltro.FormattingEnabled = true;
            this.checkedListBoxFiltro.Items.AddRange(new object[] {
            "Nombre",
            "Mail",
            "Tipo de Usuario"});
            this.checkedListBoxFiltro.Location = new System.Drawing.Point(426, 9);
            this.checkedListBoxFiltro.Name = "checkedListBoxFiltro";
            this.checkedListBoxFiltro.Size = new System.Drawing.Size(120, 54);
            this.checkedListBoxFiltro.TabIndex = 6;
            this.checkedListBoxFiltro.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxFiltro_ItemCheck);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(75, 25);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.PlaceholderText = "Ingrese su parametro a filtrar";
            this.textBoxFiltro.Size = new System.Drawing.Size(260, 23);
            this.textBoxFiltro.TabIndex = 5;
            // 
            // botonFiltrar
            // 
            this.botonFiltrar.Location = new System.Drawing.Point(345, 25);
            this.botonFiltrar.Name = "botonFiltrar";
            this.botonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.botonFiltrar.TabIndex = 4;
            this.botonFiltrar.Text = "Buscar";
            this.botonFiltrar.UseVisualStyleBackColor = true;
            this.botonFiltrar.Click += new System.EventHandler(this.botonFiltrar_Click);
            // 
            // botonAgregarUsuario
            // 
            this.botonAgregarUsuario.Location = new System.Drawing.Point(75, 400);
            this.botonAgregarUsuario.Name = "botonAgregarUsuario";
            this.botonAgregarUsuario.Size = new System.Drawing.Size(113, 38);
            this.botonAgregarUsuario.TabIndex = 7;
            this.botonAgregarUsuario.Text = "Agregar Usuario";
            this.botonAgregarUsuario.UseVisualStyleBackColor = true;
            this.botonAgregarUsuario.Click += new System.EventHandler(this.botonAgregarUsuario_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(583, 400);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(113, 38);
            this.botonAceptar.TabIndex = 8;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // PantallaListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonAgregarUsuario);
            this.Controls.Add(this.checkedListBoxFiltro);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.botonFiltrar);
            this.Controls.Add(this.listaUsuarios);
            this.Name = "PantallaListaUsuarios";
            this.Text = "PantallaListaUsuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaListaUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.PantallaListaUsuarios_Load);
            this.VisibleChanged += new System.EventHandler(this.PantallaListaUsuarios_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMail;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiltro;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button botonFiltrar;
        private System.Windows.Forms.Button botonAgregarUsuario;
        private System.Windows.Forms.Button botonAceptar;
    }
}