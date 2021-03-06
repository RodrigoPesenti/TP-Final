
namespace TP_Final_UI
{
    partial class PantallaAltaLibros
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
            this.listaLibros = new System.Windows.Forms.DataGridView();
            this.ColumnaTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textBoxTituloLibro = new System.Windows.Forms.TextBox();
            this.botonAgregarSeleccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // listaLibros
            // 
            this.listaLibros.AllowUserToAddRows = false;
            this.listaLibros.AllowUserToDeleteRows = false;
            this.listaLibros.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listaLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaTitulo,
            this.ColumnaAutor,
            this.ColumnaISBN});
            this.listaLibros.Location = new System.Drawing.Point(12, 79);
            this.listaLibros.MultiSelect = false;
            this.listaLibros.Name = "listaLibros";
            this.listaLibros.ReadOnly = true;
            this.listaLibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listaLibros.RowTemplate.Height = 25;
            this.listaLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaLibros.Size = new System.Drawing.Size(684, 309);
            this.listaLibros.TabIndex = 0;
            // 
            // ColumnaTitulo
            // 
            this.ColumnaTitulo.HeaderText = "Titulo";
            this.ColumnaTitulo.Name = "ColumnaTitulo";
            this.ColumnaTitulo.ReadOnly = true;
            this.ColumnaTitulo.Width = 250;
            // 
            // ColumnaAutor
            // 
            this.ColumnaAutor.HeaderText = "Autor";
            this.ColumnaAutor.Name = "ColumnaAutor";
            this.ColumnaAutor.ReadOnly = true;
            this.ColumnaAutor.Width = 230;
            // 
            // ColumnaISBN
            // 
            this.ColumnaISBN.HeaderText = "ISBN";
            this.ColumnaISBN.Name = "ColumnaISBN";
            this.ColumnaISBN.ReadOnly = true;
            this.ColumnaISBN.Width = 150;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(283, 35);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 1;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // textBoxTituloLibro
            // 
            this.textBoxTituloLibro.AccessibleDescription = "";
            this.textBoxTituloLibro.Location = new System.Drawing.Point(12, 35);
            this.textBoxTituloLibro.Name = "textBoxTituloLibro";
            this.textBoxTituloLibro.PlaceholderText = "Ingrese el titulo del libro a buscar";
            this.textBoxTituloLibro.Size = new System.Drawing.Size(264, 23);
            this.textBoxTituloLibro.TabIndex = 2;
            // 
            // botonAgregarSeleccion
            // 
            this.botonAgregarSeleccion.Enabled = false;
            this.botonAgregarSeleccion.Location = new System.Drawing.Point(566, 394);
            this.botonAgregarSeleccion.Name = "botonAgregarSeleccion";
            this.botonAgregarSeleccion.Size = new System.Drawing.Size(130, 33);
            this.botonAgregarSeleccion.TabIndex = 3;
            this.botonAgregarSeleccion.Text = "Agregar seleccion";
            this.botonAgregarSeleccion.UseVisualStyleBackColor = true;
            this.botonAgregarSeleccion.Click += new System.EventHandler(this.botonAgregarSeleccion_Click);
            // 
            // PantallaAltaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 439);
            this.Controls.Add(this.botonAgregarSeleccion);
            this.Controls.Add(this.textBoxTituloLibro);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.listaLibros);
            this.Name = "PantallaAltaLibros";
            this.Text = "PantallaAltaLibros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaAltaLibros_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.listaLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaISBN;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox textBoxTituloLibro;
        private System.Windows.Forms.Button botonAgregarSeleccion;
    }
}