
namespace TP_Final_UI
{
    partial class PantallaListaLibros
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
            this.ColumnaCantEjemplares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonFiltrar = new System.Windows.Forms.Button();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.checkedListBoxFiltro = new System.Windows.Forms.CheckedListBox();
            this.buttonAgregarEjemplar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMostrarEjemplares = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaLibros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaLibros
            // 
            this.listaLibros.AllowUserToAddRows = false;
            this.listaLibros.AllowUserToDeleteRows = false;
            this.listaLibros.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listaLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaTitulo,
            this.ColumnaAutor,
            this.ColumnaISBN,
            this.ColumnaCantEjemplares});
            this.listaLibros.Location = new System.Drawing.Point(46, 97);
            this.listaLibros.MultiSelect = false;
            this.listaLibros.Name = "listaLibros";
            this.listaLibros.ReadOnly = true;
            this.listaLibros.RowTemplate.Height = 25;
            this.listaLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaLibros.Size = new System.Drawing.Size(716, 341);
            this.listaLibros.TabIndex = 0;
            this.listaLibros.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.listaLibros_RowsAdded);
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
            this.ColumnaAutor.Width = 200;
            // 
            // ColumnaISBN
            // 
            this.ColumnaISBN.HeaderText = "ISBN";
            this.ColumnaISBN.Name = "ColumnaISBN";
            this.ColumnaISBN.ReadOnly = true;
            this.ColumnaISBN.Width = 150;
            // 
            // ColumnaCantEjemplares
            // 
            this.ColumnaCantEjemplares.HeaderText = "Cant. Ejemplares Disponibles";
            this.ColumnaCantEjemplares.Name = "ColumnaCantEjemplares";
            this.ColumnaCantEjemplares.ReadOnly = true;
            this.ColumnaCantEjemplares.Width = 70;
            // 
            // botonFiltrar
            // 
            this.botonFiltrar.Location = new System.Drawing.Point(316, 46);
            this.botonFiltrar.Name = "botonFiltrar";
            this.botonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.botonFiltrar.TabIndex = 1;
            this.botonFiltrar.Text = "Buscar";
            this.botonFiltrar.UseVisualStyleBackColor = true;
            this.botonFiltrar.Click += new System.EventHandler(this.botonFiltrar_Click);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(46, 46);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.PlaceholderText = "Ingrese su parametro a filtrar";
            this.textBoxFiltro.Size = new System.Drawing.Size(260, 23);
            this.textBoxFiltro.TabIndex = 2;
            // 
            // checkedListBoxFiltro
            // 
            this.checkedListBoxFiltro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkedListBoxFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxFiltro.CheckOnClick = true;
            this.checkedListBoxFiltro.FormattingEnabled = true;
            this.checkedListBoxFiltro.Items.AddRange(new object[] {
            "Titulo",
            "Autor",
            "ISBN"});
            this.checkedListBoxFiltro.Location = new System.Drawing.Point(397, 30);
            this.checkedListBoxFiltro.Name = "checkedListBoxFiltro";
            this.checkedListBoxFiltro.Size = new System.Drawing.Size(120, 54);
            this.checkedListBoxFiltro.TabIndex = 3;
            this.checkedListBoxFiltro.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxFiltro_ItemCheck);
            // 
            // buttonAgregarEjemplar
            // 
            this.buttonAgregarEjemplar.Location = new System.Drawing.Point(18, 37);
            this.buttonAgregarEjemplar.Name = "buttonAgregarEjemplar";
            this.buttonAgregarEjemplar.Size = new System.Drawing.Size(125, 37);
            this.buttonAgregarEjemplar.TabIndex = 4;
            this.buttonAgregarEjemplar.Text = "Agregar Ejemplar";
            this.buttonAgregarEjemplar.UseVisualStyleBackColor = true;
            this.buttonAgregarEjemplar.Click += new System.EventHandler(this.buttonAgregarEjemplar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMostrarEjemplares);
            this.groupBox1.Controls.Add(this.buttonAgregarEjemplar);
            this.groupBox1.Location = new System.Drawing.Point(12, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interactuar con libro seleccionado";
            // 
            // buttonMostrarEjemplares
            // 
            this.buttonMostrarEjemplares.Location = new System.Drawing.Point(169, 37);
            this.buttonMostrarEjemplares.Name = "buttonMostrarEjemplares";
            this.buttonMostrarEjemplares.Size = new System.Drawing.Size(125, 37);
            this.buttonMostrarEjemplares.TabIndex = 6;
            this.buttonMostrarEjemplares.Text = "Mostrar Ejemplares";
            this.buttonMostrarEjemplares.UseVisualStyleBackColor = true;
            this.buttonMostrarEjemplares.Click += new System.EventHandler(this.buttonMostrarEjemplares_Click);
            // 
            // PantallaListaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBoxFiltro);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.botonFiltrar);
            this.Controls.Add(this.listaLibros);
            this.Name = "PantallaListaLibros";
            this.Text = "PantallaListaLibros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaListaLibros_FormClosed);
            this.Load += new System.EventHandler(this.PantallaListaLibros_Load);
            this.VisibleChanged += new System.EventHandler(this.PantallaListaLibros_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.listaLibros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaLibros;
        private System.Windows.Forms.Button botonFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiltro;
        private System.Windows.Forms.Button buttonAgregarEjemplar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMostrarEjemplares;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantEjemplares;
    }
}