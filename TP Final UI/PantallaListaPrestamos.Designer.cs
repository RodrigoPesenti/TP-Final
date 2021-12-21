
namespace TP_Final_UI
{
    partial class PantallaListaPrestamos
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
            this.checkedListBoxFiltro = new System.Windows.Forms.CheckedListBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.botonFiltrar = new System.Windows.Forms.Button();
            this.listaPrestamos = new System.Windows.Forms.DataGridView();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaIDEjemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonDevolver = new System.Windows.Forms.Button();
            this.botonExtenderPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxFiltro
            // 
            this.checkedListBoxFiltro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkedListBoxFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxFiltro.CheckOnClick = true;
            this.checkedListBoxFiltro.FormattingEnabled = true;
            this.checkedListBoxFiltro.Items.AddRange(new object[] {
            "ID",
            "Libro",
            "Usuario"});
            this.checkedListBoxFiltro.Location = new System.Drawing.Point(441, 13);
            this.checkedListBoxFiltro.Name = "checkedListBoxFiltro";
            this.checkedListBoxFiltro.Size = new System.Drawing.Size(120, 54);
            this.checkedListBoxFiltro.TabIndex = 10;
            this.checkedListBoxFiltro.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxFiltro_ItemCheck);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(90, 29);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.PlaceholderText = "Ingrese su parametro a filtrar";
            this.textBoxFiltro.Size = new System.Drawing.Size(260, 23);
            this.textBoxFiltro.TabIndex = 9;
            // 
            // botonFiltrar
            // 
            this.botonFiltrar.Location = new System.Drawing.Point(360, 29);
            this.botonFiltrar.Name = "botonFiltrar";
            this.botonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.botonFiltrar.TabIndex = 8;
            this.botonFiltrar.Text = "Buscar";
            this.botonFiltrar.UseVisualStyleBackColor = true;
            this.botonFiltrar.Click += new System.EventHandler(this.botonFiltrar_Click);
            // 
            // listaPrestamos
            // 
            this.listaPrestamos.AllowUserToAddRows = false;
            this.listaPrestamos.AllowUserToDeleteRows = false;
            this.listaPrestamos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listaPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaID,
            this.ColumnaIDEjemplar,
            this.ColumnaNombreLibro,
            this.ColumnaNombreUsuario,
            this.ColumnaFechaPrestamo,
            this.ColumnaFechaDevolucion});
            this.listaPrestamos.Location = new System.Drawing.Point(60, 73);
            this.listaPrestamos.MultiSelect = false;
            this.listaPrestamos.Name = "listaPrestamos";
            this.listaPrestamos.ReadOnly = true;
            this.listaPrestamos.RowTemplate.Height = 25;
            this.listaPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaPrestamos.Size = new System.Drawing.Size(675, 304);
            this.listaPrestamos.TabIndex = 7;
            this.listaPrestamos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.listaPrestamos_RowsAdded);
            // 
            // ColumnaID
            // 
            this.ColumnaID.HeaderText = "ID";
            this.ColumnaID.Name = "ColumnaID";
            this.ColumnaID.ReadOnly = true;
            this.ColumnaID.Width = 50;
            // 
            // ColumnaIDEjemplar
            // 
            this.ColumnaIDEjemplar.HeaderText = "ID Ejemplar";
            this.ColumnaIDEjemplar.Name = "ColumnaIDEjemplar";
            this.ColumnaIDEjemplar.ReadOnly = true;
            // 
            // ColumnaNombreLibro
            // 
            this.ColumnaNombreLibro.HeaderText = "Libro";
            this.ColumnaNombreLibro.Name = "ColumnaNombreLibro";
            this.ColumnaNombreLibro.ReadOnly = true;
            this.ColumnaNombreLibro.Width = 150;
            // 
            // ColumnaNombreUsuario
            // 
            this.ColumnaNombreUsuario.HeaderText = "Usuario";
            this.ColumnaNombreUsuario.Name = "ColumnaNombreUsuario";
            this.ColumnaNombreUsuario.ReadOnly = true;
            this.ColumnaNombreUsuario.Width = 130;
            // 
            // ColumnaFechaPrestamo
            // 
            this.ColumnaFechaPrestamo.HeaderText = "Fecha Prestamo";
            this.ColumnaFechaPrestamo.Name = "ColumnaFechaPrestamo";
            this.ColumnaFechaPrestamo.ReadOnly = true;
            // 
            // ColumnaFechaDevolucion
            // 
            this.ColumnaFechaDevolucion.HeaderText = "Fecha Devolucion";
            this.ColumnaFechaDevolucion.Name = "ColumnaFechaDevolucion";
            this.ColumnaFechaDevolucion.ReadOnly = true;
            // 
            // botonDevolver
            // 
            this.botonDevolver.Location = new System.Drawing.Point(90, 392);
            this.botonDevolver.Name = "botonDevolver";
            this.botonDevolver.Size = new System.Drawing.Size(98, 30);
            this.botonDevolver.TabIndex = 11;
            this.botonDevolver.Text = "Devolver";
            this.botonDevolver.UseVisualStyleBackColor = true;
            this.botonDevolver.Click += new System.EventHandler(this.botonDevolver_Click);
            // 
            // botonExtenderPrestamo
            // 
            this.botonExtenderPrestamo.Location = new System.Drawing.Point(207, 392);
            this.botonExtenderPrestamo.Name = "botonExtenderPrestamo";
            this.botonExtenderPrestamo.Size = new System.Drawing.Size(115, 30);
            this.botonExtenderPrestamo.TabIndex = 12;
            this.botonExtenderPrestamo.Text = "Extender Prestamo";
            this.botonExtenderPrestamo.UseVisualStyleBackColor = true;
            this.botonExtenderPrestamo.Click += new System.EventHandler(this.botonExtenderPrestamo_Click);
            // 
            // PantallaListaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonExtenderPrestamo);
            this.Controls.Add(this.botonDevolver);
            this.Controls.Add(this.checkedListBoxFiltro);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.botonFiltrar);
            this.Controls.Add(this.listaPrestamos);
            this.Name = "PantallaListaPrestamos";
            this.Text = "PantallaListaPrestamos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaListaPrestamos_FormClosed);
            this.Load += new System.EventHandler(this.PantallaListaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxFiltro;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button botonFiltrar;
        private System.Windows.Forms.DataGridView listaPrestamos;
        private System.Windows.Forms.Button botonDevolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaIDEjemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFechaDevolucion;
        private System.Windows.Forms.Button botonExtenderPrestamo;
    }
}